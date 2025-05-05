using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using T.world.Shared.Models;
using T.world.server.Services.common;
using T.world.server.Services.Helpers;
using T.world.Server.Repositories;
using T.world.Server.Utilities;
using T.world.Shared.DTOs;

namespace T.world.Services
{
    class AccountService
    {
        private readonly AccountRepository _accountRepository;
        public AccountService()
        {
            _accountRepository = new AccountRepository();
        }


        public ServiceResult RegisterAccount(string firstName, string lastName, string email, string phone, string password, string address)
        {
           

            if (_accountRepository.IsEmailExists(email))
                return ServiceResult.Fail("Email đã được sử dụng.");

            if (_accountRepository.IsPhoneExists(phone))
                return ServiceResult.Fail("Số điện thoại đã được sử dụng.");

            string salt = PasswordHelper.GenerateSalt();
            string hashedPassword = PasswordHelper.HashPassword(password, salt);

            var newAccount = new Account
            {
                id = Guid.NewGuid(),
                first_name = firstName,
                last_name = lastName,
                email = email,
                phone = phone,
                password = hashedPassword,
                address = address,
                role = "USER",
                salt = salt,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };

            try
            {
                _accountRepository.Create(newAccount);
                _accountRepository.Save();
                return ServiceResult.Ok("Đăng ký thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        public ServiceResultLogin<LoginResult> Login(string emailOrPhone, string password)
        {

            using (var db = new TworldDBEntities())
            {
                var account = db.Accounts.FirstOrDefault(a => a.email == emailOrPhone || a.phone == emailOrPhone);
                if (account == null)
                {
                    return ServiceResultLogin<LoginResult>.Fail("Tài khoản không tồn tại.");
                }

                string storedHashedPassword = account.password;
                string storedSalt = account.salt;

                bool isPasswordCorrect = PasswordHelper.VerifyPassword(password, storedHashedPassword, storedSalt);
                

                if (isPasswordCorrect)
                {
                    var loginResult = new LoginResult
                    {
                        Message = "Đăng nhập thành công!",
                        Id = account.id.ToString(),
                        Role = account.role,
                        Email = account.email,
                        Fullname = account.first_name + " " + account.last_name,

                    };
                    return ServiceResultLogin<LoginResult>.Ok(loginResult, "Đăng nhập thành công!");
                }
                else
                {
                    return ServiceResultLogin<LoginResult>.Fail("Mật khẩu không đúng.");
                }
            }
        }

        public List<Account> GetListAccount(string keyword, int page, int pageSize)
        {
            return _accountRepository.GetAll(keyword, page, pageSize);
        }

        public ServiceResult DeleteAccount(Guid id)
        {
            var existing = _accountRepository.GetById(id);
            if (existing == null)
                return ServiceResult.Fail("Tài khoản không tồn tại.");

            try
            {
                _accountRepository.Delete(id);
                _accountRepository.Save();
                return ServiceResult.Ok("Xóa tài khoản thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        public ServiceResult UpdateAccount(Guid id, AccountDTO updatedAccount)
        {
            var existing = _accountRepository.GetById(id);
            if (existing == null)
                return ServiceResult.Fail("Tài khoản không tồn tại.");

            existing.first_name = updatedAccount.firstName;
            existing.last_name = updatedAccount.lastName;
            existing.email = updatedAccount.email;
            existing.phone = updatedAccount.phone;
            existing.address = updatedAccount.address;
            existing.role = updatedAccount.role;
            existing.updated_at = DateTime.Now;

            try
            {
                _accountRepository.Update(existing);
                _accountRepository.Save();
                return ServiceResult.Ok("Cập nhật tài khoản thành công!");
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.Message;
                return ServiceResult.Fail("Lỗi hệ thống: " + inner);
            }
        }

        public int GetTotalAccount()
        {
            int total = _accountRepository.GetTotalAmount();
            return total;
        }
    }
}
