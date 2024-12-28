using System;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class MacOSTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering MacOS TextBox");
        }
    }
}
