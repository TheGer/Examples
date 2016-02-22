using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleExample
{
    class Rectangle
    {
        //attribute
        int width;

        //method which accesses the attribute
        public int Width
        {
            get { return width; }
            set { 
                    if (value>0)
                    { 
                    width = value;
                    }
                }
        }

        //attribute
        int height;

        
        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                { 
                    height = value; 
                }
            }
        }


        public Rectangle()
        {
            width = 0;
            height = 0;
        }

        public Rectangle(int w,int h)
        {
            Width = w;
            Height = h;
        }

        public int area()
        {
            return width * height;
        }

        public int perimeter()
        {
            return (width + height) * 2;

        }

        public string drawMe()
        {
            string output = "";

            for (int r = 1; r <= height;r++)
            {
                for (int c = 1; c<=width;c++)
                {
                    if ((r==1) || (r==height))
                    {
                        output += "X";
                    }
                    else
                    {
                        if ((c==1) || (c==width))
                        {
                            output += "X";
                        }
                        else
                        {
                            output += " ";
                        }
                    }
                }
                output += "\n";
            }
            return output;

               
        }
    }
}
