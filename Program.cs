using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public static class Program
    {
        static void Main(string[] args)

        {
            while (true)
            {



                Console.WriteLine("Какую программу использовать перевод нот, калькулятор или нахождение силы тяжести?");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "перевод нот":

                    case "перевод":
                    case "1":
                    case "быстро запусти первую программу":
                    case "ноты":
                        Console.WriteLine("Запущена программа перевод нот");
                        Console.WriteLine("______");

                        string F;

                        string[] nota = new string[7];

                        nota[0] = "До";
                        nota[1] = "Ре";
                        nota[2] = "Ми";
                        nota[3] = "Фа";
                        nota[4] = "Соль";
                        nota[5] = "Ля";
                        nota[6] = "Си";

                        Console.WriteLine("Введите ноту в скрепичном ключе");
                        F = Console.ReadLine();
                        int Index = -1;
                        for (int i = 0; i < 7; i++)
                        {

                            if (nota[i] == F)

                            {

                                Index = i + 2;

                                if (Index > 6) Index = Index - 7;

                            }

                        }
                        Console.WriteLine("-------------------------");
                        if (Index == -1) Console.WriteLine("Нота не найдена");

                        else
                            Console.WriteLine("Нота в басовом ключе");
                        Console.WriteLine(nota[Index]);
                        break;
                    case "калькулятор":
                    case "2":
                        double a;
                        double b;
                        double res = 0;
                        char oper;
                        Console.WriteLine("Запущена программа калькулятор");

                        Console.WriteLine("______");

                        Console.Write("Введите первое число:");
                        a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("\nВведите знак:");
                        oper = Convert.ToChar(Console.ReadLine());

                        Console.Write("\nВведите второе число:");
                        b = Convert.ToDouble(Console.ReadLine());

                        if (oper == '+')
                        {
                            res = a + b;
                        }

                        else if (oper == '-')
                        {
                            res = a - b;
                        }

                        else if (oper == '*')
                        {
                            res = a * b;
                        }

                        else if (oper == '/')
                        {
                            if (b != 0)
                                res = a / b;
                            else Console.WriteLine("На 0 делить нельзя");
                        }
                        else
                        {
                            Console.WriteLine("Неизвестный знак");
                        }

                        Console.WriteLine("\nРезультат: {0}", res);
                        break;
                    case "сила тяжести":
                    case "3":
                        double g;
                        double hb = 10;
                        double rej = 0;


                        Console.Write("Введите массу:");
                        g = Convert.ToDouble(Console.ReadLine());

                        rej = g * hb;

                        Console.WriteLine("\nРезультат: {0}", rej);

                        break;
                        //case "генератор фанфиков": 
                        //case "4": 
                        ///case "генератор": 
                        //string GG; 
                        // string resK; 
                        //  string reHs; 

                        // string World; 
                        //  string WorldK; 
                        //  string Dead; 
                        //  string DeadA; 

                        //   World = "триллер"; 
                        //  resK = "первая"; 

                        //   Console.WriteLine("Напиши имя героя:"); 
                        //  GG = Console.ReadLine(); 
                        //  Console.WriteLine("Напиши жанр"); 
                        //WorldK = Console.ReadLine(); 


                        //  if (World == WorldK) 
                        {
                            ///    Console.WriteLine("\nВставая с кровати,{0}",GG,"да"); 

                            //   Console.Write("осмотрелся по сторонам,и увидел две двери, в какую дверь ему пойти?"); 
                        }
                        // Console.WriteLine("Выберете дверь"); 



                        //    reHs = Console.ReadLine(); 

                        // if (resK == reHs) 

                        //  { 



                        //  Console.WriteLine("\nВыбрана, {0}",reHs);
                        //  Console.WriteLine("За этой дверью стоял какой то стол,на котором была странная коробочка"); 






                        //break;



                    default:
                        Console.WriteLine("Такой программы нет");
                       break;
                        Console.WriteLine("______");
                }



                Console.WriteLine("Запустить еще раз? (y/n)");
                ConsoleKeyInfo c = Console.ReadKey();
                if (c.KeyChar == 'n') break;

            }

        }

    }
}