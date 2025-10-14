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
            bar = new Panel();
            mini_three = new Panel();
            mini_four = new Panel();
            mini_five = new Panel();
            mini_one = new Panel();
            mini_two = new Panel();
            text_one = new Label();
            text_two = new Label();
            text_three = new Label();
            text_four = new Label();
            text_five = new Label();
            SuspendLayout();
            // 
            // InputBox
            // 
            InputBox.Location = new Point(155, 52);
            InputBox.Margin = new Padding(3, 2, 3, 2);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(442, 23);
            InputBox.TabIndex = 0;
            InputBox.TextChanged += InputBox_TextChanged;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(336, 80);
            CalculateButton.Margin = new Padding(3, 2, 3, 2);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(83, 22);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // bar
            // 
            bar.BackColor = SystemColors.ActiveCaptionText;
            bar.Enabled = false;
            bar.Location = new Point(38, 208);
            bar.Margin = new Padding(2);
            bar.Name = "bar";
            bar.Size = new Size(700, 7);
            bar.TabIndex = 2;
            bar.Visible = false;
            // 
            // mini_three
            // 
            mini_three.BackColor = SystemColors.ActiveCaption;
            mini_three.Enabled = false;
            mini_three.Location = new Point(374, 194);
            mini_three.Margin = new Padding(2);
            mini_three.Name = "mini_three";
            mini_three.Size = new Size(7, 38);
            mini_three.TabIndex = 3;
            mini_three.Visible = false;
            // 
            // mini_four
            // 
            mini_four.BackColor = SystemColors.ActiveCaption;
            mini_four.Enabled = false;
            mini_four.Location = new Point(589, 194);
            mini_four.Margin = new Padding(2);
            mini_four.Name = "mini_four";
            mini_four.Size = new Size(7, 38);
            mini_four.TabIndex = 4;
            mini_four.Visible = false;
            // 
            // mini_five
            // 
            mini_five.BackColor = SystemColors.ActiveCaption;
            mini_five.Enabled = false;
            mini_five.Location = new Point(732, 194);
            mini_five.Margin = new Padding(2);
            mini_five.Name = "mini_five";
            mini_five.Size = new Size(7, 38);
            mini_five.TabIndex = 4;
            mini_five.Visible = false;
            // 
            // mini_one
            // 
            mini_one.BackColor = SystemColors.ActiveCaption;
            mini_one.Enabled = false;
            mini_one.Location = new Point(38, 194);
            mini_one.Margin = new Padding(2);
            mini_one.Name = "mini_one";
            mini_one.Size = new Size(7, 38);
            mini_one.TabIndex = 5;
            mini_one.Visible = false;
            // 
            // mini_two
            // 
            mini_two.BackColor = SystemColors.ActiveCaption;
            mini_two.Enabled = false;
            mini_two.Location = new Point(155, 194);
            mini_two.Margin = new Padding(2);
            mini_two.Name = "mini_two";
            mini_two.Size = new Size(7, 38);
            mini_two.TabIndex = 4;
            mini_two.Visible = false;
            // 
            // text_one
            // 
            text_one.AutoSize = true;
            text_one.Location = new Point(21, 247);
            text_one.Margin = new Padding(2, 0, 2, 0);
            text_one.Name = "text_one";
            text_one.Size = new Size(38, 15);
            text_one.TabIndex = 6;
            text_one.Text = "label1";
            text_one.Visible = false;
            // 
            // text_two
            // 
            text_two.AutoSize = true;
            text_two.Location = new Point(136, 247);
            text_two.Margin = new Padding(2, 0, 2, 0);
            text_two.Name = "text_two";
            text_two.Size = new Size(38, 15);
            text_two.TabIndex = 7;
            text_two.Text = "label1";
            text_two.Visible = false;
            // 
            // text_three
            // 
            text_three.AutoSize = true;
            text_three.Location = new Point(360, 247);
            text_three.Margin = new Padding(2, 0, 2, 0);
            text_three.Name = "text_three";
            text_three.Size = new Size(38, 15);
            text_three.TabIndex = 8;
            text_three.Text = "label1";
            text_three.Visible = false;
            // 
            // text_four
            // 
            text_four.AutoSize = true;
            text_four.Location = new Point(573, 247);
            text_four.Margin = new Padding(2, 0, 2, 0);
            text_four.Name = "text_four";
            text_four.Size = new Size(38, 15);
            text_four.TabIndex = 9;
            text_four.Text = "label1";
            text_four.Visible = false;
            // 
            // text_five
            // 
            text_five.AutoSize = true;
            text_five.Location = new Point(722, 247);
            text_five.Margin = new Padding(2, 0, 2, 0);
            text_five.Name = "text_five";
            text_five.Size = new Size(38, 15);
            text_five.TabIndex = 10;
            text_five.Text = "label1";
            text_five.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 340);
            Controls.Add(text_five);
            Controls.Add(text_four);
            Controls.Add(text_three);
            Controls.Add(text_two);
            Controls.Add(text_one);
            Controls.Add(mini_two);
            Controls.Add(mini_one);
            Controls.Add(mini_five);
            Controls.Add(mini_four);
            Controls.Add(mini_three);
            Controls.Add(bar);
            Controls.Add(CalculateButton);
            Controls.Add(InputBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputBox;
        private Button CalculateButton;
        private Panel bar;
        private Panel mini_three;
        private Panel mini_four;
        private Panel mini_five;
        private Panel mini_one;
        private Panel mini_two;
        private Label text_one;
        private Label text_two;
        private Label text_three;
        private Label text_four;
        private Label text_five;
    }
}
