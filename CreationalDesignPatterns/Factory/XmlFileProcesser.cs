using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class XmlFileProcesser : IFileProcesser
    {
        public void Process()
        {
            Console.WriteLine("Processing XML File");
        }
    }
}
