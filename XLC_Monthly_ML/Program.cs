﻿
// This file was auto-generated by ML.NET Model Builder. 

using XLC_Monthly_ML;

// Create single instance of sample data from first line of dataset for model input
Test.ModelInput sampleData = new Test.ModelInput()
{
    Timestamp = @"2024-12-31",
    Open = 98.47F,
    High = 102.67F,
    Low = 96.3311F,
    Volume = 84385400F,
};



Console.WriteLine("Using model to make single prediction -- Comparing actual Close with predicted Close from sample data...\n\n");


Console.WriteLine($"Timestamp: {@"2024-12-31"}");
Console.WriteLine($"Open: {98.47F}");
Console.WriteLine($"High: {102.67F}");
Console.WriteLine($"Low: {96.3311F}");
Console.WriteLine($"Close: {96.81F}");
Console.WriteLine($"Volume: {84385400F}");


// Make a single prediction on the sample data and print results
var predictionResult = Test.Predict(sampleData);
Console.WriteLine($"\n\nPredicted Close: {predictionResult.Score}\n\n");

Console.WriteLine("=============== End of process, hit any key to finish ===============");
Console.ReadKey();
