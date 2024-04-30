/* Assignment 10 (100 marks in total; 5% of the final score of this course)
 *
 * Question 2 (60 marks in total)
    use an Integer array to implement the following set named m_SetByArray
    you cannot use JCF provided set.
 */

import java.util.Arrays;
import java.util.Set;

class m_SetByArray {
    // Use m_array to store all the items in the set.
    // This is a strict mandatory requirement of this assignment.
    // To keep it simple, we use a fixed length array with 100 items.
    Integer[] m_array = new Integer[100];
    int number_of_items = 0; // this variable keep track of how many items are in the set.

    // Question 2.1 (5 marks): implement method size().
    // Returns the number of elements in this set (its cardinality).
    // You can ONLY modify the body of this method including the return statement.
    public int size() {
        return number_of_items;
    }

    // Question 2.2 (5 marks): implement method isEmpty()
    // Returns true if this set contains no elements, otherwise return false.
    // You can ONLY modify the body of this method including the return statement.
    public boolean isEmpty() {
        return size() == 0;
    }

    // Question 2.3 (10 marks): implement method contains()
    /* Returns true if this set contains the specified element. More formally,
    returns true if and only if this set contains an element e such that Objects.equals(o, e).
    Parameters:
        o – element whose presence in this set is to be tested
    Returns:
        true if this set contains the specified element
    */
    // You can ONLY modify the body of this method including the return statement.
    public boolean contains(Integer o) {
        for (int i = 0; i < number_of_items; i++) {
            if (m_array[i].equals(o)) {
                return true;
            }
        }

        return false;
    }

    // Question 2.4 (15 marks): implement method add()
    /* Adds the specified element to this set if it is not already present.
     * If this set does not contain the element, add the element to this set
     * and return true.
     * If this set already contains the element, the call leaves the set
     * unchanged and return false.
     */
    // You can ONLY modify the body of this method including the return statement.
    public boolean add(Integer e) {
        if (contains(e)) {
            return false;
        } else {
            m_array[number_of_items] = e;

            number_of_items++;

            return true;
        }
    }

    // Question 2.5 (15 marks): implement method remove()
    /* Removes the specified element from this set if it is present.
     * Returns true if this set contained the element.
     * Returns false if this set does not contain the element
     */
    // You can ONLY modify the body of this method including the return statement.
    public boolean remove(Integer o) {
        boolean doneSwap = false;
        // once we've done the swap, we need to move everything else down one index in the array
        for (int i = 0; i < m_array.length; i++) {
            if (doneSwap) {
                m_array[i-1] = m_array[i];
            } else {
                if (m_array[i].equals(o)) {
                    m_array[i] = null;
                    doneSwap = true;
                }
            }
        }

        if (doneSwap) {
            number_of_items--;
            return true;
        } else return false;
    }

    // Question 2.6 (5 marks): implement method clear()
    /* Removes all of the elements from this set. The set will be empty after this call returns. */
    // You can ONLY modify the body of this method including the return statement.
    public void clear() {
        number_of_items = 0;
        Arrays.fill(m_array, null); // intellij autocompleted this for me, original code below
        /* for (int i = 0; i < m_array.length; i++) {
            m_array[i] = null;
        }
        */
    }

    // Question 2.7 (5 marks): print the set items
    public void printSet() {
        StringBuilder toPrint = new StringBuilder("{");
        for (int i = 0; i < number_of_items; i++) {
            toPrint.append(m_array[i]).append(", ");
        }


        // remove the last comma and space (if it exists)
        int l = toPrint.length();
        if (l > 2) {
            toPrint.delete(l-2, l);
        }
        toPrint.append("}");

        System.out.println(toPrint);
    }
}

public class Q2_SetByArray {

    public static void main(String[] args) {
        System.out.println("******************************");
        System.out.println("Start testing with Integer ...");
        m_SetByArray test_integer = new m_SetByArray();
        System.out.println("Is empty? " + test_integer.isEmpty());
        System.out.println("Size is: " + test_integer.size());
        test_integer.add(1);
        test_integer.add(2);
        test_integer.add(3);
        test_integer.printSet();
        System.out.println("Testing on adding duplicate items");
        System.out.println("Can we add a duplicate item valued 2? " + test_integer.add(2));
        System.out.println("Can we remove value 2? " + test_integer.remove(2));
        test_integer.printSet();
        System.out.println("Can we add an old item valued 2 after removing? " + test_integer.add(2));
        test_integer.printSet();
        System.out.println("Can we clear all? ");
        test_integer.clear();
        test_integer.printSet();
    }
}
