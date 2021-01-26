using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entitties;
namespace GameProject.Manager
{
    class Validation
    {
        bool FirstName;
        bool LastName;
        bool NationalityId;

      
       
        public bool FirstNameControl(Person person)
        {
            if (person.FirstName.Length <= 3)
            {
                Console.WriteLine("Lütfen geçerli bir isim giriniz");
                return false;
            }
            else
                return true;              
        }
        public bool LastNameControl(Person person)
        {
            if (person.LastName.Length <= 3)
            {
                Console.WriteLine("Lütfen geçerli bir soy isim giriniz");
                return false;
            }
            else
                return true;
        }
        public bool TcKontrol(Person person)
        {
            if (person.NationalityId.Length < 11)
            {
                Console.WriteLine("Lütfen geçerli bir TC Kimlik no giriniz.");
                return false;
            }
            else
                return true;
        }
        public bool Result (Person person)
        {
            if (FirstNameControl(person) == true && LastNameControl(person) == true && TcKontrol(person) == true)
            {
                return true;
            }
            else
                return false;
        }
    }
   
}
