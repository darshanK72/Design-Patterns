﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.Factory
{
    public class JsonFileProcesser : IFileProcesser
    {
        public void Process()
        {
            Console.WriteLine("Processing JSON File");
        }
    }
}
