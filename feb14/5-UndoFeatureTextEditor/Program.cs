using System;
class Program
{
    static string ProcessEditorOperations(List<string> ops)
    {
        Stack<string> stack = new Stack<string>();

        foreach (var op in ops)
        {
            if (op.StartsWith("TYPE "))
            {
                string word = op.Substring(5); 
                stack.Push(word);
            }
            else if (op == "UNDO")
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
        }

        return string.Join(" ", stack.Reverse());
    }

    static void Main()
    {
        var ops = new List<string>
        {
            "TYPE Hello",
            "TYPE World",
            "UNDO",
            "TYPE CSharp"
        };

        string result = ProcessEditorOperations(ops);
        Console.WriteLine(result);
    }
}
