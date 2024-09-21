namespace TXAI_Prediction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            lbResult = new Label();
            label4 = new Label();
            btxiu = new Button();
            button2 = new Button();
            label1 = new Label();
            lbPercent = new Label();
            btTai = new Button();
            btReset = new Button();
            fpHistory = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 40);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 2;
            label2.Text = "Kết quả dự đoán:";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(141, 40);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(29, 15);
            lbResult.TabIndex = 3;
            lbResult.Text = "True";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 73);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 4;
            label4.Text = "Kết quả thực tế:";
            // 
            // btxiu
            // 
            btxiu.Location = new Point(141, 69);
            btxiu.Name = "btxiu";
            btxiu.Size = new Size(75, 23);
            btxiu.TabIndex = 5;
            btxiu.Text = "XIU";
            btxiu.UseVisualStyleBackColor = true;
            btxiu.Click += btxiu_Click;
            // 
            // button2
            // 
            button2.Location = new Point(141, 116);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Dự đoán";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "Tỉ lệ dự đoán:";
            // 
            // lbPercent
            // 
            lbPercent.AutoSize = true;
            lbPercent.Location = new Point(288, 40);
            lbPercent.Name = "lbPercent";
            lbPercent.Size = new Size(23, 15);
            lbPercent.TabIndex = 8;
            lbPercent.Text = "0%";
            // 
            // btTai
            // 
            btTai.Location = new Point(236, 69);
            btTai.Name = "btTai";
            btTai.Size = new Size(75, 23);
            btTai.TabIndex = 9;
            btTai.Text = "TAI";
            btTai.UseVisualStyleBackColor = true;
            btTai.Click += btTai_Click;
            // 
            // btReset
            // 
            btReset.Location = new Point(236, 116);
            btReset.Name = "btReset";
            btReset.Size = new Size(75, 23);
            btReset.TabIndex = 10;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // fpHistory
            // 
            fpHistory.Location = new Point(33, 13);
            fpHistory.Name = "fpHistory";
            fpHistory.Size = new Size(288, 23);
            fpHistory.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 151);
            Controls.Add(fpHistory);
            Controls.Add(btReset);
            Controls.Add(btTai);
            Controls.Add(lbPercent);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btxiu);
            Controls.Add(label4);
            Controls.Add(lbResult);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label lbResult;
        private Label label4;
        private Button btxiu;
        private Button button2;
        private Label label1;
        private Label lbPercent;
        private Button btTai;
        private Button btReset;
        private FlowLayoutPanel fpHistory;
    }
}
