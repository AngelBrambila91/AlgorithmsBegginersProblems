using static System.Console;


MinStack min = new MinStack();
min.Push(-2);
min.Push(0);
min.Push(-3);
WriteLine(min.GetMin());
min.Pop();
WriteLine(min.Top());
WriteLine(min.GetMin());

public class MinStack
{
    // stack members
    private Stack<int> stack;
    // the trick is that we can't use iterations to get to the minimum
    // if we iterate that's basically O(n)
    // the trick is to create anther stack to store the minimum
    // after each push
    private Stack<int> minStack;
    public MinStack()
    {
        // initialize both stacks
        stack = new();
        minStack = new();
    }

    public void Push(int val)
    {
        // push val into normal stack
        stack.Push(val);
        // get the real minimum
        // we need to check if the minStack is empty, if it is
        // we need to get the value and compare
        // if not, just push the val into the minStack
        int min = Math.Min(val, minStack.Count != 0? minStack.Peek() : val);
        minStack.Push(min);
    }

    public void Pop()
    {
        // easy PoP
        stack.Pop();
        minStack.Pop();   
    }

    public int Top()
    {
        // easy top
        return stack.Peek();
    }

    public int GetMin()
    {
        // easy get Min from the min Stack
        return minStack.Peek();
    }
}