﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp
{
    public class BaseFeature
    {
        public string Name { get; set; }
        public BaseFeature()
        {
            Name = "Base";
        }

        public void FunFeature()
        {
            Console.WriteLine("Implemented in base");
        }

    }
}
