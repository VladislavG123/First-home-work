using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name\n");
            // Ввод имени.
            string name = Console.ReadLine(); 
            // Пока пользователь не выключит Caps Lock будет выводиться предупреждение
            // и выдаваться повторно ввод имени.
            while (Console.CapsLock)
            {
                // Вывод предупреждения о включенном Cups Lock.
                Console.WriteLine("\nTurn off CapsLock and try agane!\n");
                // Повторный ввод имени.
                name = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine("Enter your age\n");
            // Ввод возраста пользователя.
            int age = Convert.ToInt32(Console.ReadLine());
            // Пока пользователь не введет правильную информацию, программа  
            // будет запрашивать повторный ввод.
            while ((age < 0) || (age > 100))
            {
                // Предупреждение о неправильном вводе.
                Console.WriteLine("\nIncorrect age, enter again!\n");
                // Повторный ввод возраста.
                age = Convert.ToInt32(Console.ReadLine());
            }
            // Очистка экрана для вывода конечной информации.
            Console.Clear();
            // Вывод данных пользователя.
            Console.WriteLine($"You are {name} and you {age} years old\n\n");
            // Подсказка для выхода из программы.
            Console.WriteLine("To exit from the program, press any key");
            // Ожидание нажатия любой клавиши.
            Console.ReadLine();
        }
    }
}
