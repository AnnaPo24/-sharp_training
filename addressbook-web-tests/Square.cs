using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    internal class Square
    {
        private int size;

        public Square(int size) // конструктор 
        {
            this.size = size;
        }

        public int Size    // метод аксессор( get и set св-ва)
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }


        }
    }
}
