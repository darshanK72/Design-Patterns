namespace AbstractFactoryPattern.Interfaces
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
