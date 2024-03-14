

using Delegate_Homework.Data;
using Delegate_Homework.Models;
using Delegate_Homework.Services.Interfaces;
using System;

namespace Delegate_Homework.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> CheckSalary(Predicate<Person> predicate)
        {
            List<Person> result = new List<Person>();
            foreach (var item in AppDbContent.persons)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public List<Person> GetAll()
        {

            return AppDbContent.persons;
        }

        public IEnumerable<object> Search(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
