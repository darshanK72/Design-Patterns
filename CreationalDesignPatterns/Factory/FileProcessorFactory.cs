using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class FileProcessorFactory
    {
        public static IFileProcesser CreateFileProcessor(string fileType)
        {
            switch (fileType.ToLower())
            {
                case "json":
                    return new JsonFileProcesser();
                case "xml":
                    return new XmlFileProcesser();
                default:
                    throw new ArgumentException($"Unsupported file type: {fileType}");
            }
        }
    }
}
