using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Interfaces;
using CreationalDesignPatterns.Factory;
using CreationalDesignPatterns.Singleton;
using System.Data;

namespace DesignPatternApp
{
    class Program
    {
        static void MainSingleton(string[] args)
        {
            IDbConnection connection = DBConnection.GetDBConnection();
        }
        static void MainFactory(string[] args)
        {
            try
            {
                // Request a JSON file processor
                IFileProcesser jsonProcessor = FileProcessorFactory.CreateFileProcessor("json");
                jsonProcessor.Process();

                // Request an XML file processor
                IFileProcesser xmlProcessor = FileProcessorFactory.CreateFileProcessor("xml");
                xmlProcessor.Process();

                // Request an unsupported file processor to see the exception
                IFileProcesser unsupportedProcessor = FileProcessorFactory.CreateFileProcessor("csv");
                unsupportedProcessor.Process();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static void MainAbstractFactory(string[] args)
        {
            string platform = "Windows";

            IUIFactory uiFactory;

            if (platform == "Windows")
            {
                uiFactory = new WindowsUIFactory();
            }
            else if (platform == "MacOS")
            {
                uiFactory = new MacOSUIFactory();
            }
            else
            {
                throw new ArgumentException("Unsupported platform");
            }

            IButton button = uiFactory.CreateButton();
            ITextBox textBox = uiFactory.CreateTextBox();

            button.Render();
            textBox.Render();
        }
        static void Main(string[] args)
        {
            ICarBuilder carBuilder = new CarBuilder();
            CarDirector director = new CarDirector(carBuilder);

            director.ConstructSportsCar();
            Car sportsCar = carBuilder.GetResult();
            Console.WriteLine(sportsCar);

            director.ConstructCityCar();
            Car cityCar = carBuilder.GetResult();
            Console.WriteLine(cityCar);

            carBuilder.Reset();
            carBuilder.SetEngine("Hybrid Engine");
            carBuilder.SetWheels(4);
            carBuilder.SetGPS(true);
            Car customCar = carBuilder.GetResult();
            Console.WriteLine(customCar);
        }
    }



}

