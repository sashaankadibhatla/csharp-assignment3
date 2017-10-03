using System;
using triangle;
using square;
using rectangle;
using finale;

namespace csharp_assignment3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i=1;
           
            while(i==1){
                 Console.WriteLine("Enter your option \n 1.perimeter of square \n 2.perimeter of rectangle\n 3.perimeter of triangle\n 4.Exit");
                 int n= int.Parse(Console.ReadLine());
                 switch(n){
                     case 1:    Console.WriteLine("enter the length of side");
                                float side=float.Parse(Console.ReadLine());
                               if(side>0){
                                Maths sqr1 =new Maths(side);
                                float per1=sqr1.calculate_perimeter(side);
                                Console.WriteLine("Perimeter of Square is {0}",per1);}
                                else Console.WriteLine("entered negative value please enter positive");
                                break;
                     case 2:    Console.WriteLine("enter the length of rectangle");
                                float length=float.Parse(Console.ReadLine());
                                Console.WriteLine("enter the breadth of rectangle");
                                float breadth=float.Parse(Console.ReadLine());
                                if(length>0&&breadth>0){
                                Maths rect1 =new Maths(length,breadth);
                                float per2=rect1.calculate_perimeter(length,breadth);
                                Console.WriteLine("Perimeter of Square is {0}",per2);}
                                else Console.WriteLine("either length or breadth is negative please enter positive greater than zero");
                                break;
                     case 3:    Console.WriteLine("enter the length of side1");
                                float side1=float.Parse(Console.ReadLine());
                                Console.WriteLine("enter the length of side2");
                                float side2=float.Parse(Console.ReadLine());
                                Console.WriteLine("enter the length of side3");
                                float side3=float.Parse(Console.ReadLine());
                                if(side1>0&&side2>0&&side3>0){
                                Maths tr1 =new Maths(side1,side2,side3);
                                float per3=tr1.calculate_perimeter(side1,side2,side3);
                                Console.WriteLine("Perimeter of Square is {0}",per3);}
                                else Console.WriteLine("either one of the sides is zero or negative please enter positive value");
                                break;
                     case 4:   Environment.Exit(0);
                                break;
                     default:Console.WriteLine("Give correct option"); break;
                 }
            }
                }
            }
}
