﻿// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace QQQ_Daily_Forecast_ML
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

            // update and predict model
            // TBD
        }
    }
}

