using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism.Common
{
    // порождение производного класса
    public class Employee : Person
    {
        // поля
        public string WorkplaceInfo { get; set; }
        public Employee()
        { }
        // firstName: firstName - из конструктора person (имя того, что в скобках): (тот объект, который передался)
        // через ключевое слово base надо явным образом вызвать конструктор класса Person
        public Employee(string firstName, string lastName, Gender gender, DateTime birthDate, string workplaceInfo) : base
            (firstName: firstName, lastName: lastName, gender: gender, birthDate: birthDate)
        {
            WorkplaceInfo = workplaceInfo;
        }
    }
    public class WorkplaceInfo
    {
        public string Company { get; set; }
        public string Staff { get; set; }
        //если сюда что-то добавить, то это не эффектнется на ксасс Employee
        public WorkplaceInfo()
        { }
        public WorkplaceInfo(string company, string staff)
        {
            Company = company;
            Staff = staff;
        }
    }
}
