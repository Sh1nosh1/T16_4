using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16_4
{
    class Staff
    {
        /// <summary>
        /// Staff number
        /// </summary>
        private int number;

        public int Number { get => (number > 0)? number : 0; set => number = value; }
        /// <summary>
        /// Staff names
        /// </summary>
        private string name;

        public string Name { get => (name != "" && name != " ")? name : "Unknown"; set => name = value; }
        /// <summary>
        /// Staff surnames
        /// </summary>
        private string surname;

        public string Surname { get => (surname != "" && surname != " ")? surname : "Unknown"; set => surname = value; }
        /// <summary>
        /// Staff patronymics
        /// </summary>
        private string patronymic;

        public string Patronymic { get => (patronymic != "" && patronymic != " ")? patronymic : "Unknown"; set => patronymic = value; }
        /// <summary>
        /// Staff dates of birth
        /// </summary>
        private DateTime birthday;

        public DateTime Birthday { get => birthday; set => birthday = value; }
        /// <summary>
        /// Staff positions
        /// </summary>
        private string position;

        public string Position { get => (position != "" && position != " ")? position : "None"; set => position = value; }
        /// <summary>
        /// Staff salary
        /// </summary>
        private double salary;

        public double Salary { get => (salary > 0)? salary : 0; set => salary = value; }
        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Staff() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="number">Inializiitng stuff numbers</param>
        /// <param name="name">Initializing staff names</param>
        /// <param name="surname">Initializing staff surnames</param>
        /// <param name="patronymic">Initializing staff patronymics</param>
        /// <param name="birthday">Initializing staff dates of birth</param>
        /// <param name="position">Initializing staff positions</param>
        /// <param name="salary">Initializing staff salary</param>
        public Staff(int number, string name, string surname, string patronymic, DateTime birthday, string position, double salary)
        {
            this.Number = number; this.Name = name; this.Surname = surname; this.Patronymic = patronymic; this.Birthday = birthday; this.Position = position; this.Salary = salary;
        }
        /// <summary>
        /// Output informations about staff
        /// </summary>
        public void Output()
        {
            WriteLine($"Number: {Number}\nName: {Name}\nSurname: {Surname}\nPatronymic: {Patronymic}\nDate of birth: {Birthday}\nPosition: {Position}\nSalary: {Salary}");
        }
        public DateTime Age()
        {
            return DateTime.Today.AddYears(-Birthday.Year);
        }









    }
}
