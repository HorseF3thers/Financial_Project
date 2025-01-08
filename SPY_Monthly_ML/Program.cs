﻿
// This file was auto-generated by ML.NET Model Builder. 

using SPY_Monthly_ML;

// Create single instance of sample data from first line of dataset for model input
Test.ModelInput sampleData = new Test.ModelInput()
{
    Timestamp = @"2025-01-29",
    Open = 602.97F,
    High = 609.07F,
    Low = 580.91F,
    Volume = 1061761300F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual Close with predicted Close from sample data...\n\n");

Console.WriteLine($"Timestamp: " + sampleData.Timestamp);
Console.WriteLine($"Open: " + sampleData.Open);
Console.WriteLine($"High: " + sampleData.High);
Console.WriteLine($"Low: " + sampleData.Low);
Console.WriteLine($"Volume: " + sampleData.Volume);


// Make a single prediction on the sample data and print results
var predictionResult = Test.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Close: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

