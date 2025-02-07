﻿// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace XLF_Monthly_Forecast_ML
{
    class Program
    {
        static void Main(string[] args)
        {
            // predict with default option.
            var modelOutput = Test.Predict();
            Console.WriteLine(string.Join(",", modelOutput.Close));

            // predict next 5 periods
            modelOutput = Test.Predict(horizon: 5);
            Console.WriteLine(string.Join(",", modelOutput.Close));
            Console.WriteLine(string.Join(",Upper Bound,", modelOutput.Close_LB));
            Console.WriteLine(string.Join(",Lower Bound,", modelOutput.Close_UB));

            // update and predict model
            // TBD
        }
    }
}

