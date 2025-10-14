namespace idk
{
    public partial class Form1 : Form
    {
        private MyMath suck_a_nigga_dick;

        private string content;

        private Panel[] smooth_bar;
        private Label[] smooth_text;

        public Form1()
        {
            InitializeComponent();
            suck_a_nigga_dick = new MyMath();
            smooth_bar = [
                bar,
                mini_one,
                mini_two,
                mini_three,
                mini_four,
                mini_five,
            ];
            smooth_text = [
                text_one,
                text_two,
                text_three,
                text_four,
                text_five
            ];
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            suck_a_nigga_dick.DoMagicMath(content);
            ShowOnSmoothBar();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            if (InputBox.Text != null)
            {
                content = InputBox.Text;
            }
        }

        private void ShowOnSmoothBar()
        {
            for(int i = 0; i < smooth_bar.Length; i++)
            {
                smooth_bar[i].Visible = true;
            }
            for (int i = 0; i < smooth_text.Length; i++)
            {
                smooth_text[i].Visible = true;
            }
        }

    }
}
