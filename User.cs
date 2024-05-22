using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_26
{
    public class User
    {
        public string Email;
        public string Password;
        public string FirstName;
        public string SecondName;
        public byte Sex;
        public string PathToPhoto;
        public DateTime Bithday;
        public int Country;

        public User() {
            Email = "";
            Password = "";
            FirstName = "";
            SecondName = "";
            Sex = 0;
            PathToPhoto = "";
            Bithday = DateTime.MinValue;
            Country = 0;
        }

        public User(
            string newEmail, string newPassword, 
            string newFirstName, string newSecondName, 
            byte newSex, string newPathToPhoto, 
            DateTime newBithday, int newCountry
        )
        {
            Email = newEmail;
            Password = newPassword;
            FirstName = newFirstName;
            SecondName = newSecondName;
            Sex = newSex;
            PathToPhoto = newPathToPhoto;
            Bithday = newBithday;
            Country = newCountry;
        }
    }
}
