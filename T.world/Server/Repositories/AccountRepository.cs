﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using T.world.Shared.Models;

namespace T.world.Server.Repositories
{
    public class AccountRepository : IDisposable
    {
        private readonly TworldDBEntities _dbContext;
        private bool _disposed = false;

        public AccountRepository()
        {
            _dbContext = new TworldDBEntities();
        }

        public List<Account> GetAll(string keyword, int page, int pageSize)
        {
            var query = _dbContext.Accounts.AsQueryable();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                query = query.Where(a =>
                    a.first_name.Contains(keyword) ||
                    a.last_name.Contains(keyword) ||
                    a.email.Contains(keyword) ||
                    a.phone.Contains(keyword));
            }

            return query
                .OrderBy(a => a.first_name)
                .ThenBy(a => a.last_name)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToList();
        }

        // Lấy tài khoản theo email hoặc số điện thoại
        public Account GetExistedByEmailOrPhone(string emailOrPhone)
        {
            return _dbContext.Accounts
                .FirstOrDefault(a => a.email == emailOrPhone || a.phone == emailOrPhone);
        }

        // Kiểm tra email đã tồn tại chưa
        public bool IsEmailExists(string email)
        {
            return _dbContext.Accounts.Any(a => a.email == email);
        }

        // Kiểm tra số điện thoại đã tồn tại chưa
        public bool IsPhoneExists(string phone)
        {
            return _dbContext.Accounts.Any(a => a.phone == phone);
        }

        // Lấy tài khoản theo ID
        public Account GetById(Guid id)
        {
            return _dbContext.Accounts.FirstOrDefault(a => a.id == id);
        }

        // Lấy toàn bộ danh sách tài khoản (có thể phân trang sau này)
        public List<Account> GetAll()
        {
            return _dbContext.Accounts.ToList();
        }

        // Thêm mới một tài khoản
        public void Create(Account account)
        {
            _dbContext.Accounts.Add(account);
        }

        // Cập nhật tài khoản
        public void Update(Account account)
        {
            _dbContext.Entry(account).State = System.Data.Entity.EntityState.Modified;
        }

        // Xóa tài khoản
        public void Delete(Guid accountId)
        {
            var account = GetById(accountId);
            if (account != null)
            {
                _dbContext.Accounts.Remove(account);
            }
        }

        // Lưu thay đổi vào database
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        // Giải phóng tài nguyên đúng cách
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int GetTotalAmount()
        {
            return _dbContext.Accounts.Count();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }

                _disposed = true;
            }
        }
    }
}
