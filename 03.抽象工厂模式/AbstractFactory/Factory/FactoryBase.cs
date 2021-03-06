﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public abstract class FactoryBase
    {
        public abstract ShapeBase CreateShape();

        public abstract ReporterBase CreateReport();

        public static FactoryBase GetFactory(string shapeName)
        {
            FactoryBase factory;
            switch (shapeName)
            {
                case "Square":
                    factory = new SquareFactory();
                    break;
                case "Triangle":
                    factory = new TriangleFactory();
                    break;
                default:
                    factory = null;
                    break;
            }
            return factory;
        }
    }
}