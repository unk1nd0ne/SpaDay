using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; }
        private static int nextId = 1;
        public DateTime dateJoined { get; }

        public User()
        {
            Id = nextId;
            nextId++;
            dateJoined = DateTime.Now;
        }

        public User(string name, string email, string password) : this()
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Id == user.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
