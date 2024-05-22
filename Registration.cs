using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_26
{
    public class Registration
    {
        public string Email;
        public bool Distance5;
        public bool Distance21;
        public bool Distance42;
        public byte Equipment;
        public double VznosForFond;
        public double VznosForMaraphon;
        public string Fond;
        public DateTime RegistrationTime;

        public Registration() 
        {
            Email = "None";
            Distance5 = false;
            Distance21 = false;
            Distance42 = false;
            Equipment = 0;
            VznosForFond = 0;
            VznosForMaraphon = 0;
            Fond = "";
            RegistrationTime = DateTime.MinValue;
        }

        public Registration(string newEmail, bool d5, bool d21, bool d42, byte variant, double newVFF, int newVFE, string newFond, DateTime ndt)
        {
            Email = newEmail;
            Distance5 = d5;
            Distance21 = d21;
            Distance42 = d42;
            Equipment = variant;
            VznosForFond = newVFF;
            VznosForMaraphon = newVFE;
            Fond = newFond;
            RegistrationTime = ndt;
        }
    }
}
