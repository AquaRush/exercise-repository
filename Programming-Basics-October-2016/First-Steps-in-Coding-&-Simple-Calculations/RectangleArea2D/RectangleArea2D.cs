﻿//using System;

//class RectangleArea2D
//{
//    static void Main()
//    {
//        var x1 = double.Parse(Console.ReadLine());
//        var y1 = double.Parse(Console.ReadLine());
//        var x2 = double.Parse(Console.ReadLine());
//        var y2 = double.Parse(Console.ReadLine());

//        
//        var width = Math.Abs(x1 - x2);
//        var height = Math.Abs(y1 - y2);
//        var area = width * height;
//        var perimeter = 2 * (width + height)
//        Console.WriteLine(area);
//        Console.WriteLine(perimeter);
//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////

using System;

class RectangleArea2D
{
    static void RectArea2D(double x1, double y1, double x2,double y2)
    {
        double width = Math.Abs(x1 - x2);
        double height = Math.Abs(y1 - y2);

        double area = width * height;
        double perimeter = 2 * (width + height);
        Console.WriteLine(area);
        Console.WriteLine(perimeter);
    }


    static void Main()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());

        RectArea2D(x1, y1, x2, y2);

    }
}





