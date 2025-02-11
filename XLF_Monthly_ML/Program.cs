﻿
// This file was auto-generated by ML.NET Model Builder. 

using XLF_Monthly_ML;

// Create single instance of sample data from first line of dataset for model input
Test.ModelInput sampleData = new Test.ModelInput()
{
    Timestamp = @"2024-12-31",
    Open = 51.42F,
    High = 51.4893F,
    Low = 47.59F,
    Volume = 828114050F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual Close with predicted Close from sample data...\n\n");


Console.WriteLine($"Timestamp: {@"2024-12-31"}");
Console.WriteLine($"Open: {51.42F}");
Console.WriteLine($"High: {51.4893F}");
Console.WriteLine($"Low: {47.59F}");
Console.WriteLine($"Close: {48.33F}");
Console.WriteLine($"Volume: {828114050F}");


// Make a single prediction on the sample data and print results
var predictionResult = Test.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Close: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

