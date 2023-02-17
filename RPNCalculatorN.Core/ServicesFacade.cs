using System.Text;

namespace RPNCalculatorN.Core;

public class ServicesFacade
{
    public static Stack<string> CurrentStack { get; set; } = new();
    public static StringBuilder sb = new();
    public Evaluator Evaluator = new Evaluator();
    public static List<string> Operators = new() { "-", "+", "/", "*" };

    public string[] Calc(string s)
    {
        if (s == "CE")
        {
            CurrentStack.Clear();
            sb.Clear();
            return FormatResult(string.Empty);
        }

        if (s.Trim().ToLower() == "enter")
        {
            CurrentStack.Push(sb.ToString());
            sb.Clear();
            
            var l = CurrentStack.ToList();
            l.Reverse();
            return FormatResult(CurrentStack.Peek());
        }
        
        if (int.TryParse(s, out var x))
        {
            sb.Append(s);
            return FormatResult(sb.ToString());
        }

        CurrentStack.Push(s);
        var res = Evaluator.Evaluate(CurrentStack).ToString();
        return FormatResult(res);

    }

    private string[] FormatResult(string str)
    {
        var stack = new Stack<string>(new Stack<string>(CurrentStack));
        stack.TryPop(out var val1);
        stack.TryPop(out var val2);
        stack.TryPop(out var val3);

        return new[] { str, val1 ?? string.Empty, val2 ?? string.Empty, val3 ?? string.Empty};
    }
}