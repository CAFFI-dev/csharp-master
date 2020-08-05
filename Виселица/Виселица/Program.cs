using System;
using System.Threading;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using Виселица.Properties;
using System.IO;
using System.Collections.Generic;

namespace Виселица
{
    class Program
    {
        private static StreamReader sr = (StreamReader)Resources.ResourceManager.GetObject("WordList");
        public static int mistake = 0;//Сколько ошибок было сделано
        public static string word;
        public static char[] chars;
        public static char[] possibleChars;
        public static bool goodAttempt; //Хороша ли попытка, иль нет?
        /// <summary>
        /// Создает массивы, в которых слова
        /// </summary>
        public static void CreateArrays()
        {
            string iner = sr.ReadLine();
            int stop = 0;
            while (stop == 0) 
            {
                if (iner.Contains(':'))
                {
                    stop++;
                }
                else sr.ReadLine();
            }
            while(stop == 1)
            {
                List<string>  = new List<string>();
            }
        }
        /// <summary>
        /// Главная функция программы
        /// </summary>
        /// <param name="args">Аргументы для запуска</param>
        static void Main(string[] args)
        {
            CreateArrays();
            bool exitTheGame = false; //переменная, отвечающая за выход 
            while (exitTheGame == false)
            {
                Console.Clear();
                Console.Title = "Виселица. v 0.21";
                Console.WriteLine("Привет! Добро пожаловать в виселицу!");
                Console.WriteLine("Что ты хочешь сделать?");
                //меню выборов
                Console.WriteLine("1) Начать игру");
                Console.WriteLine("2) Как играть");
                Console.WriteLine("q) Выход");
                Console.Write("Ваш выбор: ");
                char choice = Console.ReadKey().KeyChar;
                if(choice == '1')
                {
                    StartingUpTheGame(chars);
                }
                else if(choice == '2')
                {
                    //TODO
                }
                else if(choice == 'q' || choice == 'Q')
                {
                    exitTheGame = true;
                }
            }
        }
        /// <summary>
        /// Функция для ввода данных пользователем какое слово он хочет выбрать
        /// </summary>
        public static void StartingUpTheGame(char[] chars)
        {
            mistake = 0;
            bool startAgain = true; // начинать ли заново?
            //TODO: Presets
            while (startAgain == true)
            {
                Console.WriteLine();
                Console.WriteLine("Что вы хотите сделать: ");
                Console.Write("Введите слово: ");
                word = Console.ReadLine();
                if (word.Length >= 5 && word.Length <= 12) //проверка длины слова
                {
                    word.ToUpper();
                    chars = new char[word.Length];
                    for (int i = 0; i < chars.Length; i++) //заполняем массив загадочными буквами
                    {
                        chars[i] = '_';
                    }
                    TheGame(chars);

                }
                else Console.WriteLine("Введенное слово меньше 5 букв, или больше 12!");

                //строчки по перезапуску
                Console.Write("Хотите ли вы начать заново? \n Y/N: ");
                if(Console.ReadKey().KeyChar == 'Y' || Console.ReadKey().KeyChar == 'y')
                {
                    //перезапуск
                    Console.WriteLine();
                    Console.WriteLine("Перезапускаю...");
                    Thread.Sleep(1000);
                }
                else if(Console.ReadKey().KeyChar == 'N' || Console.ReadKey().KeyChar == 'n')
                {
                    Console.WriteLine();
                    Console.WriteLine("Возвращаю в главное меню...");
                    startAgain = false;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Введена некорректная буква! Возвращаю в главное меню.....");
                    startAgain = false;
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Главная функция с игрой
        /// </summary>
        public static void TheGame(char[] chars)
        {
            bool win = false;
            while (mistake < 6 && win == false)
            {
                Console.Clear();
                Console.WriteLine("Вам нужно отгадать это слово: ");
                for (int i = 0; i < chars.Length; i++) //Показ слова
                {
                    Console.Write(chars[i] + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("Попытка: {0}, осталось попыток: {1} ", mistake + 1, 6 - mistake);
                Console.Write("Буква: ");
                char bykva = Console.ReadKey().KeyChar;
                System.Char.ToUpper(bykva);
                Console.WriteLine();
                chars = OpenTheLetters(chars, bykva);
                if(goodAttempt == false)
                {
                    mistake++;
                }
                for (int i = 0; i<chars.Length; i++)
                {
                    if(chars[i] == '_')
                    {
                        win = false;
                        break;
                    }
                    win = true;
                }
            }
            if(win == false)
            {
                Console.WriteLine("Вы проиграли! Загаданным словом было {0}!", word);
            }
            else
            {
                Console.WriteLine("Вы выиграли! Загаданным словом было {0}!", word);
            }
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Функция, отображающая ситуацию с виселицей
        /// </summary>
        public static void CurrentSituation()
        {
            //TODO
        }
        /// <summary>
        /// Функция, раскрывающая буковы слова, если букова была угадана
        /// </summary>
        /// <returns>возвращает функцию</returns>
        public static char[] OpenTheLetters(char[] chars, char bykva)
        {
            if (word.Contains(bykva))
            {
                goodAttempt = true;
                char[] wordChar = word.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if(wordChar[i] == bykva)
                    {
                        chars[i] = wordChar[i];
                    }
                }
            }
            else
            {
                goodAttempt = false;
            }
            return chars;
        }
    }
}
