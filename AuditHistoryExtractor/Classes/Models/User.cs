using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditHistoryExtractor.Classes
{
    public class User
    {
        private Guid userId;
        private String username;
        private String fullName;

        public Guid UserId { get => userId; set => userId = value; }
        public string Username { get => username; set => username = value; }
        public string FullName { get => fullName; set => fullName = value; }

        public User(Guid userId, string username, string fullName)
        {
            this.userId = userId;
            this.username = username;
            this.fullName = fullName;
        }

       
    }
}
