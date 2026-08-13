public class Solution {
    public int CalPoints(string[] operations) {        
        
        var s = new Stack<int>();
        int sum = 0;

        for (int i = 0; i < operations.Length; i++)
        {
            var operation = operations[i];

            if (int.TryParse(operation, out var score))
            {
                s.Push(score);
                sum += score;
                continue;
            }

            if (operation == "D")
            {
                if (s.TryPeek(out int lastScore))
                {
                    s.Push(lastScore * 2);
                    sum += lastScore*2;
                }
            }

            if (operation == "C")
            {
                var popped = s.Pop();
                sum -= popped;

            }

            if (operation == "+")
            {
                int top = s.Pop();       // last score
                int second = s.Peek();   // score before last
                int newScore = top + second;

                s.Push(top);             // put the top back
                s.Push(newScore);        // add the new score

                sum += newScore;
            }
        }

        return sum;
    }
}