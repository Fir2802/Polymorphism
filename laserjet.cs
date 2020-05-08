using System;
using System.Collections.Generic;
using System.Text;

namespace LAB._5
{
    class laserjet : printerwindows
    {
        public override void show()
        {
            Console.WriteLine("laserjet display dimension : 12*12");
        }
        public override void print()
        {
            Console.WriteLine("laserjet printer printing");
        }
    }
}
