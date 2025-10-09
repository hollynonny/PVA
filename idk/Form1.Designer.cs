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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.Location = new Point(221, 86);
            InputBox.Margin = new Padding(4);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(630, 31);
            InputBox.TabIndex = 0;
            InputBox.TextChanged += InputBox_TextChanged;
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
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Enabled = false;
            panel1.Location = new Point(55, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 11);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Enabled = false;
            panel2.Location = new Point(534, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 63);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Enabled = false;
            panel3.Location = new Point(841, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 63);
            panel3.TabIndex = 4;
            panel3.Visible = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Enabled = false;
            panel4.Location = new Point(1045, 324);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 63);
            panel4.TabIndex = 4;
            panel4.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveCaption;
            panel5.Enabled = false;
            panel5.Location = new Point(55, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 63);
            panel5.TabIndex = 5;
            panel5.Visible = false;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ActiveCaption;
            panel6.Enabled = false;
            panel6.Location = new Point(221, 324);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 63);
            panel6.TabIndex = 4;
            panel6.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(528, 420);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 566);
            Controls.Add(label1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
    }
}
