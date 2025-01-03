﻿// This file was auto-generated by ML.NET Model Builder.
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace XLP_Monthly_ML
{
    public partial class Test
    {
        /// <summary>
        /// model input class for Test.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [LoadColumn(0)]
            [ColumnName(@"timestamp")]
            public string Timestamp { get; set; }

            [LoadColumn(1)]
            [ColumnName(@"open")]
            public float Open { get; set; }

            [LoadColumn(2)]
            [ColumnName(@"high")]
            public float High { get; set; }

            [LoadColumn(3)]
            [ColumnName(@"low")]
            public float Low { get; set; }

            [LoadColumn(4)]
            [ColumnName(@"close")]
            public float Close { get; set; }

            [LoadColumn(5)]
            [ColumnName(@"volume")]
            public float Volume { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for Test.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            [ColumnName(@"timestamp")]
            public float[] Timestamp { get; set; }

            [ColumnName(@"open")]
            public float Open { get; set; }

            [ColumnName(@"high")]
            public float High { get; set; }

            [ColumnName(@"low")]
            public float Low { get; set; }

            [ColumnName(@"close")]
            public float Close { get; set; }

            [ColumnName(@"volume")]
            public float Volume { get; set; }

            [ColumnName(@"Features")]
            public float[] Features { get; set; }

            [ColumnName(@"Score")]
            public float Score { get; set; }

        }

        #endregion

        private static string MLNetModelPath = Path.GetFullPath("XLP_Monthly_Test.mlnet");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);


        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }
    }
}