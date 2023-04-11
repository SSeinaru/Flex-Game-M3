using System;
namespace Classes
{
    class MainClass
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.x = 100;
            rect.y = 200;
            rect.width = 50;
            rect.height = 50;

            Console.WriteLine($"Rectangle x: {rect.x}, y: {rect.y}, width: {rect.width}, height: {rect.height}");
        }
    }
}

