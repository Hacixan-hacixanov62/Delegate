using Delegate_Homework.Models;

namespace Delegate_Homework.Services.Interfaces
{
    public interface IBookService
    {

        List<Models.Book> GetAll();
        List<Models.Book> CheckSalary(Predicate<Models.Book> predicate);
        IEnumerable<object> Search(Func<object, bool> value);
    }

}
