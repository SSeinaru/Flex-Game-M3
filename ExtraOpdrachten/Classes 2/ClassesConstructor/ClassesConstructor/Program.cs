using System;

namespace ClassesConstructor
{
    internal class Program
    {
        static void Main()
        {
            Rectangle rect = new Rectangle(100, 200, 50, 50);

            Console.WriteLine($"Rectangle x: {rect.x}, y: {rect.y}, width: {rect.width}, height: {rect.height}");
        }

    }
}