using System;
using csharp_assignment3;
using rectangle;
using square;
using triangle;
namespace finale{
    
    public class Maths{
            Rectangle rect=new Rectangle();
            Square sqr=new Square();
            Triangle tr=new Triangle();

        public  Maths(float side)
        {
            sqr.side=side;
        }
        public Maths(float length,float breadth)
        {
            rect.length=length;
            rect.breadth=breadth;
        }
        public  Maths(float side1,float side2,float side3)
        {
            tr.side1=side1;
            tr.side2=side2;
            tr.side3=side3;
        }
        public float calculate_perimeter(float side)
        {
            return 4*side;
        }
        public float calculate_perimeter(float length,float breadth)
        {
            return 2*(length+breadth);
        }
        public float calculate_perimeter(float side1,float side2,float side3)
        {
            return (side1+side2+side3);
        }

}
}