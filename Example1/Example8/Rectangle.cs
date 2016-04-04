using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    class Rectangle:Printable,Shootable
    {

        double width, height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        public string printMe()
        {
            throw new NotImplementedException();
        }

        public void shootMe()
        {
           
        }
    }
}
