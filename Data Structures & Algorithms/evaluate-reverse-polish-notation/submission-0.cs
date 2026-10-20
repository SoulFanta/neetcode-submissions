public class Solution {
    public int EvalRPN(string[] tokens) 
    {
Stack<int> stack = new Stack<int>();


int s;
for (int i=0; i < tokens.Length; i++)
{
    if (int.TryParse(tokens[i],out s))
    {
        stack.Push(s);
    }
    else
    {
        s = stack.Pop();
        if (tokens[i]=="+") stack.Push(stack.Pop() + s);
        if (tokens[i]=="*") stack.Push(stack.Pop() * s);
        if (tokens[i]=="-") stack.Push(stack.Pop() - s);
        if (tokens[i]=="/") stack.Push(stack.Pop() / s);
    }

}

    return stack.Pop();
}
}
