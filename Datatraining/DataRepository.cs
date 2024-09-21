using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatraining
{
    public class DataRepository
    {
        public List<float> GetRawData()
        {
            List<float> data = new List<float>();
            using (var reader = new StreamReader("../../../../Datatraining/Data/DataRaw.json"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Tách các giá trị trong dòng bằng dấu phẩy
                    var values = line.Split(',');

                    // Chuyển đổi giá trị từ chuỗi sang kiểu bool
                    foreach (var value in values)
                    {
                        data.Add(value == "1" ? 1 : 0);
                    }
                }
            }
            return data;
        }
        public  void SavePrediction( string value)
        {
            using (var writer = new StreamWriter("../../../../Datatraining/Data/DataRaw.json", true)) // true để ghi tiếp vào file, không ghi đè
            {
                writer.Write($",{value}");
            }
        }

        public void ResetLastData()
        {
            string filePath = "../../../../Datatraining/Data/DataRaw.json";
            string content;

            // Read the entire content of the file
            using (var reader = new StreamReader(filePath))
            {
                content = reader.ReadToEnd();
            }

            // Remove the last two characters
            if (content.Length >= 2)
            {
                content = content.Substring(0, content.Length - 2);
            }

            // Write the modified content back to the file
            using (var writer = new StreamWriter(filePath, false)) // false to overwrite the file
            {
                writer.Write(content);
            }

        }
    }
}
