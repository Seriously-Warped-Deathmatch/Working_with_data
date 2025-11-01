using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_data
{
    internal class Error_and_end
    {
        

        private int error;

        public int Error
        {
            get { return error; }
            set { error = value; }
        }

        public void reboot()
        {
            Console.WriteLine();
            Console.WriteLine("Нажмите на любую кнопку, чтобы перезапустить программу.");
            Console.ReadKey();
            Console.Clear();
        }

        public void End()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            if (error == 1)
            {
                Console.WriteLine("Ошибка: некоректный ввод!");
            }
            else if (error == 2)
            {
                Console.WriteLine("Ошибка: нет такой команды или команда недоступна!");
            }
            else if (error == 3) 
            {
                Console.WriteLine("Ошибка: строка пустая или null!");
            }
            else if (error == 4)
            {
                Console.WriteLine("Ошибка: неверно указана позиция!");
            }
            else if (error == 5)
            {
                Console.WriteLine("Ошибка: количество удаляемых символов не может быть отрицательным!");
            }
            Console.ResetColor();
        }
    }
}
