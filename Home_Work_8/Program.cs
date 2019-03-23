using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            const int NULL = 0;
            const int ONE = 1;
            const int TWO = 2;
            const int THREE = 3;

            Storage[] storages = { new Flash(), new DVD(), new HDD() };

            Console.WriteLine("Общий объём данных - 565000 МБ");
            Console.WriteLine("Размер каждого файла - 780 МБ");

            int numberUser = CheckAndGetUserChoose();

            while (numberUser != THREE)
            {
                if (numberUser == NULL)
                {
                    Console.WriteLine("Укажите объем Flash памяти");
                    ((Flash)storages[NULL]).FlashMemory = int.Parse(Console.ReadLine());

                    Console.WriteLine("Укажите количество Flash носителей: ");
                    ((Flash)storages[NULL]).UserCountFlash = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите имя носителя: ");
                    ((Flash)storages[NULL]).Name = Console.ReadLine();

                    Console.WriteLine("Введите модель носителя: ");
                    ((Flash)storages[NULL]).Model = Console.ReadLine();
                    Console.Clear();

                    ((Flash)storages[NULL]).FullInformation();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((Flash)storages[NULL]).GetMemoryCapacity();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((Flash)storages[NULL]).CopyInformation();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((Flash)storages[NULL]).FreeMemoryCapacity();

                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                    Console.ReadKey();
                    Console.Clear();
                    numberUser = CheckAndGetUserChoose();
                    Console.Clear();
                }

                else if (numberUser == ONE)
                {
                    Console.WriteLine("Выберите тип DVD диска - ");
                    Console.WriteLine("0 - Односторонний - 4,7 ГБ");
                    Console.WriteLine("1 - Двухсторонний - 9,4 ГБ");

                    int typeDisk = int.Parse(Console.ReadLine());

                    if (typeDisk == 1)
                    {
                        ((DVD)storages[ONE]).UserTypeDisc = true;
                    }

                    else if (typeDisk == 0)
                    {
                        ((DVD)storages[ONE]).UserTypeDisc = false;
                    }

                    else
                    {
                        Console.WriteLine("По умолчанию выбран диск - двусторонний!");
                        ((DVD)storages[ONE]).UserTypeDisc = false;
                    }

                    Console.WriteLine("Введите количество DVD дисков: ");
                    ((DVD)storages[ONE]).UserCountDisc = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите имя носителя: ");
                    ((DVD)storages[ONE]).Name = Console.ReadLine();

                    Console.WriteLine("Введите модель носителя: ");
                    ((DVD)storages[ONE]).Model = Console.ReadLine();
                    Console.Clear();

                    ((DVD)storages[ONE]).FullInformation();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((DVD)storages[ONE]).GetMemoryCapacity();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((DVD)storages[ONE]).CopyInformation();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((DVD)storages[ONE]).FreeMemoryCapacity();

                    Console.WriteLine("Для продолжения нажмите любую клавишу");

                    Console.ReadKey();
                    Console.Clear();
                    numberUser = CheckAndGetUserChoose();
                    Console.Clear();
                }
                else if (numberUser == TWO)
                {
                    Console.WriteLine("Укажите количество разделов HDD: ");
                    ((HDD)storages[TWO]).CountSections = int.Parse(Console.ReadLine());

                    Console.WriteLine("Укажите объем раздела HDD: ");
                    ((HDD)storages[TWO]).VolumeSections = int.Parse(Console.ReadLine());

                    Console.WriteLine("Укажите количество HDD носителей: ");
                    ((HDD)storages[TWO]).UserCountHdd = int.Parse(Console.ReadLine());


                    Console.WriteLine("Введите имя носителя: ");
                    ((HDD)storages[TWO]).Name = Console.ReadLine();

                    Console.WriteLine("Введите модель носителя: ");
                    ((HDD)storages[TWO]).Model = Console.ReadLine();
                    Console.Clear();

                    ((HDD)storages[TWO]).FullInformation();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((HDD)storages[TWO]).GetMemoryCapacity();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((HDD)storages[TWO]).CopyInformation();
                    Console.WriteLine("------------------------------------------------------------------");

                    ((HDD)storages[TWO]).FreeMemoryCapacity();
                    Console.WriteLine("Для продолжения нажмите любую клавишу");
                    Console.ReadKey();
                    Console.Clear();
                    numberUser = CheckAndGetUserChoose();
                    Console.Clear();
                }
                
            }
        }

        public static int CheckAndGetUserChoose()
        {
            const int NULL = 0;
            const int ONE = 1;
            const int TWO = 2;
            const int THREE = 3;

            Console.WriteLine("Выберите носитель для передачи данных: ");
            Console.WriteLine($"{NULL} - Flash");
            Console.WriteLine($"{ONE} - DVD");
            Console.WriteLine($"{TWO} - HDD");
            Console.WriteLine($"{THREE} - Exit");
            int numberUser;

            try
            {
                numberUser = int.Parse(Console.ReadLine());
                if (numberUser < NULL || numberUser > THREE)
                {
                    throw new ArgumentException($"Такого варианта не существует!\nПо умолчанию будет выбран вариант: {ONE} - DVD");
                }
            }
            catch (FormatException exception)
            {
                Console.Clear();
                Console.WriteLine($"{exception.Message}\nПо умолчанию будет выбран вариант: {ONE} - DVD");
                numberUser = ONE;
            }
            catch (ArgumentException exception)
            {
                Console.Clear();
                Console.WriteLine(exception.Message);
                numberUser = ONE;
            }
            return numberUser;
        }
    }
}
