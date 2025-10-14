using System.Drawing.Text;

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
            object result = suck_a_nigga_dick.DoMagicMath(content);

            ShowOnSmoothBar();
            ChangeTheSmoothText(result);
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
            for (int i = 0; i < smooth_bar.Length; i++)
            {
                smooth_bar[i].Visible = true;
            }

            for (int i = 0; i < smooth_text.Length; i++)
            {
                smooth_text[i].Visible = true;
            }
        }

        private void ChangeTheSmoothText(object result)
        {
            double answer = CheckIfNiggative(result);
            PrintResult(answer);
        }

        private double CheckIfDouble(object result)
        {
            if (result.GetType() == typeof(double) || result.GetType() == typeof(int))
            {
                return (double)result;
            }
            else
            {
                MessageBox.Show("The result of an expression is not a double\nYou're nigga!!!");
                return -1;
            }
        }

        private double CheckIfNiggative(object result)
        {
            double answer = CheckIfDouble(result);
            if (answer < 0)
            {
                return -answer;
            }
            else
            {
                return answer;
            }
        }

        private void PrintResult(double result)
        {
            double reversedDoubledResult = -result * 2;
            text_one.Text = reversedDoubledResult.ToString();

            double reversedResult = -result;
            text_two.Text = reversedResult.ToString();

            text_three.Text = "0";

            text_four.Text = result.ToString();

            double doubledResult = reversedDoubledResult;
            text_five.Text = doubledResult.ToString();
        }
    }
}
