using Polimorfism.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // инициализация происходит до получения ссылки на объект, полученной оператором new
            Person p1 = new Person("John", "Silver", Gender.Male, new DateTime(1687, 1, 1));
            // инициализация происходит после получения ссылки на объект, полученной оператором new
            Person p2 = new Person()
            {
                FirstName = "John",
                LasttName = "Silver",
                gender = Gender.Male,
                BirthDate = new DateTime(1687, 1, 1)
            };
            Employee wsi = new Employee("John", "Silver", Gender.Male, new DateTime(1687, 1, 1), "III");
            WorkplaceInfo info = new WorkplaceInfo("III", "ddd");
            // .Now - статическое свойство (метод) - для его выполнения объект не нужен
            Console.WriteLine("{0} Age {1} ", p2.FulltName, p2.GetFullYears(DateTime.Now), p2.gender);
            Console.WriteLine("Gender {0}", wsi.gender);
            Console.WriteLine("Company {0} Staff {1}", info.Company, info.Staff);
            Console.ReadKey();
        }
    }
}
