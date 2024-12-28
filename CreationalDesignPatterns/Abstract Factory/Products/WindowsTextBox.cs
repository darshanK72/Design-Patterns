using System;
using AbstractFactoryPattern.Interfaces;

namespace AbstractFactoryPattern.Products
{
    public class WindowsTextBox : ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Windows TextBox");
        }
    }
}
