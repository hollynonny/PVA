using NCalc;

namespace idk
{
    public class MyMath
    {
        public object DoMagicMath(string content)
        {
            content = content.Trim();
            Expression e = new Expression(content);
            object result = e.Evaluate();
            MessageBox.Show("Result: " + result);
            return result;
        }
    }
}
