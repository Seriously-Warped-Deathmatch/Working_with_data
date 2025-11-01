using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Working_with_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comander comander = new Comander();
            Rstring rstring = new Rstring();


            comander.infoComand();
            comander.comandRead1();
            int comand = comander.infoComand2();

            switch (comand) 
            {
                case 1:
                    rstring.stringRead();
                    comander.Comand = 1;
                    while (true)
                    {
                        comander.infoComand();
                        rstring.stringComand();
                        rstring.stringDeistvie();
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break; 
            }


        }
    }
}
