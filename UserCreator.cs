using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_dev8
{
    public class UserCreator
    {
        private User user;

        public UserCreator()
        {
            user = new User();
        }

        public void SetFirstName(string name)
        {
            if (name.Equals(string.Empty))
            {
                throw new ArgumentException();
            }

            user.FirstName = name;
        }

        public void SetLastname(string lastname, List<User> list)
        {
            if (lastname.Equals(string.Empty))
            {
                throw new ArgumentException();
            }
            user.Lastname = lastname;
        }

        public void SetAge(string age)
        {
            user.Age = UInt32.Parse(age);
        }

        public void SetSex(string sex)
        {
            if (sex != "man" && sex != "woman")
            {
                throw new ArgumentException();
            }

            if (sex == "man") user.Sex = true;
            else user.Sex = false;
        }

        public User Build()
        {
            return user;
        }
    }
}
