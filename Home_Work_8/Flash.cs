using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_8
{
    public class Flash : Storage
    {
        private const int USB_SPEED_THREE_ZERO = 5000;

        public int FlashMemory { get; set; }

        public int UserCountFlash { get; set; }


        public override void GetMemoryCapacity()
        {
            Console.WriteLine($"Объем Flash носителя - {FlashMemory} мегабайт");

            Console.WriteLine($"Объем всех Flash носителей - {(UserCountFlash * FlashMemory)} мегабайт");
        }

        public override void FreeMemoryCapacity()
        {
            Console.WriteLine($"Свободный объем Flash носителя после передачи одного файла размером {FileSize} мегабайт - {FlashMemory - FileSize} мегабайт");
        }

        public override void CopyInformation()
        {
            if (UserCountFlash < (Memory / FlashMemory))
            {
                Console.WriteLine($"Вам не хватает - {(Memory / FlashMemory) - UserCountFlash}, размером {FlashMemory} мегабайт Flash носителей для переноски данных!");

                Console.WriteLine($"Требуется - {(Memory / FlashMemory)} Flash носителей!");

                Console.WriteLine($"Копирование файлов невозможно!");
            }
            else
            {
                Console.WriteLine($"Копирование файлов будет проходить: {Memory / USB_SPEED_THREE_ZERO} секунд");

                Console.WriteLine($"Остаток памяти на всех носителях после передачи файлов равно {(UserCountFlash * FlashMemory) - Memory} мегабайт");
            }
        }

        public override void FullInformation()
        {
            Console.WriteLine($"Название Flash устройства - {Name}");

            Console.WriteLine($"Модель Flash устройства - {Model}");

            Console.WriteLine($"Скорость записи USB 3.0 равно - {USB_SPEED_THREE_ZERO} мб/с");

            Console.WriteLine($"Объем носителя Flash устройства: {FlashMemory} мегабайт");
        }
    }
}
