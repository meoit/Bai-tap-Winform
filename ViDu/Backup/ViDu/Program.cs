using System;
using System.Collections.Generic;
using System.Text;

namespace ThanmDoi
{
    class Program
    {
        private int property;
        public int Property
        {
            get
            {
                return this.property;

            }
            set
            {
                this.property = value;
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Property = 3;

            Console.WriteLine(p.Property);
            Console.ReadKey();

        }
    }
}