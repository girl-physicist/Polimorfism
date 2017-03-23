using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism.Common
{
    public class Person
    {
        // новый тип (перечисление) - создали болванку, потом с помощью рефракторинга сгенерировали тип
        //private Gender gender;
        public Gender gender;
        // поля данных
        public DateTime BirthDate { set; get; }
        public int GetFullYears(DateTime now)
        {
            return (now >= BirthDate) ?
                now.Year - BirthDate.Year : 0;
        }
        public string FirstName { get; set; }
        // {get { return _firstName; 
        // set { _firstName = value; }} 
        public string LasttName { get; set; }
        public string FulltName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LasttName);
            }
        }
        // добавление конструктора (Конструкторы вызываются при создании нового объекта данного класса)
        // начальная инициализация членов класса
        public Person()
        { }
        // конструктор наполняет поля класса начальными значениями, которые передаются через его параметры
        public Person(string firstName, string lastName, Gender gender, DateTime birthDate)
        {
            FirstName = firstName; //  FirstName-это поле текущего класса, firstName-параметр
            LasttName = lastName;
            this.gender = gender;
            BirthDate = birthDate;
        }

    }


}


