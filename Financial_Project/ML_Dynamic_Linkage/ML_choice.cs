using Financial_Project.Chart_Builder;
using Microsoft.ML.Data;
using ScottPlot;
using System.Reflection;

namespace Financial_Project.ML_Dynamic_Linkage
{
    public class ML_choice : ML_choiceIF
    {
        private string _modelName;
        public void runMLprediction()
        {
            if (string.IsNullOrEmpty(_modelName))
            {
                throw new InvalidOperationException("Model name is not set.");
            }
            //later I will add python.net support for models from tensorflow
            Assembly assembly = Assembly.Load(_modelName);
            Type type = assembly.GetType(_modelName + ".Test");
            MethodInfo method = type.GetMethod("Predict");

            if (method == null)
            {
                throw new InvalidOperationException("The method 'predict' was not found in the 'Test' class.");
            }


            if(_modelName.Contains("Forecast"))
            {
                var modelOutput = method.Invoke(null, new object[] { null, null });

                dynamic output = modelOutput;

                buildForecast(output);
            }
            else
            {
                //SPY_Daily_ML.Test.ModelInput modelInput = new SPY_Daily_ML.Test.ModelInput
                Console.WriteLine(_modelName);
                Console.WriteLine(_modelName + ".Test+ModelInput");
                string path = _modelName + ".Test+ModelInput";
                Assembly assembl = Assembly.Load(_modelName);

                if (assembly == null)
                {
                    throw new InvalidOperationException($"Assembly {_modelName} could not be loaded.");
                }

                var modelInputType = assembly.GetType(path);
                if (modelInputType == null)
                {
                    throw new InvalidOperationException($"Type {path} could not be found in the assembly.");
                }

                Console.WriteLine(modelInputType);
                var modelInputInstance = Activator.CreateInstance(modelInputType);

                PropertyInfo timestampProperty = modelInputType.GetProperty("Timestamp");
                PropertyInfo openProperty = modelInputType.GetProperty("Open");
                PropertyInfo highProperty = modelInputType.GetProperty("High");
                PropertyInfo lowProperty = modelInputType.GetProperty("Low");
                PropertyInfo volumeProperty = modelInputType.GetProperty("Volume");

                timestampProperty.SetValue(modelInputInstance, @"2025-01-03");
                openProperty.SetValue(modelInputInstance, 589.39f);
                highProperty.SetValue(modelInputInstance, 591.13f);
                lowProperty.SetValue(modelInputInstance, 580.50f);
                volumeProperty.SetValue(modelInputInstance, 50158756f);

                var modelOutput = method.Invoke(null, new object[] { modelInputInstance });
                dynamic output = modelOutput;
                buildPredication(output);
                /**{
                    Timestamp = @"2025-01-03",
                    Open = 589.39f,
                    High = 591.13f,
                    Low = 580.50f,
                    Volume = 50158756f,
                };

                var modelOutput = method.Invoke(null, new object[] { modelInput });
                dynamic output = modelOutput;
                buildPredication(output);**/
            }
        }
        public void buildPredication(dynamic output)
        {
            double[] dataC = new double[1];
            dataC[0] = output.Close;
            float close = output.Score;

            Console.WriteLine($"\n\nPredicted Close: {output.Score}\n\n");
            Thread thread = new Thread(() =>
            {
                Prediction_Form chart = new Prediction_Form();
                chart.createForm(output.Score);
                chart.chartPanel.MinimumSize = new Size(1242, 864);
                chart.chartPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                chart.chartPanel.AutoSize = true;
                chart.chartPanel.BorderStyle = BorderStyle.Fixed3D;
                Application.Run(chart);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void buildForecast(dynamic output)
        {
            double[] dataC = new double[output.Close.Length];
            Array.Copy(output.Close, dataC, output.Close.Length);

            double[] dataLB = new double[output.Close_LB.Length];
            Array.Copy(output.Close_LB, dataLB, output.Close_LB.Length);

            double[] dataUB = new double[output.Close_UB.Length];
            Array.Copy(output.Close_UB, dataUB, output.Close_UB.Length);
            double[] index = { 1, 2, 3, 4, 5 };

            Thread thread = new Thread(() =>
            {
                Forecast_Form chart = new Forecast_Form();
                chart.createForm(dataC, dataLB, dataUB);

                chart.chartPanel.MinimumSize = new Size(1242, 864);
                chart.chartPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                chart.chartPanel.AutoSize = true;

                chart.chartPanel.BorderStyle = BorderStyle.Fixed3D;

                Application.Run(chart);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        public void setMLmodel(string modelName)
        {
            _modelName = modelName;
        }
    }
}
