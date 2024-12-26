﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SizikovSS.Sprint6.Task0.V22.Lib
{
    public class DataService : ISprint6Task0V22
    {
        public double Calculate(int x)
        {
            return Math.Round(0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2), 3);
        }
    }
}
