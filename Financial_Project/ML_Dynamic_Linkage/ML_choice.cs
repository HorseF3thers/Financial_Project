using Financial_Project.Chart_Builder;
using Microsoft.ML.Data;
using ScottPlot;
using System.Reflection;

namespace Financial_Project.ML_Dynamic_Linkage
{
    public class ML_choice : ML_choiceIF
    {
        private string _modelName;
        public ML_choice(string modelName)
        {
            _modelName = modelName;
            if(_modelName.Contains("Forecast"))
            {
                var program = new Forecast_Model();
                program.setEnvironment(this);
                program.start();
            }
            else if(_modelName.Contains("python"))
            {
                 throw new NotImplementedException("Python models are not supported yet.");
            }
            else
            {
                var program = new PricePred_Model();
                program.setEnvironment(this);
                program.start();
            }
        }
        public MethodInfo loadModel()
        {
            if (string.IsNullOrEmpty(_modelName))
            {
                throw new InvalidOperationException("Model name is not set.");
            }
            //later I will add python.net support for models from tensorflow
            Assembly assembly = Assembly.Load(_modelName);
            Console.WriteLine(_modelName + ".Test");
            Type type = assembly.GetType(_modelName + ".Test");
            Console.WriteLine(type);
            MethodInfo method = type.GetMethod("Predict");

            if (method == null)
            {
                throw new InvalidOperationException("The method 'predict' was not found in the 'Test' class.");
            }
            return method;
        }
        public void buildPredication(MethodInfo method)
        {
            string path = _modelName + ".Test+ModelInput";
            Assembly assembl = Assembly.Load(_modelName);
            var modelInputType = assembl.GetType(path);
            var modelInputInstance = Activator.CreateInstance(modelInputType);

            Form inputForm = new Form();
            inputForm.Width = 400;
            inputForm.Height = 400;
            inputForm.Text = "Enter Model Input Values";

            System.Windows.Forms.Label timestampLabel = new System.Windows.Forms.Label() { Left = 10, Top = 20, Text = "Timestamp" };
            TextBox timestampBox = new TextBox() { Left = 150, Top = 20, Width = 200 };

            System.Windows.Forms.Label openLabel = new System.Windows.Forms.Label() { Left = 10, Top = 60, Text = "Open" };
            TextBox openBox = new TextBox() { Left = 150, Top = 60, Width = 200 };

            System.Windows.Forms.Label highLabel = new System.Windows.Forms.Label() { Left = 10, Top = 100, Text = "High" };
            TextBox highBox = new TextBox() { Left = 150, Top = 100, Width = 200 };

            System.Windows.Forms.Label lowLabel = new System.Windows.Forms.Label() { Left = 10, Top = 140, Text = "Low" };
            TextBox lowBox = new TextBox() { Left = 150, Top = 140, Width = 200 };

            System.Windows.Forms.Label volumeLabel = new System.Windows.Forms.Label() { Left = 10, Top = 180, Text = "Volume" };
            TextBox volumeBox = new TextBox() { Left = 150, Top = 180, Width = 200 };

            Button submitButton = new Button() { Text = "Submit", Left = 100, Top = 220, Width = 150, Height = 50 };
            submitButton.Click += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(timestampBox.Text) ||
                    string.IsNullOrWhiteSpace(openBox.Text) ||
                    string.IsNullOrWhiteSpace(highBox.Text) ||
                    string.IsNullOrWhiteSpace(lowBox.Text) ||
                    string.IsNullOrWhiteSpace(volumeBox.Text))
                {
                    return;
                }
                else
                {
                    inputForm.Close();
                }
            };

            inputForm.Controls.Add(timestampLabel);
            inputForm.Controls.Add(timestampBox);
            inputForm.Controls.Add(openLabel);
            inputForm.Controls.Add(openBox);
            inputForm.Controls.Add(highLabel);
            inputForm.Controls.Add(highBox);
            inputForm.Controls.Add(lowLabel);
            inputForm.Controls.Add(lowBox);
            inputForm.Controls.Add(volumeLabel);
            inputForm.Controls.Add(volumeBox);
            inputForm.Controls.Add(submitButton);

            inputForm.ShowDialog();

            inputForm.FormClosing += (sender, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    inputForm.Dispose();
                    return;
                }
                return;
            };

            if (!(string.IsNullOrWhiteSpace(timestampBox.Text) ||
                    string.IsNullOrWhiteSpace(openBox.Text) ||
                    string.IsNullOrWhiteSpace(highBox.Text) ||
                    string.IsNullOrWhiteSpace(lowBox.Text) ||
                    string.IsNullOrWhiteSpace(volumeBox.Text)))
            {
                try
                {
                    PropertyInfo? timestampProperty = modelInputType.GetProperty("Timestamp");
                    PropertyInfo? openProperty = modelInputType.GetProperty("Open");
                    PropertyInfo? highProperty = modelInputType.GetProperty("High");
                    PropertyInfo? lowProperty = modelInputType.GetProperty("Low");
                    PropertyInfo? volumeProperty = modelInputType.GetProperty("Volume");

                    if (timestampProperty == null || openProperty == null || highProperty == null || lowProperty == null || volumeProperty == null)
                    {
                        throw new InvalidOperationException("One or more properties were not found on the model input type.");
                    }

                    timestampProperty.SetValue(modelInputInstance, timestampBox.Text);
                    openProperty.SetValue(modelInputInstance, float.Parse(openBox.Text));
                    highProperty.SetValue(modelInputInstance, float.Parse(highBox.Text));
                    lowProperty.SetValue(modelInputInstance, float.Parse(lowBox.Text));
                    volumeProperty.SetValue(modelInputInstance, float.Parse(volumeBox.Text));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }

                var modelOutput = method.Invoke(null, new object[] { modelInputInstance });
                dynamic output = modelOutput;
                double[] dataC = new double[1];
                dataC[0] = output.Close;
                float close = output.Score;

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
        }
        public void buildForecast(MethodInfo method)
        {
            var modelOutput = method.Invoke(null, new object[] { null, null });
            dynamic output = modelOutput;


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
