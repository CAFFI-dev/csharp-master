using System;
using System.Linq;

namespace VowelsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, e = 0, i = 0, o = 0, u = 0; //буква y - не считается гласной
            int aa = 0, ao = 0, ay = 0, au = 0, ae = 0, aee = 0, aya = 0, aye = 0, ayu = 0, aie = 0; // русские буквы
            int counter = 0; //В общем о буквах
            Console.WriteLine("Эта короткая программа считает, сколько гласных находится в тексте!");
            Console.Write("Введите текст: ");
            string s = Console.ReadLine();
            char[] lol = s.ToArray(); //лделаем из строки массив для удобства
            for(int iss=0;iss<lol.Length; iss++)
            {
                switch (lol[iss]) //перебор значений
                {
                    case 'A': //английская буква a
                    case 'a':
                        counter++;
                        a++;
                        break;
                    case 'e': //английская буква e
                    case 'E': 
                        counter++;
                        e++;
                        break;
                    case 'i': //английская буква i
                    case 'I': 
                        counter++;
                        i++;
                        break;
                    case 'o': //английская буква o
                    case 'O':
                        counter++;
                        o++;
                        break;
                    case 'u': //английская буква u
                    case 'U':
                        counter++;
                        u++;
                        break;

                    //русские буквы

                    case 'А': //русская буква a
                    case 'а':
                        counter++;
                        aa++;
                        break;
                    case 'О': //русская буква о
                    case 'о':
                        counter++;
                        ao++;
                        break;
                    case 'У': //русская буква у
                    case 'у':
                        counter++;
                        ay++;
                        break;
                    case 'Ы': //русская буква ы
                    case 'ы':
                        counter++;
                        au++;
                        break;
                    case 'Я': //русская буква я
                    case 'я':
                        counter++;
                        aya++;
                        break;
                    case 'Ё': //русская буква ё
                    case 'ё':
                        counter++;
                        aye++;
                        break;
                    case 'Э': //русская буква э
                    case 'э':
                        counter++;
                        ae++;
                        break;
                    case 'Ю': //русская буква ю
                    case 'ю':
                        counter++;
                        ayu++;
                        break;
                    case 'И': //русская буква и
                    case 'и':
                        counter++;
                        aie++;
                        break;
                    case 'Е': //русская буква е
                    case 'е':
                        counter++;
                        aee++;
                        break;
                    default:
                        break;
                }
                
            }
            Console.Write("В этой строке {0} гласных", counter);
            if (counter > 0)
            {
                Console.WriteLine(", из которых: ");
            }
            if (a > 0)
            {
                Console.WriteLine("{0} - английских a;", a);
            }
            if (e > 0)
            {
                Console.WriteLine("{0} - английских e;", e);
            }
            if (i > 0)
            {
                Console.WriteLine("{0} - английских i;", i);
            }
            if (o > 0)
            {
                Console.WriteLine("{0} - английских o;", o);
            }
            if (u > 0)
            {
                Console.WriteLine("{0} - английских u;", u);
            }

            if (aa > 0)
            {
                Console.WriteLine("{0} - русских a;", aa);
            }
            if (ao > 0)
            {
                Console.WriteLine("{0} - русских o;", ao);
            }
            if (ay > 0)
            {
                Console.WriteLine("{0} - русских у;", ay);
            }
            if (au > 0)
            {
                Console.WriteLine("{0} - русских ы;", au);
            }
            if (aya > 0)
            {
                Console.WriteLine("{0} - русских я;", aya);
            }
            if (aye > 0)
            {
                Console.WriteLine("{0} - русских ё;", aye);
            }
            if (ae > 0)
            {
                Console.WriteLine("{0} - русских э;", ae);
            }
            if (ayu > 0)
            {
                Console.WriteLine("{0} - русских ю;", ayu);
            }
            if (aie > 0)
            {
                Console.WriteLine("{0} - русских e;", aie);
            }
            if (aee > 0)
            {
                Console.WriteLine("{0} - русских и;", aee);
            }
        }
    }
}
