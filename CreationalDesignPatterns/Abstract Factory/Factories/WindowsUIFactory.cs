using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
