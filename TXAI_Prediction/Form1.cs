using AI_Library.LogicFunction;

namespace TXAI_Prediction
{
    public partial class Form1 : Form
    {
        private readonly PredictionEngine _predictionEngine;
        public Form1()
        {
            InitializeComponent();
            _predictionEngine = new PredictionEngine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = _predictionEngine.Predict();

            lbPercent.Text = (Math.Round(res.Probability * 100, 2)).ToString() + "%";

            lbResult.Text = res.Prediction == true ? "TÀI" : "XỈU";

        }

        private void btxiu_Click(object sender, EventArgs e)
        {
            _predictionEngine.AddData(0);
            ResetHistory();
        }

        private void btTai_Click(object sender, EventArgs e)
        {
            _predictionEngine.AddData(1);
            ResetHistory();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            _predictionEngine.ResetData();
            ResetHistory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetHistory();
        }
        private void ResetHistory()
        {
            fpHistory.Controls.Clear();
            var items = _predictionEngine.GetHistory(13);
            foreach (var item in items)
            {
                CheckBox checkBox = new CheckBox
                {
                    AutoSize = true,
                };
                checkBox.Checked = item;
                checkBox.Enabled = false;

                fpHistory.Controls.Add(checkBox);
            }
        }
    }
}
