using System;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows Button");
        }
    }
}
