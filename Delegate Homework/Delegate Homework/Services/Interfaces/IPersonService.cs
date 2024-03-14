

using Delegate_Homework.Models;

namespace Delegate_Homework.Services.Interfaces
{
    public interface IPersonService
    {
        List<Person> GetAll();
        List <Person> CheckSalary(Predicate<Person> predicate);
        IEnumerable<object> Search(Func<object, bool> value);
    }
}
