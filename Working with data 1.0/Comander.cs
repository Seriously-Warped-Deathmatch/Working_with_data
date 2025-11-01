using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Working_with_data
{
    internal class Comander
    {
        Error_and_end error = new Error_and_end();

        private int comand;

        public int Comand
        {
            get { return comand; }
            set 
            {
                if (value < 100 || value > 0)
                {
                    comand = value;
                }
            }
        }
        
        public void infoComand()
        {
            if (comand == 0)
            {
                Console.WriteLine("Выберите режим работы:\n 1-Со строками\n 2-Со целыми числами \n 3-С числами с плавающей точкой \n 4-С массивами");
            }
            else if (comand == 1)
            {
                Console.WriteLine("Доступные команды для строки:\n 1-Понизить регистр\n 2-Повысить регистр \n 3-Разбить строку на слова и убрать ненужные пробелы \n 4-Разбить строку на слова и повысить регистр первой буквы первого слова, а остальные понизить регистр \n 5-Вставить слово или строку \n 6-Удалить слово или букву \n 7-Заменить слово или букву");
            }

            Console.WriteLine();
            Console.WriteLine("Чтобы выбрать команду напишите цифру соотвествующую команде.");
        }
        
        public void comandRead1()
        { 
            string text = Console.ReadLine();
            if (!int.TryParse(text, out comand))
            {
                error.Error = 1;
                error.End();
            }
            else if (comand > 10 || comand < 1)
            {
                error.Error = 2;
                error.End();
            }
            else 
            {
                Console.Clear();
            }
        }

        public int infoComand2()
        {
            switch (comand) 
            {
                case 1:
                    return 1;
                    break;
                case 2:
                    return 2;
                    break;
                case 3:
                    return 3;
                    break;
                case 4:
                    return 4;
                    break;

            }
            return 0;
        }
    }
}
