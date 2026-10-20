public class Solution {
    public bool IsValid(string s) 
    {
    if (s.Length < 2){return false;}

    Stack<char> stack = new Stack<char>();

    char p;
    foreach (char c in s)
    {

        if (c == '(' || c == '[' || c == '{') { stack.Push(c); }
        else {
            if (c == ')' && stack.TryPeek(out p) && p == '(')
            {
                stack.Pop();
            }
            else if (c == '}' && stack.TryPeek(out p) && p == '{')
            {
                stack.Pop();
            }
            else if (c == ']' && stack.TryPeek(out p) && p == '[')
            {
                stack.Pop();

            }
            else { return false; }

        }
        Console.WriteLine(stack.Count);


    }


    return stack.Count == 0;
}
}
