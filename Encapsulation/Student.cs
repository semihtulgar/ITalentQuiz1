using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {
        private string _fullName;
        private byte _age;

        public void SetFullName(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                Console.WriteLine("Öğrencinin ismi ve soyismi gereklidir!");
            }
            else
            {
                _fullName = fullName;
            }
        }

        public string GetFullName()
        {
            return _fullName;
        }

        public void SetAge(byte age)
        {
            if (age < 6)
            {
                Console.WriteLine("İlkokul eğitimi için yaşı geçerli değil");
            }
            else
            {
                _age = age;
            }
        }

        public byte GetAge()
        {
            return _age;
        }


    }
}
