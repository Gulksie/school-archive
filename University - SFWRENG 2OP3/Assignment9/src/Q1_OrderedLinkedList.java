/* Assignment 9 (100 marks in total; 5% of the final score of this course)
 *
 * Question 1 (40 marks)
    1. Inherit from LKList.A2_LinkedList to implement a subclass Q1_OrderedLinkedList that overrides the sortLinkedList()
    method by using insertion sort instead of the original bubble sort in LKList.A2_LinkedList. Please sort all nodes in
    ascending order of data values.
    2. Implement an orderedInsert() method that inserts a new node in an ordered linked list without breaking the order of
    nodes. Please use one or multiple of the methods of the super class LKList.A2_LinkedList such as insertAtBeginning(),
    insertAtEnd(int new_data) and insertAfter().
 */

import LKList.*;

public class Q1_OrderedLinkedList extends LKList.A2_LinkedList{
    // Use the following method to override the original sortLinkedList() method.
    // The following method should implement insertion sort.
    // (25 marks)
    public void sortLinkedList(Node headref)
    {
        System.out.println("Running insertion sort of A1_OrderedLinkedList ...");

        // this is my first time writing an insertion sort, bare with me here
        // assume the first element (in this case headref) is already sorted
        for (Node activeNode = headref.next; activeNode.next != null; activeNode = activeNode.next) {

            Node iterationNode = activeNode;
            while (true) {
                // now we move every element one item left until we find where this thing is supposed to go
                Node parent = getParent(iterationNode);
                if (parent == null) { // we're at the top of the list, we're done
                    break;
                }

                if (parent.data > iterationNode.data) {
                    // swap time
                    // the last time we had to swap stuff, i spent a looong time trying to swap actual indexes of Nodes
                    // rather than just the values of Nodes
                    // i ended up just swapping the values of the nodes since it was so much easier
                    // i dont think this was *technically* allowed, but thats how the function is implemented
                    // in A2_Linkedlist
                    // so thats how im going to be doing it here

                    int tmp = parent.data;
                    parent.data = iterationNode.data;
                    iterationNode.data = tmp;
                    iterationNode = parent;

                } else { // no more swapping necessary, we're done here
                    break;
                }
            }
        }
    }

    private Node getParent(Node n) {
        // gets the parent of Node n, null if no parent (top of list/not in list)
        // probably not the best way of doing it but whatever
        for (Node parent = head; parent != null; parent = parent.next) {
            if (parent.next == n) {
                return parent;
            }
        }

        return null;
    }

    // Use the following method to implement orderedInsert().
    // The 'newnode' should be inserted without breaking the order of a LinkedList in ascending order.
    // Only the methods insertAtBeginning(), insertAtEnd(int new_data) and insertAfter() of the superclass LKList.A2_LinkedList can be used.
    // (15 marks)
    public void orderedInsert(Node newnode) {
        // im assuming in this case "without breaking order" means keeping the list sorted
        // in addition im assuming that the node im inserting has no children
        // otherwise it would be impossible to always keep the list in order while keeping this node intact

        // the way the functions are written in the superclass, we only care about the new node's data, not the node itself
        int data = newnode.data;

        // since the for loop we're about to do only works when we're not inserting the node at the beginning, we should
        // check for that first
        if (data < head.data) {
            insertAtBeginning(data);
            return;
        }

        for (Node n = head; n.next != null; n = n.next) {
            if (n.next.data > data) {
                // insert the Node here
                insertAfter(n, data);
                return;
            }
        }

        // if we've gotten to this point then this new node is the largest in the list, so it goes at the end
        insertAtEnd(data);
    }

    public static void main (String args[]) {
        System.out.println("A1_OrderedLinkedList");
        // test A1_OrderedLinkedList
        Q1_OrderedLinkedList llist1 = new Q1_OrderedLinkedList();

        llist1.insertAtEnd(1);
        llist1.insertAtBeginning(3);
        llist1.insertAtBeginning(5);
        llist1.insertAtEnd(7);
        llist1.insertAfter(llist1.head.next, 9);
        llist1.printList();

        llist1.sortLinkedList(llist1.head);
        llist1.printList();

        Node newnode = new Node(10);
        llist1.orderedInsert(newnode);
        llist1.printList();

        System.out.println("\nA2_LinkedList");
        // test A2_LinkedList
        A2_LinkedList llist2 = new A2_LinkedList();

        llist2.insertAtEnd(2);
        llist2.insertAtBeginning(4);
        llist2.insertAtBeginning(6);
        llist2.insertAtEnd(8);
        llist2.insertAfter(llist2.head.next, 10);
        llist2.printList();

        llist2.sortLinkedList(llist2.head);
        llist2.printList();
    }
}
