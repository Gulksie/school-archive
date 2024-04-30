/* Assignment 5 (100 marks in total; 5% of the final score of this course)
 *
 * Question 4 (20 marks)
 *
 * Write a java program to use Method Overloading for printing three types of array:
 * Integer[], Character[] and Double[].
 *
 * Input: None.
 * Output: print out different types of array.
 *
 * There is no specific format as long as printed arrays are neatly and cleanly.
 *
 */
public class Q4_PrintArray {
    // creating a method for printing integer array
    /* place your code here */
    static void printArr(Integer[] arr) {
        for (Integer i : arr) {
            System.out.println(i);
        }
    }

    // overloading the above created method with different parameter method
    // contains a character parameter
    static void printArr(Character[] arr) {
        for (Character i : arr) {
            System.out.println(i);
        }
    }

    // overloading the above created method with different parameter method
    // contains a double parameter
    static void printArr(Double[] arr) {
        for (Double i : arr) {
            System.out.println(i);
        }
    }

    // you could probably also do this
    // but this doesnt use overloads so i can see why they dont want us to
    /* static void printArr(Object[] arr) {
        for (Object i : arr) {
            System.out.println(i);
        }
    }*/

    public static void main(String[] args) {
        Integer[] iarr = {1,2,3,4,5};
        Character[] carr = {'A','B','C','D','E'};
        Double[] darr = {1.234, 2.345, 3.456, 4.567};

        // calling the methods and printing the arrays
        System.out.println("Int array");
        printArr(iarr);

        System.out.println("\nChar array");
        printArr(carr);

        System.out.println("\nDouble array");
        printArr(darr);
    }
}
