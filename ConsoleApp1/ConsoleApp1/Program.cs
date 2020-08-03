using System;
namespace ConsoleApp1
{
    class Program
    {
        static Random rnd = new Random(); //инициализация рандома
        private static int difficulty = 0, gold = 500;
        private static bool firstTurn, secret = false;
        private static char[,] crosses = new char[3, 3];
        public static int mas1, mas2;
        public static string name1, name2;
        public static int code = 0;
        public static void OutCrossSituation() //отображение массива
        {
            Console.Clear();
            Console.WriteLine("   A B C");
            Console.WriteLine("");
            Console.Write("1 ");
            Console.WriteLine(" " + crosses[0, 0] + "|" + crosses[0, 1] + "|" + crosses[0, 2]);
            Console.WriteLine("   -----");
            Console.Write("2 ");
            Console.WriteLine(" " + crosses[1, 0] + "|" + crosses[1, 1] + "|" + crosses[1, 2]);
            Console.WriteLine("   -----");
            Console.Write("3 ");
            Console.WriteLine(" " + crosses[2, 0] + "|" + crosses[2, 1] + "|" + crosses[2, 2]);
            Console.WriteLine();
        }
        public static int OutCrossSituation(string hod, int amountHod) //запись хода игрока путем перегрузки
        {
            bool mistake = false;
            try
            {
                int mas1 = 4, mas2 = 4;
                if (hod.Contains("A"))
                {
                    mas2 = 0;
                }
                else if (hod.Contains("B"))
                {
                    mas2 = 1;
                }
                else if (hod.Contains("C"))
                {
                    mas2 = 2;
                }
                else mistake = true;
                if (hod.Contains("1"))
                {
                    mas1 = 0;
                }
                else if (hod.Contains("2"))
                {
                    mas1 = 1;
                }
                else if (hod.Contains("3"))
                {
                    mas1 = 2;
                }
                else mistake = true;
                if (mistake != true)
                {
                    if (amountHod % 2 == 0)
                    {
                        crosses[mas1, mas2] = 'X';
                    }
                    else crosses[mas1, mas2] = 'O';
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка! " + e.Message);
            }
            OutCrossSituation();
            if (mistake == true)
            {
                return -1;
            }
            return +0;
        }
        public static void Introduction()
        {
            //Сбрасывание значения массива
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    crosses[i, j] = ' ';
                }
            }

