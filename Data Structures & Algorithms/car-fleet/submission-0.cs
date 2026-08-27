public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        Dictionary<int,int> track = new Dictionary<int,int>();

        for(int i = 0; i< position.Length; i++)
        {
            track[position[i]] = speed[i];
        }

        Array.Sort(position, (a, b) => b.CompareTo(a));

        var stack = new Stack<double>();
        for(int i=0; i< position.Length; i++)
        {
            //find how much time it takes to reach the target.
            var time = (double)(target-position[i])/ track[position[i]];

            if(stack.Count > 0 && stack.Peek() >= time) // if current time is less then all these will be grouped 
            {
                continue;
            }
            stack.Push(time);
        }

        return stack.Count();
    }
}