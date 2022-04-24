using Xunit;

var result = IsValid("()[]{}");
Assert.Equal(true, result);

static bool IsValid(string s)
{
    if (s.Length % 2 != 0)
        return false;

    var stack = new Stack<char>();

    foreach (var item in s)
    {
        if (item == '(')
            stack.Push(')');
        else if (item == '[')
            stack.Push(']');
        else if (item == '{')
            stack.Push('}');
        else if (stack.Count == 0 || stack.Pop() != item)
            return false;
    }

    return stack.Count == 0;
}