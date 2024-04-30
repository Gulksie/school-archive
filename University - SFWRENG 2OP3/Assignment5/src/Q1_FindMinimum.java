/* Assignment 5 (100 marks in total; 5% of the final score of this course)
 *
 * Question 1 (20 marks)
 *
 * Write a Java program, use 'subroutine' to finds the minimum value of
 * the first N elements of an array of type int.
 * Meanwhile, your code can throw an IllegalException (custom run-time
 * exception, which can be one provided by Java) if N is not in the range
 * of the length of input array.
 *
 * Input: user input array and number N.
 * Output: the minimum value of the first N elements of the array.
 *
 * Note: The array and N are parameters to the subroutine.
 * Users will input an array with no specific length.
 *
 */

import java.util.ArrayList;
import java.util.Scanner;

public class Q1_FindMinimum {

    static int findMin(int[] arr, int length) throws IllegalArgumentException{
        if (arr.length <= length) {
            throw new IllegalArgumentException();
        }

        int min = Integer.MAX_VALUE; // literally any int (except one equal to this) will be smaller this
        for (int i : arr) {
            if (i < min) {
                min = i;
            }
        }

        return min;
    }

    public static void main(String[] args) {
        System.out.println("Input nums in array, then a blank line when done.");
        ArrayList<Integer> arr = new ArrayList<>();
        Scanner sc = new Scanner(System.in);

        while (true) {
            String i = sc.nextLine();

            if (i.equals("")) break;

            Integer nextArrEl = Integer.parseInt(i);

            arr.add(nextArrEl);
        }

        System.out.println("Input N.");
        int N = sc.nextInt();

        //convert Integer array to primitive int array
        int[] primitiveArr = new int[arr.size()];
        for (int i = 0; i < primitiveArr.length; i++) {
            primitiveArr[i] = arr.get(i);
        }

        try {
            System.out.println(findMin(primitiveArr, N));
        } catch (IllegalArgumentException ex) {
            System.out.println("Invalid N input");
        }
    }
}


