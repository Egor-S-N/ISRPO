using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPackage
{
    internal class User
    {
        internal string Name { get; set; }
        public string Password { get; set; }

        public User(string name, string password) {
        Name = name;
        Password = password;
        }

        internal string Print()
        {
            return "HELLO WORLD";
        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Password: {Password}";
        }

    }
}
