/* Assignment 11 (100 marks in total; 5% of the final score of this course)
 *
 * Question 1 (50 marks in total)
    Use mutils.BinarySearchTree as a basic structure to implement a TreeMap for <String, Integer>.
    You cannot use JCF provided map.
 */

import mutils.BinarySearchTree;
import mutils.Node;

import java.util.ArrayList;
import java.util.Objects;

public class Q1_TreeMapByBST {

    // use m_bst as the basic data structure for the treemap of <String, Integer>
    BinarySearchTree m_bst = new BinarySearchTree();

    // Question 1.1 (5 marks): implement method size().
    // Returns the number of elements in this map (its cardinality).
    // You can ONLY modify the body of this method including the return statement.
    public int size() {
        return sizeWorker(m_bst.root);
    }

    private int sizeWorker(Node parent) {
        int s = 1;

        if (parent.left != null) {
            s += sizeWorker(parent.left);
        }
        if (parent.right != null) {
            s += sizeWorker(parent.right);
        }

        return s;
    }

    // Question 1.2 (5 marks): implement method isEmpty().
    // Returns true if this map contains no elements, otherwise return false.
    // You can ONLY modify the body of this method including the return statement.
    public boolean isEmpty() {
        return size() == 0;
    }

    // Question 1.3 (15 marks) implement method get().
    // If key is contained in the map, return the value of the key.
    // If key is not contained in the map, return -1.
    // You can ONLY modify the body of this method including the return statement.
    public int get(String key) {
        return getWorker(key, m_bst.root);
    }

    private int getWorker(String key, Node parent) {
        if (parent == null) {
            return -1;
        }

        if (parent.data.equals(key)) {
            return parent.freq;
        }

        if (parent.left != null) {
            int left = getWorker(key, parent.left);
            if (left != -1) {
                return left;
            }
        }

        if (parent.right != null) {
            int right = getWorker(key, parent.right);
            if (right != -1) {
                return right;
            }
        }

        return -1;
    }

    // Question 1.4 (15 marks) implement method put().
    // If the key is already contained in the map, overwrite the old value and return -1;
    // If the key is not contained in the map, add a new <key,value> entry to the map and return 1;
    // You can ONLY modify the body of this method including the return statement.
    public int put(String key, int value) {
        boolean isIn = putWorker(key, value, m_bst.root);

        if (!isIn) {
            m_bst.insert(new Node(key, value));
        }

        return isIn ? -1 : 1;
    }

    private boolean putWorker(String key, int value, Node parent) {
        if (parent == null) {
            return false;
        }

        if (Objects.equals(parent.data, key)) {
            parent.freq = value;
            return true;
        }

        if (parent.left != null) {
            boolean left = putWorker(key, value, parent.left);
            if (left) {
                return true;
            }
        }

        if (parent.right != null) {
            boolean right = putWorker(key, value, parent.right);
            if (right) {
                return true;
            }
        }

        return false;
    }

    // Question 1.5 (10 marks) implement method getKeysInAlphabeticalOrder().
    // return the keys of this map as an ArrayList<String> in Alphabetical order.
    // You can ONLY modify the body of this method including the return statement.
    public ArrayList<String> getKeysInAlphabeticalOrder(){
        // first step is to pop all the keys into an array
        ArrayList<String> keysAL = getKeys();
        String[] keys = new String[keysAL.size()];
        keys = keysAL.toArray(keys);

        // ok now we sort
        // bubble sort because uhhhh why not
        boolean swapped;
        do {
            swapped = false;
            for (int i = 0; i < keys.length-1; i++) {
                if (keys[i].compareTo(keys[i+1]) > 0) {
                    // compareTo function taken from BinarySearchTree
                    String tmp = keys[i];
                    keys[i] = keys[i+1];
                    keys[i+1] = tmp;

                    swapped = true;
                }
            }
        } while (swapped);

        keysAL.clear();
        for (String i : keys) {
            keysAL.add(i);
        }

        return keysAL;
    }

    public ArrayList<String> getKeys() {
        return getKeys(m_bst.root);
    }

    public ArrayList<String> getKeys(Node parent) {
        ArrayList<String> keys = new ArrayList<>();

        keys.add(parent.data);

        if (parent.left != null) {
            keys.addAll(getKeys(parent.left));
        }

        if (parent.right != null) {
            keys.addAll(getKeys(parent.right));
        }

        return keys;
    }

    public static void main(String[] args) {
        Q1_TreeMapByBST bst_ = new Q1_TreeMapByBST();

        BinarySearchTree bst = bst_.m_bst;
        // call the method insert
        bst.insert(new Node("abef", 1));
        bst.insert(new Node("abd", 1));
        bst.insert(new Node("abee", 1));
        bst.insert(new Node("f", 1));
        bst.insert(new Node("a", 1));
        bst.insert(new Node("bce", 1));
        bst.inorder();

        System.out.println();
        System.out.println(bst.root);
        System.out.println(bst_.size());
        System.out.println(bst.root);
    }
}
