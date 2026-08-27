public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();

        var arr = path.Split('/');
        foreach(var x in arr)
        {
            if(x == ".." )
            {
                if(stack.Count>0)
                    stack.Pop();
            }
            else if (x != "." && x != "")
            {
                stack.Push(x);
            }
        }

        if(stack.Count == 0)
        {
            return "/";
        }

        StringBuilder sb = new StringBuilder();
        
        while(stack.Count > 0)
        {
            sb.Insert(0,'/'+stack.Pop());
        }

        return sb.ToString();
    }
}