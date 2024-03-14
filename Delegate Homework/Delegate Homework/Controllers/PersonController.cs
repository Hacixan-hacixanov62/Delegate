

using Delegate_Homework.Services;
using Delegate_Homework.Services.Interfaces;

namespace Delegate_Homework.Controllers
{
    public  class PersonController
    {
        private readonly IPersonService _personService;

        public PersonController()
        {
            _personService= new PersonService();
        }
        public void Search()
        {
            var response = _personService.CheckSalary(m => m.Salary >1000);
            foreach (var item in response)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address+ "-" + item.Salary);
            }
        }
    }
}
