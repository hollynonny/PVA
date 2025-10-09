using NCalc;

namespace idk
{
    public class MyMath
    {
        DoMagicMath(string content)
        {
            content = content.Trim();
            Expression e = Expression(content);
            Expression result = e.Evaluate();
            MessageBox.Show("Result: " + result.ToString());
        }
    }
}
