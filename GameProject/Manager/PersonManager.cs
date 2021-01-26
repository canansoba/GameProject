using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entitties;
namespace GameProject.Manager
{
    class PersonManager
    {
        List<Person> people = new List<Person>();
        Validation validation = new Validation();
        public void ValifationControl(Person person)
        {
            if (validation.Result(person) == true)
            {
                people.Add(new Person()
                {
                    FirstName = person.FirstName,
                    LastName = person.LastName,
                    NationalityId = person.NationalityId
                }
                );
            }
        }
    }
}
