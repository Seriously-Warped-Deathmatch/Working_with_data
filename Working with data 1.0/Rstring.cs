using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace Working_with_data
{
    internal class Rstring
    {
        Error_and_end error = new Error_and_end();

        private string _string;
        private int comand;

        public string _String
        {
            get { return _string; }
            set { _string = value; }
        }
        public int Comand
        {
            get { return comand; }
            set 
            {
                if (value > 0 && value < 8)
                {
                    comand = value;
                }
                else
                {
                    error.Error = 2;
                    error.End();
                }
            }
        }

        public void stringRead()
        {
            while (true)
            {
                Console.WriteLine("Введите строку для работы.");
                _string = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(_string))
                {
                    error.Error = 3;
                    error.End();
                }
                else
                {
                    break;
                }
            }
        }

        public void stringComand() 
        {
            while (true)
            {
                string text = Console.ReadLine();
                if (!int.TryParse(text, out comand))
                {
                    error.Error = 1;
                    error.End();
                }
                else if (comand < 7 || comand > 0)
                {
                    error.Error = 2;
                    error.End();
                }
                else 
                {
                    break;
                }
            }
        }

        public void stringDeistvie() 
        {
            Console.WriteLine($"Строка:{_string}");
            switch (comand)
            {

                case 1:
                    stringDeistvie1(ref _string);
                    break;
                case 2:
                    stringDeistvie2(ref _string);
                    break;
                case 3:
                    stringDeistvie3(ref _string);
                    break;
                case 4:
                    stringDeistvie4(ref _string);
                    break;
                case 5:
                    stringDeistvie5(ref _string);
                    break;
                case 6:
                    stringDeistvie6(ref _string);
                    break;
                case 7:
                    stringDeistvie7(ref _string);
                    break;
            }
            error.reboot();
        }

        public void stringDeistvie1(ref string _string)
        {
            _string = _string.ToLower();
            Console.WriteLine(_string);
        }

        public void stringDeistvie2(ref string _string)
        {
            _string = _string.ToUpper();
            Console.WriteLine(_string);
        }

        public void stringDeistvie3(ref string _string)
        {
            string[] arr_text = _string.Split(' ');
            _string = "";
            for (int i = 0; i < arr_text.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(arr_text[i]))
                {
                    _string = _string + arr_text[i] + " ";
                }
            }
            Console.WriteLine(_string);
        }

        public void stringDeistvie4(ref string _string)
        {
            string[] arr_text4 = _string.Split(' ');
            string[] arr_char = arr_text4[0].Split();
            _string = "";
            for (int i = 0; i < arr_text4.Length; i++)
            {
                if (i == 0)
                {
                    int size = arr_text4[0].Length - 1;
                    string text2 = arr_text4[0].Substring(0, 1);
                    _string = text2.ToUpper();
                    string text3 = arr_text4[0].Substring(1, size);
                    _string = _string + text3.ToLower();
                    _string = _string + " ";
                }
                else
                {
                    _string = _string + arr_text4[i].ToLower();
                    _string = _string + " ";
                }
            }
            Console.WriteLine(_string);
        }

        public void stringDeistvie5(ref string _string)
        {
            Console.WriteLine($"Длина строки: {_string.Length}");

            Console.WriteLine("Введите число позиции куда вставить");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                error.Error = 1;
                error.End();
            }
            else
            {

                if (number < 0 || number > _string.Length)
                {
                    error.Error = 4;
                    error.End();
                }
                else
                {

                    Console.WriteLine("Введите, что хотите вставить");
                    string text4 = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(text4))
                    {
                        error.Error = 3;
                        error.End();
                    }
                    else
                    {

                        _string = _string.Insert(number - 1, text4);
                        _string = _string.Insert(number - 1, " ");

                        Console.WriteLine(_string);
                    }
                }
            }
        }

        public void stringDeistvie6(ref string _string)
        {
            Console.WriteLine($"Длина строки: {_string.Length}");

            Console.WriteLine("Введите число позиции откуда начать удалять");
            if (!int.TryParse(Console.ReadLine(), out int number2))
            {
                error.Error = 1;
                error.End();
            }
            else
            {

                if (number2 < 0 || number2 > _string.Length)
                {
                    error.Error = 4;
                    error.End();
                }
                else
                {

                    Console.WriteLine("Введите количество символов, которые надо удалить");
                    if (!int.TryParse(Console.ReadLine(), out int number3))
                    {
                        error.Error = 1;
                        error.End();
                    }
                    else
                    {

                        if (number2 < 0)
                        {
                            error.Error = 5;
                            error.End();
                        }
                        else
                        {

                            _string = _string.Remove(number2, number3);
                            Console.WriteLine(_string);
                        }
                    }
                }
            }
        }
        public void stringDeistvie7(ref string _string)
        {
            Console.WriteLine("Введите, что хотите заменить");
            string text5 = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(text5))
            {
                error.Error = 3;
                error.End();
            }
            else
            {


                Console.WriteLine("Введите, что на хотите заменить");
                string text6 = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(text6))
                {
                    error.Error = 3;
                    error.End();
                }
                else
                {

                    _string = _string.Replace(text5, text6);
                    Console.WriteLine(_string);
                }
            }
        }


    }
}
