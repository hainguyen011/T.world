using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.world.Shared.Sessions
{
    public static class LoginSession
    {
        public static Guid AccountId { get; set; }
        public static string Role { get; set; }
        public static string Email { get; set; }
        public static string FullName { get; set; }

        public static void Logout()
        {
            AccountId = Guid.Empty;
            Email = null;
            Role = null;
            FullName = null;
        }
    }
}
