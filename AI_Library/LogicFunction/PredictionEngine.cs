using AI_Library.Entities;
using AI_Library.SettingAI;
using Datatraining;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Library.LogicFunction
{
    public class PredictionEngine
    {
        private readonly DataRepository _dataRepository;
        private readonly int INTERVAL = SetingAiConst.InterVall;
        public PredictionEngine( )
        {
            _dataRepository = new DataRepository();
        }

        public ModelOutput Predict()
        {
            // true. Tạo một đối tượng MLContext để quản lý quy trình học máy
            var mlContext = new MLContext();
            var dataTrain = new DataRepository();

            var listData = dataTrain.GetRawData();
            //new float[] { 1, 0 ,1,  1, 0 ,0 ,1,  1, 0 ,1, 0 ,0 ,1,  1, 0 ,1,  1, 0 ,1, 0 ,1,  1, 0 ,0 ,1,  1, 0 ,0 ,1,  0 };

            // 2. Chuẩn bị dữ liệu huấn luyện
            var trainingData = HandleRawData(listData, INTERVAL);

            // 3. Chuyển đổi dữ liệu thành định dạng IDataView để ML.NET xử lý
            var trainDataView = mlContext.Data.LoadFromEnumerable(trainingData);

            // 4. Định nghĩa pipeline cho mô hình
            var pipeline = mlContext.Transforms.Concatenate("Features", "Features")
                            .Append(mlContext.BinaryClassification.Trainers.LbfgsLogisticRegression());

            // 5. Huấn luyện mô hình
            var model = pipeline.Fit(trainDataView);

            // 6. Tạo dữ liệu dự đoán mới
            var dataSample = listData.GetRange(listData.Count - INTERVAL, INTERVAL);
            var newSample = new ModelInput
            {
                Features = dataSample.ToArray()
            };

            // 7. Tạo predictor và dự đoán
            var predictor = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);
            var prediction = predictor.Predict(newSample);

            Console.WriteLine($"Dự đoán: {(prediction.Prediction ? "True" : "False")}");
            Console.WriteLine($"Xác suất: {prediction.Probability:P2}");


            return prediction;
        }
        
        public void AddData( float data)
        {
            if(data != 1 && data != 0)
            {
                throw new Exception("Data must be 1 or 0");
            }
            _dataRepository.SavePrediction(data.ToString());
        }
        private List<ModelInput> HandleRawData(List<float> listData, int interval)
        {
            long sizedata = listData.Count;
            List<ModelInput> result = new List<ModelInput>();

            
            for (int i = 0; i < sizedata - interval; i++)
            {
                var data = listData.GetRange(i, interval);
                result.Add(new ModelInput { 
                    Features = data.ToArray(),
                    Label = listData[i + interval ] == 1 ? true : false
                });
            }
            return result;
        }

        public void ResetData()
        {
            _dataRepository.ResetLastData();
        }

        public List<bool> GetHistory(int num)
        {
            return _dataRepository.GetRawData().Select(x => x == 1).TakeLast(num).ToList();
            
        }
    }
}
