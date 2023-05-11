namespace WinFormsApp1
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
            label1 = new Label();
            startButton = new Button();
            label2 = new Label();
            result = new Label();
            countRes = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(271, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 0;
            
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.FromArgb(0, 192, 0);
            startButton.Location = new Point(271, 258);
            startButton.Name = "startButton";
            startButton.Size = new Size(193, 52);
            startButton.TabIndex = 1;
            startButton.Text = "Старт";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(107, 133);
            label2.Name = "label2";
            label2.Size = new Size(548, 32);
            label2.TabIndex = 2;
            label2.Text = "Загадайте число від 1 -100 та натисніть старт";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            result.Location = new Point(225, 179);
            result.Name = "result";
            result.Size = new Size(72, 30);
            result.TabIndex = 3;
            result.Text = "result";
            // 
            // countRes
            // 
            countRes.AutoSize = true;
            countRes.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            countRes.Location = new Point(225, 209);
            countRes.Name = "countRes";
            countRes.Size = new Size(68, 30);
            countRes.TabIndex = 4;
            countRes.Text = "steps";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 424);
            Controls.Add(countRes);
            Controls.Add(result);
            Controls.Add(label2);
            Controls.Add(startButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button startButton;
        private Label label2;
        private Label result;
        private Label countRes;
    }
}