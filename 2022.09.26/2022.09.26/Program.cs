using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022._09._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hány éves vagy? : ");
            int eletkor = Convert.ToInt32(Console.ReadLine());
            switch (eletkor)
            {
                case int kor when (kor >= 0 && kor < 7):
                    Console.WriteLine("Baba");
                    break;

                case int kor when (kor >= 0 && kor < 7):
                    Console.WriteLine("gyerek");
                    break;
                case int kor when (kor >= 7 && kor < 19):
                    Console.WriteLine("Fiatal felnött");
                    break;
                case int kor when (kor >= 19 && kor < 65):
                    Console.WriteLine("felnőtt");
                    break;
                case int kor when (kor >= 65 && kor < 120):
                    Console.WriteLine("nyugdíjas");
                    break;
                    default:
                    Console.WriteLine("Nem jó számot adtál meg");
                    break ;

            }
            Console.ReadLine();
        }
    }
}
