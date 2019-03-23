using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Home_Work_8
{
    public abstract class Storage
    {
        private const int SIZE_MEMORY = 565000;
        private const int FILE_SIZE = 780;

        public string Name { get; set; }

        public string Model { get; set; }

        public int Memory
        {
            get
            {
                return SIZE_MEMORY;
            }
        }

        public int FileSize
        {
            get
            {
                return FILE_SIZE;
            }
        }

        public abstract void GetMemoryCapacity();

        public abstract void FreeMemoryCapacity();

        public abstract void CopyInformation();

        public abstract void FullInformation();
    }
}
