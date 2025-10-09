namespace idk
{
    public partial class Form1 : Form
    {
        private MyMath suck_a_nigga_dick;        

        private string content;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {   
            suck_a_nigga_dick.DoMagicMath(content);
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            if(InputBox.Text != null)
            {
                content = InputBox.Text;
            }
        }
        // + trida ShowOnSmoothBar()

    }
}
