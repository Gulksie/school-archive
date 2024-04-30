/* Assignment 7 (100 marks in total; 5% of the final score of this course)
 *
 * Question 2 (60 marks)
    Use java to implement a data structure named LinkedList, and implement several methods of the LinkedList.

 */

class Node {
    int data; // 'data' stores the value of a node.
    Node next; // 'next' refers/points to the next node

    // the construction method of class Node.
    Node(int d) {
        data = d;
        next = null;
    }

    public Node getTail() {
        // this is used to make the insertAtEnd function easier to implement
        // i wrote an alternative implementation of the function if this is not allowed
        if (this.next == null) {
            return this;
        }

        return this.next.getTail();
    }
}

class Q2_LinkedList {
    Node head;

    // Insert 'new_data' at the beginning of the LinkedList
    // (5 marks)
    public void insertAtBeginning(int new_data) {
        Node newNode = new Node(new_data);
        newNode.next = this.head;
        this.head = newNode;
    }

    // Insert 'new_data' at the end of the LinkedList
    // (5 marks)
    public void insertAtEnd(int new_data) {
        if (this.head == null) {
            this.head = new Node(new_data);
        }

        Node tail = this.head.getTail();

        tail.next = new Node(new_data);
    }

    public void insertAtEnd(Integer new_data) {
        // alternative implementation that doesn't use the node.tail function
        if (this.head == null) {
            this.head = new Node(new_data);
        }

        Node n;
        for (n = this.head; n.next != null; n=n.next) {} // just go to our very last node

        n.next = new Node(new_data);
    }

    // Insert 'new_data' after a node referred to as 'prev_node'
    // (10 marks)
    public void insertAfter(Node prev_node, int new_data) {
        Node newNode = new Node(new_data);

        newNode.next = prev_node.next;

        prev_node.next = newNode;
    }

    // Delete a node located in 'position' of the Linked List. The first element of the LinkedList has a position=0.
    // (10 marks)
    void deleteNode(int position) {
        Node workingNode = this.head;
        for (int i = 0; i < position-1; i++) {
            workingNode = workingNode.next;
        }

        if (workingNode == null || workingNode.next == null) { //wtf
            return;
        }

        workingNode.next = workingNode.next.next;
    }

    // Search for a node containing the value of 'key' in the LinkedList.
    // If there is a node in the LinkedList whose value is equal to 'key', then return 'true'.
    // If there is no node in the LinkedList whose value is equal to 'key', then return 'false'.
    // (15 marks)
    boolean search(Node head, int key) {
        for (Node n = head; n != null; n = n.next) {
            if (n.data == key) {
                return true;
            }
        }
        return false;
    }

    // Sort the nodes in the LinkedList in ascending orders of their values.
    // Requirement: please use bubble sort.
    // Example: for a LinkedList: head->3->5->1->4->2, the sorted LinkedList should be head->1->2->3->4->5.
    // (15 marks)
    void sortLinkedList(Node head) {
        boolean changed;
        do {
            changed = false;
            for (Node n = head; n.next != null; n = n.next) {
                if (n.data > n.next.data) {
                    // attempting to swap instances of n caused major headaches, so instead we will swap
                    // the values of the nodes
                    int tmp = n.data;
                    n.data = n.next.data;
                    n.next.data = tmp;

                    changed = true;
                }
            }
        } while (changed);
    }

    // Print the linked list
    public void printList() {
        Node tnode = head;
        while (tnode != null) {
            System.out.print(tnode.data + " ");
            tnode = tnode.next;
        }
    }

    public static void main(String[] args) {
        /* TA may test different functions of the LinkedList here */
        /* The following is just an example of how to do the test. */

        Q2_LinkedList llist = new Q2_LinkedList();

        llist.insertAtEnd(1);
        llist.insertAtBeginning(2);
        llist.insertAtBeginning(3);
        llist.insertAtEnd(4);
        llist.insertAfter(llist.head.next, 5);

        System.out.println("Linked list: ");
        llist.printList();

        System.out.println("\nAfter deleting an element: ");
        llist.deleteNode(3);
        llist.printList();

        System.out.println();
        int item_to_find = 3;
        if (llist.search(llist.head, item_to_find))
            System.out.println(item_to_find + " is found");
        else
            System.out.println(item_to_find + " is not found");

        llist.sortLinkedList(llist.head);
        System.out.println("\nSorted List: ");
        llist.printList();
    }
}