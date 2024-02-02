using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T16_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Enter number of staff: ");
                int n = Convert.ToInt32(ReadLine());
                WriteLine();
                Staff[] staff = new Staff[n];
                for (int i = 0; i < staff.Length; i++)
                {
                    Write("Enter staff number: ");
                    int num = Convert.ToInt32(ReadLine());
                    Write("Enter name: ");
                    string name = ReadLine();
                    Write("Enter surname: ");
                    string surname = ReadLine();
                    Write("Enter patronymic: ");
                    string patronymic = ReadLine();
                    Write("Enter date of birth (dd.MM.yyyy): ");
                    DateTime birthday = DateTime.Parse(ReadLine());
                    Write("Enter position: ");
                    string position = ReadLine();
                    Write("Enter salary: ");
                    double salary = Convert.ToDouble(ReadLine());
                    staff[i] = new Staff(num, name, surname, patronymic, birthday, position, salary);
                    WriteLine();
                }
                foreach(var elem in staff)
                {
                    elem.Output();
                    WriteLine($"Age: {elem.Age().ToString("yy")}");
                    WriteLine();
                }

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
