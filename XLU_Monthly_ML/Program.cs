﻿
// This file was auto-generated by ML.NET Model Builder. 

using XLU_Monthly_ML;

// Create single instance of sample data from first line of dataset for model input
Test.ModelInput sampleData = new Test.ModelInput()
{
    Timestamp = @"2024-12-31",
    Open = 82.92F,
    High = 82.95F,
    Low = 74.7004F,
    Volume = 187763150F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual Close with predicted Close from sample data...\n\n");


Console.WriteLine($"Timestamp: {@"2024-12-31"}");
Console.WriteLine($"Open: {82.92F}");
Console.WriteLine($"High: {82.95F}");
Console.WriteLine($"Low: {74.7004F}");
Console.WriteLine($"Close: {75.69F}");
Console.WriteLine($"Volume: {187763150F}");


// Make a single prediction on the sample data and print results
var predictionResult = Test.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Close: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();

