using System;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering MacOS Button");
        }
    }
}
