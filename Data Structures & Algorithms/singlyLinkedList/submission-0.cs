public class LinkedList {

    private Node head;    

    public LinkedList() {
        head = null;
    }

    public int Get(int index) {
        if(index < 0) return -1;

        Node current = head;
        int currentIndex = 0;

        while(current != null) {
            if(currentIndex == index) return current.value;
            current = current.next;
            currentIndex++;
        }        

        return -1;
    }

    public void InsertHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
    }

    public void InsertTail(int val) {
        Node newNode = new Node(val);

        if(head == null) {
            head = newNode;
            return;
        }

        Node current = head;
        while(current.next != null) {
            current = current.next;
        }

        current.next = newNode;
    }

    public bool Remove(int index) {
        if(index < 0 || head == null) return false;

        if(index == 0) {
            head = head.next;
            return true;
        }

        Node current = head;
        int currentIndex = 0;

        while(current != null && currentIndex < index - 1){
            current = current.next;
            currentIndex++;
        }

        if(current == null || current.next == null) return false;

        current.next = current.next.next;
        return true;
    }

    public List<int> GetValues() {
        List<int> values = new List<int>();

        Node current = head;

        while(current != null) {
            values.Add(current.value);
            current = current.next;
        }

        return values;
    }
}

public class Node {
    
    public int value {get;set;}
    public Node next {get;set;}

    public Node(int val) {
        value = val;
        next = null;
    } 
}