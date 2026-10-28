public class MinStack {
    private Stack<int> stack;  
    private Stack<int> order;

    public MinStack() {
        stack = new Stack<int>();     
        order = new Stack<int>();     
    }
    
    public void Push(int val) {
        stack.Push(val);       
        if(order.Count == 0 || order.Peek() >= val)
        {
            order.Push(val);
        }        
    }
    
    public void Pop() {
        var current = stack.Pop();        

        if(order.Peek() == current)
        {
            order.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return order.Peek();
    }
}
