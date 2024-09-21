using AI_Library.SettingAI;
using Microsoft.ML.Data;
public class ModelInput
{

    [VectorType(SetingAiConst.InterVall)]  // Mảng 30 giá trị tuần tự trước đó
    public float[] Features { get; set; }

    public bool Label { get; set; }
}