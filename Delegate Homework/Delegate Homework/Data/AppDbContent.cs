

using Delegate_Homework.Models;

namespace Delegate_Homework.Data
{
    public class AppDbContent
    {
        public static List<Person> persons;
        public static List<Book> books;

        static AppDbContent()
        {
            persons = new List<Person>()
            {
                new Person()
                {
                    Id = 1,
                    Name="Metin",
                    Surname="Aliyev",
                    Address="Mingecevir",
                    Salary=750
                },

                new Person()
                {
                    Id = 2,
                    Name="Murad",
                    Surname="Agezov",
                    Address="Masali",
                    Salary= 550

                },

                new Person()
                {
                    Id = 3,
                    Name="Ehmed",
                    Surname="Ehmedov",
                    Address="Lenkaran",
                    Salary=1200
                },

                new Person()
                {
                    Id = 4,
                    Name="Hasim",
                    Surname="Nusalov",
                    Address="Baki",
                    Salary= 3000

                },

                new Person()
                {
                    Id = 5,
                    Name= "Cavidan",
                    Surname="Eyubov",
                    Address="Kurdemir",
                    Salary = 1500

                },


            };
            books = new List<Book>
            {
                new Book()
                {
                    Id= 1,
                    Name=" Leyli ve Mecnun",
                    Author = "Nizami"
                },

                new Book()
                {
                    Id= 2,
                    Name = "Isgendername",
                    Author = "Nizami"
                },

                new Book()
                {
                    Id= 3,
                    Name=" Sirler Xezinesi ",
                    Author = "Nizami"
                },

                new Book()
                {
                    Id= 4,
                    Name = "Xosrov ve Shrin",
                    Author = "Nizami"
                },

                new Book()
                {
                    Id= 5,
                    Name = "Yeddi gozel",
                    Author = "Nizami"
                },




            };
        }
    }

   
}
