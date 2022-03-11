using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Registrodedatos
    {
        private string name;
        private string lastname;
        private DateTime dateOfBirth;
        private int age;
        private string studies;
        private string country;

        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public int Age { get => age; set => age = value; }

        public string Country { get => country; set => country = value; }
        public string Studies { get => studies; set => studies = value; }

        public int AgeCalculator(DateTime time)
        {
            int Age = 0;
            if (time > DateTime.Now)
            {
                MessageBox.Show("Fecha de nacimiento incorrecta");
            }
            else
            {
                Age = (DateTime.Now.Year - time.Year);               
            }

            return Age;
        }
    }
}
