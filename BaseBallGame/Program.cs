// You are keeping the scores for a baseball game with strange rules.
//At the beginning of the game, you start with an empty record.

// You are given a list of strings operations, 
//where operations[i] is the ith operation you must apply to the record and is one of the following:

// An integer x.
// Record a new score of x.

// '+'.
// Record a new score that is the sum of the previous two scores.

// 'D'.
// Record a new score that is the double of the previous score.

// 'C'.
// Invalidate the previous score, removing it from the record.
// Return the sum of all the scores on the record after applying all the operations.

var result = CalPoints(new string[] {"5", "-2", "4", "C", "D", "9", "+", "+"});


int CalPoints(string[] operations)
{
    // we need an array to store and convert the numbers
    Stack<int> scores = new ();
    // iterate with for or foreach through each operation in array
    foreach (var item in operations)
    {
        // check first on the cases of the letters
        // check for +
        if(item == "+")
        {
            // when we get + we need to get the top element with -1 to sum
                // and pop 2 times so we can get the new result
                var firstNumber = scores.Peek();
                scores.Pop();
                var secondNumber = scores.Peek();
                scores.Pop();
                // the order of re pushing is very important , LIFO
                scores.Push(secondNumber);
                scores.Push(firstNumber);
                scores.Push(firstNumber + secondNumber);
        }
        else if(item == "D")
        {
                // get peek , duplicate and push to the stack
                var timesTwoNumber = scores.Peek();
                scores.Push(timesTwoNumber * 2);
        }
        else if(item == "C")
        {
                // just pop to invalidate the last score
                scores.Pop();
        }
        // finally if they're not strings convert and push to scores
        else
        {
            // append to the int array
            scores.Push(int.Parse(item));
        }
    }

    int sumResult = 0;
    foreach (var item in scores)
    {
        sumResult = sumResult + item;
    }
    
    return sumResult;
}