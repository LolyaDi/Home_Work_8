using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_8
{
    public class DVD : Storage
    {
        private const double READ_AND_WRITE_SPEED = 1.3;

        private const int ONE_SIDED_DISC = 4700;

        private const int DOUBLE_SIDED_DISC = 9400;

        public int UserCountDisc { get; set; }

        public bool UserTypeDisc { get; set; }


        public override void FreeMemoryCapacity()
        {
            if (UserTypeDisc)
            {
                Console.WriteLine($"Выбран тип DVD диска одностороний {ONE_SIDED_DISC} МБ");

                Console.WriteLine($"Свободный объём памяти на одном DVD диске после передачи одного файла размером {FileSize} МБ: {ONE_SIDED_DISC - FileSize}");
            }
            else
            {
                Console.WriteLine($"Выбран тип DVD диска двухстороний {DOUBLE_SIDED_DISC} МБ");

                Console.WriteLine($"Свободный объём памяти на одном DVD диске после передачи одного файла размером {FileSize} МБ: {DOUBLE_SIDED_DISC - FileSize}");
            }
        }

        public override void GetMemoryCapacity()
        {
            if (UserTypeDisc)
            {
                Console.WriteLine("Выбран тип DVD диска одностороний");

                Console.WriteLine($"Объём памяти на одном DVD диске: {ONE_SIDED_DISC} МБ");

                Console.WriteLine($"Объём памяти на всех DVD дисках: {ONE_SIDED_DISC * UserCountDisc} МБ");
            }
            else
            {
                Console.WriteLine("Выбран тип DVD диска двухстороний");

                Console.WriteLine($"Объём памяти на одном DVD диске: {DOUBLE_SIDED_DISC} МБ");

                Console.WriteLine($"Объём памяти на всех DVD дисках: {DOUBLE_SIDED_DISC * UserCountDisc} МБ");
            }
        }

        public override void CopyInformation()
        {
            if (UserTypeDisc)
            {
                Console.WriteLine($"Выбран тип DVD диска одностороний");

                if (UserCountDisc < (Memory / ONE_SIDED_DISC))
                {
                    Console.WriteLine($"Количество DVD дисков для передачи данных должно быть равно: {(Memory / ONE_SIDED_DISC)}");

                    Console.WriteLine($"Вам не хватает {(Memory / ONE_SIDED_DISC) - UserCountDisc} DVD дисков!");

                    Console.WriteLine("Копирование файлов невозможо!");
                }
                else
                {
                    Console.WriteLine($"Копирование файлов будет проходить: {(Memory / READ_AND_WRITE_SPEED)} секунд");

                    Console.WriteLine("Копирование файлов закончено!");

                    Console.WriteLine($"Количество не затронутых DVD дисков равно: {UserCountDisc - (Memory / ONE_SIDED_DISC)}");
                }
            }
            else
            {
                Console.WriteLine($"Выбран тип DVD диска двухстороний");

                if (UserCountDisc < (Memory / DOUBLE_SIDED_DISC))
                {
                    Console.WriteLine($"Количество DVD дисков для передачи данных ддолжно быть равно: {(Memory / DOUBLE_SIDED_DISC)}");

                    Console.WriteLine($"Вам не хватает {(Memory / DOUBLE_SIDED_DISC) - UserCountDisc} DVD дисков!");

                    Console.WriteLine("Копирование файлов невозможо!");
                }
                else
                {
                    Console.WriteLine($"Копирование файлов будет проходить: {(Memory / READ_AND_WRITE_SPEED)} секунд");

                    Console.WriteLine("Копирование файлов закончено!");

                    Console.WriteLine($"Количество не затронутых DVD дисков равно: {UserCountDisc - (Memory / DOUBLE_SIDED_DISC)}");
                }
            }
        }

        public override void FullInformation()
        {
            Console.WriteLine($"Название DVD диска: {Name}");

            Console.WriteLine($"Модель DVD диска: {Model}");

            Console.WriteLine($"Скорость записи и чтения диска DVD равна: {READ_AND_WRITE_SPEED} МБ/С");

            if (UserTypeDisc)
            {
                Console.WriteLine($"Тип DVD диска одностороний - {ONE_SIDED_DISC} МБ");
            }
            else
            {
                Console.WriteLine($"Тип DVD диска двухстороний  - {DOUBLE_SIDED_DISC} МБ");
            }
        }
    }
}
