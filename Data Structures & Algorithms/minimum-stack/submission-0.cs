public class MinStack {

    private Stack<(int Value, int Min)> stack = null;

    public MinStack() {
        stack = new Stack<(int Value, int Min)>();
    }
    
    public void Push(int val) {
        var min = stack.Any() ? Math.Min(val, GetMin()) : val;
        stack.Push(new ValueTuple<int, int>(val, min));
    }
    
    public void Pop() {
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek().Value;
    }
    
    public int GetMin() {
        return stack.Peek().Min;
    }
}
       
    
    