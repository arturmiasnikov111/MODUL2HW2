using System;

namespace module_2_homeTask2
{
    public class User
    {
        public User(string name, string email, string phone = "")
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
