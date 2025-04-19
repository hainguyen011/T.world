using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace T.world.server.Services.Helpers
{
    class PasswordHelper
    {
        // Hàm tạo Salt ngẫu nhiên
        public static string GenerateSalt(int length = 16)
        {
            var salt = new byte[length];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        // Mã hóa mật khẩu với Salt và SHA256
        public static string HashPassword(string password, string salt)
        {
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = password + salt;  // Kết hợp mật khẩu và salt
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(bytes);  // Trả về chuỗi đã băm
            }
        }

        // Kiểm tra mật khẩu đã mã hóa
        public static bool VerifyPassword(string enteredPassword, string storedHashedPassword, string salt)
        {
            string hashedEnteredPassword = HashPassword(enteredPassword, salt);
            return hashedEnteredPassword == storedHashedPassword;
        }
    }
}