            if (false)
            {
                Console.WriteLine("Выберите за кого вы будете ходить: X или O");
            }
            if (true)
            {
                Console.Title += "Дружеский матч. ";
                Console.Write("Игрок 1, напиши свое имя: ");
                name1 = Console.ReadLine();
                Console.Write("Игрок 2, напиши свое имя: ");
                name2 = Console.ReadLine();
                Console.WriteLine("Кто будет ходить первым? (имя игрока, или random)");
                while (true) //Чтобы не вылетело с этого меню
                {
                    try
                    {
                        Console.Write("Ваш выбор: ");
                        string choice = Console.ReadLine();
                        if (choice == name1)
                        {
                            firstTurn = true;
                            return;
                        }
                        else if (choice == name2)
                        {
                            firstTurn = false;
                            return;
                        }
                        else if (choice == "random")
                        {
                            Console.WriteLine("Итак....");
                            System.Threading.Thread.Sleep(2000);
                            int random = rnd.Next(0, 2);
                            Console.Write("Первым будет ходить ");
                            if (random == 0)
                            {
                                firstTurn = true;
                                Console.WriteLine(name1 + "!");
                            }
                            else
                            {
                                firstTurn = false;
                                Console.WriteLine(name2 + "!");
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Введено некорректное значение! ");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Ошибка! " + e.Message);
                    }
                }
            }
        }
        public static void TheGame() //основная функция игры
        {
            Introduction();
            Console.Clear();
            Console.WriteLine("Игра началась!");
            System.Threading.Thread.Sleep(1000);
            OutCrossSituation();
            if (false)
            {
                Console.WriteLine("Сейчас ваш ход!");
            }
            int amountHod = 0;
            int winningSide = 0;
            while (amountHod < 9 && winningSide == 0)
            {
                if (firstTurn)
                {
                    if (amountHod % 2 == 0)
                    {
                        Console.WriteLine("Сейчас ходит " + name1 + "!");
                    }
                    else Console.WriteLine("Сейчас ходит " + name2 + "!");
                }
                else
                {
                    if (amountHod % 2 == 0)
                    {
                        Console.WriteLine("Сейчас ходит " + name2 + "!");
                    }
                    else Console.WriteLine("Сейчас ходит " + name1 + "!");
                }
                Console.Write("Ваш ход: ");
                string hod = Console.ReadLine();
                amountHod = OutCrossSituation(hod, amountHod);
                winningSide = checkTheVictory(winningSide);
                amountHod++;
            }
            if (winningSide == 0)
            {
                Console.WriteLine("Игра окончена! Победила дружба! ");
            }
            else if (winningSide == 1)
            {
                if (firstTurn)
                    Console.WriteLine("Игра окончена! Победил " + name1 + "!");
                else Console.WriteLine("Игра окончена! Победил " + name2 + "!");
            }
            else if (winningSide == 2)
            {
                if (firstTurn) Console.WriteLine("Игра окончена! Победил " + name2 + "!");
                else Console.WriteLine("Игра окончена! Победил " + name1 + "!");
            }
            else
            {
                Console.WriteLine("Ты пидор! Хули код ломаешь?");
            }
            int randomGold = 0;
            randomGold = rnd.Next(1, 6);
            gold += randomGold;
            Console.WriteLine("+" + randomGold + " G");
            Console.WriteLine("Нажмите любую клавишу для продолжения....");
            Console.ReadKey();
        }
        public static int checkTheVictory(int winningSide)
        {
            //по вертикали и по горизонтали
            for (int i = 0; i < 3; i++) {
                if (crosses[0, i] == crosses[1, i])
                {
                    if (crosses[1, i] == crosses[2, i])
                    {
                        if (crosses[2, i] == 'X')
                        {
                            return 1;
                        }
                        else if (crosses[2, i] == 'O')
                        {
                            return 2;
                        }    
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (crosses[i, 0] == crosses[i, 1])
                {
                    if (crosses[i, 1] == crosses[i, 2])
                    {
                        if (crosses[i, 2] == 'X')
                        {
                            return 1;
                        }
                        else if (crosses[i, 2] == 'O')
                        {
                            return 2;
                        }
                    }
                }
            }

            //победы не будет, извините
            return 0;
        }
        static void Main(string[] args) //Что-то типа главного меню
        {
            //Введение
            while (true) {
                Console.Clear();
                Console.Title = "Крестики-нолики v 0.7 by SCAPIFOL. ";
                if(code != 0)
                {
                    Console.Title += "Код от сейфа: " + code + ". ";
                }
                Console.WriteLine("Добро пожаловать в крестики-нолики!");
                Console.WriteLine("Выберите сложность: 1 2 3 не доработаны");
                Console.WriteLine("1) Легкая");//
                Console.WriteLine("2) Средняя");//
                Console.WriteLine("3) Сложная");//
                Console.WriteLine("4) Поиграть с другом");
                Console.WriteLine("m) Магазин");
                if(secret == true)
                {
                    Console.WriteLine("s) Сейф");
                }
                Console.WriteLine("h) Обучение");
                Console.WriteLine("q) Выход из программы");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();
                difficulty = 0;
                if(choice == "4")
                {
                    //Команда для очищения командной строки
                    Console.Clear();
                    TheGame();
                }
                if (choice == "m")
                {
                    bool exitM = false;
                    while (exitM != true)
                    {
                        Console.Clear();
                        Console.WriteLine("У вас " + gold + " G.");
                        Console.WriteLine("1) Открыть калькулятор. 1 - 2G");
                        Console.WriteLine("2) Офнуть игру. 100G");
                        Console.WriteLine("3) Вызвать BSoD. 200G");
                        Console.WriteLine("4) Расскажу секрет. 500G");
                        Console.WriteLine("q) Выйти из магазина");
                        Console.Write("Ваш выбор: ");
                        string choiceM = Console.ReadLine();
                        if (choiceM == "1")
                        {
                            Console.WriteLine("Сколько Вы хотите открыть калькуляторов?");
                            int amount = Int32.Parse(Console.ReadLine());
                            if (gold < amount * 2)
                            {
                                Console.WriteLine("Эй, черт! иди копи еще на калькуляторы!!!");
                            }
                            else
                            {
                                Console.WriteLine("Ок, рабы всегда открывают калькулятор...");
                                for (int i = 0; i < amount; i++)
                                {
                                    System.Diagnostics.Process.Start("calc.exe");
                                }
                                gold -= 2 * amount;
                            }
                            Console.ReadKey();
                        }
                        else if (choiceM == "2")
                        {
                            if (gold >= 100) { 
                            Console.WriteLine("Только ты собираешься протянуть деньги продавцу....");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Но тут выбегает вор со зловещим смехом, забирает их, и ржа, убегает!!");
                            System.Threading.Thread.Sleep(600);
                            Console.WriteLine("Ты собираешься бежать за ним...");
                            System.Threading.Thread.Sleep(600);
                                if (rnd.Next(0, 2) == 0)
                                {
                                    Console.WriteLine("Но вдруг подскальзываешься на полу, и ломаешь себе хребет!");
                                    System.Threading.Thread.Sleep(600);
                                    Console.WriteLine("-" + gold / 2 + " G");
                                    gold /= 2;
                                }
                                else
                                {
                                    Console.WriteLine("Ты нагоняешь его, пиздишь его по его головке,");
                                    System.Threading.Thread.Sleep(600);
                                    Console.WriteLine("и возвращаешь свою украденную половину денег!");
                                    System.Threading.Thread.Sleep(600);
                                    Console.WriteLine("+" + gold / 2 + " G");
                                    if (rnd.Next(0, 4) == 0)
                                    {
                                        Console.WriteLine("Также в потайном кармашке ты у него находишь ключ (на котором");
                                        Console.WriteLine("написаны три каких то цифры: , и 50G");
                                        Console.WriteLine("+50 G");
                                        System.Threading.Thread.Sleep(600);
                                        bool normalCode = false;
                                        while (normalCode != true)
                                        {
                                            code = rnd.Next(100, 1000);
                                            if (code != 666 && code != 999)
                                            {
                                                normalCode = true;
                                            }
                                        }
                                        Console.WriteLine("+ код: " + code);
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Тебе нужно больше голды!");
                            }
                            Console.ReadKey();
                        }
                        else if (choiceM == "3")
                        {
                            Console.WriteLine("BSoD'a нет, расходимся....");
                            Console.ReadKey();
                        }
                        else if (choiceM == "4")
                        {
                            if (gold >= 500)
                            {
                                Console.WriteLine("Псссс....");
                                Console.WriteLine("Подойди сюда... Расскажу тебе секрет");
                                System.Threading.Thread.Sleep(600);
                                Console.WriteLine("Если нажмешь s в меню, то найдешь нечто невообразимое!");
                                Console.WriteLine("Не бойся, мне твои деньги не к чему, иожешь себе их оставить!");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно денег!");
                            }
                            Console.ReadKey();
                        }
                        else if (choiceM == "q")
                        {
                            Console.Write("Закрываю...");
                            System.Threading.Thread.Sleep(200);
                            exitM = true;
                        }
                    }
                }
                else if (choice == "s")
                {
                    bool safeQ = false;
                    secret = true;
                    Console.Clear();
                    Console.WriteLine("ОГО! Что это? Неужели это сейф? Хотелось бы знать от него пароль!");
                    Console.ReadKey();
                    Console.WriteLine("Тааааак, мне необходимо узнать 3 цифры.");
                    Console.ReadKey();
                    Console.WriteLine("Чтобы это могло быть?");
                    Console.ReadKey();
                    while (safeQ != true)
                    {
                        Console.WriteLine("q - отойти от сейфа");
                        Console.Write("Введите код: ");
                        string cod = Console.ReadLine();
                        if (cod == "666")
                        {
                            Console.Clear();
                            Console.WriteLine("Ну все пиздец тебе настал......");
                            System.Threading.Thread.Sleep(2000);
                            Console.WriteLine("Молись богу чтобы я тебя не отхуярил....");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Бог подбрасывает монетку...");
                            System.Threading.Thread.Sleep(2000);
                            if (rnd.Next(0, 2) == 0)
                            {
                                Console.WriteLine("и выпадает жизнь!");
                                Console.WriteLine("Бог: Никому не рассказывай что здесь было, хорошо?");
                                Console.WriteLine("Ты меня понял гнида?");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("и выпадает смерть!");
                                Console.WriteLine("Познай ярость моих калькуляторов!!!!!");
                                Console.ReadKey();
                                for (int i = 0; i < 100; i++)
                                {
                                    System.Diagnostics.Process.Start("calc.exe");
                                }
                            }
                        }
                        else if (cod == code.ToString() && code != 0)
                        {
                            Console.WriteLine("Поздравляю ты прошел игру! Уже почти час ночи, и я замучался дописывать эту игру");
                            Console.ReadKey();
                            Console.WriteLine("Желаю тебе удачи во всех твоих начинаниях! Кстати, если что тут есть еще один код, найди его!");
                            Console.ReadKey();
                            safeQ = true;
                        }
                        else if (cod == "q")
                        {
                            safeQ = true;
                        }
                        else
                        {
                            Console.WriteLine("Некорректный код!");
                        }
                    }
                    if (choice == "h") //Обучение
                    {
                        Console.WriteLine("Нууу, тут ничего сложного.");
                        Console.WriteLine("Ты можешь поиграть с ботами разного уровня сложности,");
                        Console.WriteLine("Либо же поиграть со своим другом,");
                        Console.WriteLine("выбрав кто будет ходить самим или же путем рандома!");
                        Console.WriteLine("Ход в этой игре осуществляется как в шахматах т.е A1, B1 (1A, 1B тоже канают)");
                        Console.WriteLine("Удачи тебе и приятной игры!");
                        Console.WriteLine("Нажмите любую клавишу для продолжения....");
                        Console.ReadKey();
                    }
                    if (choice == "q")
                    {
                        //выход из программы
                        System.Diagnostics.Process.GetCurrentProcess().Close();
                    }
                }
            }
        }
    }
}
