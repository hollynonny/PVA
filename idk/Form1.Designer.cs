namespace idk
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
            InputBox = new TextBox();
            CalculateButton = new Button();
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.Location = new Point(221, 86);
            InputBox.Margin = new Padding(4);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(630, 31);
            InputBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(480, 134);
            CalculateButton.Margin = new Padding(4);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(118, 36);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 566);
            Controls.Add(CalculateButton);
            Controls.Add(InputBox);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputBox;
        private Button CalculateButton;
    }
}
