using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_8
{
    public class HDD : Storage
    {
        const int USB_SPEED_TWO_ZERO = 480;

        public int CountSections { get; set; }

        public int VolumeSections { get; set; }

        public int UserCountHdd { get; set; }

        public override void GetMemoryCapacity()
        {
            Console.WriteLine($"Объем одного носителя HDD: {VolumeSections * CountSections} мегабайт");

            Console.WriteLine($"Объем всех носителей HDD: {(VolumeSections * CountSections * UserCountHdd)} мегабайт");
        }

        public override void FreeMemoryCapacity()
        {
            Console.WriteLine($"Свободный объем памяти на носителях HDD  - {(VolumeSections * CountSections * UserCountHdd) - FileSize} мегабайт");
        }

        public override void CopyInformation()
        {

            if (UserCountHdd < (Memory / (VolumeSections * CountSections)))
            {
                Console.WriteLine($"Вам не хватает - {(Memory / (VolumeSections * CountSections)) - UserCountHdd}, размером - {(VolumeSections * CountSections)} мегабайт HDD носителей для переноски данных");

                Console.WriteLine($"Требуется - {(Memory / (VolumeSections * CountSections))} HDD носителей");

                Console.WriteLine($"Копирование файлов невозможно!");
            }

            else
            {
                Console.WriteLine($"Копирование файлов будет проходить: {Memory / USB_SPEED_TWO_ZERO} секунд");

                Console.WriteLine($"Остаток памяти на всех носителях после передачи файлов равно {(VolumeSections * CountSections * UserCountHdd) - Memory} мегабайт");
            }
        }

        public override void FullInformation()
        {
            Console.WriteLine($"Название съмного HDD - {Name}");

            Console.WriteLine($"Модель съемного HDD - {Model}");

            Console.WriteLine($"Скорость записи USB 2.0 равно - {USB_SPEED_TWO_ZERO} мб/с");

            Console.WriteLine($"Объем {Name} носителя HDD: {VolumeSections * CountSections} мегабайт");
        }
    }
}
