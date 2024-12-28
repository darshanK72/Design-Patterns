using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    public class MacOSUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacOSTextBox();
        }
    }
}
