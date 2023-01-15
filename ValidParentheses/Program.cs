// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', 
//determine if the input string is valid.

// An input string is valid if:

// Open brackets must be closed by the same type of brackets.
// Open brackets must be closed in the correct order.
// Every close bracket has a corresponding open bracket of the same type.

isValid("(){}[]");

bool isValid(string s)
{
    // stack because we need to eliminate the top element
    Stack<char> parenthesis = new();
    // dictionary approach, to map the closing parenthesis
    // with the opening parenthesis
    Dictionary<char, char> closeToOpen = new() {
        {'}', '{'},
        {']', '['},
        {')', '('}
    };
    // iterate through every char in the string
    for (int i = 0; i < s.Length; i++)
    {
        // if is a closing parenthesis
        if(closeToOpen.ContainsKey(s[i]))
        {
            // check if stack is empty and check
            // if the element on top is the match closing parenthesis
            if(parenthesis.Count >= 1 && parenthesis.Peek() == closeToOpen.GetValueOrDefault(s[i]))
            {
                // if that's true, pop the element
                parenthesis.Pop();
            }
            else
            {
                // if we reach here, we got a closing parenthesis
                // and nothing in the stack, so that's an auto false
                return false;
            }
        }
        // if s[i] is not a closing parenthesis
        // that means it's an opening parenthesis
        else
        {
            parenthesis.Push(s[i]);
        }
    }
    // at the end, basically if the stack is not empty
    // meaning the string is false to validate
    // if the stack is empty that means string is valid
    return parenthesis.Count == 0 ? true : false;
}