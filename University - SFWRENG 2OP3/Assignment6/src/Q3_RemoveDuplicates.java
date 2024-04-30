/* Assignment 6 (100 marks in total; 5% of the final score of this course)
 *
 * Question 3 (20 marks)
 *
 * Write a Java program, user input a 1-dimension array of integers, firstly
 * sorting it in non-increasing order, and then remove the duplicates in the
 * array (if exists).
 *
 * INPUT: user input a 1-dimension array.
 * OUTPUT: sorted array in non-increasing order, and without any repeating element.
 *
 * Note: You must write sort algorithm by yourself, you are not supposed to
 * use Arrays.sort() to output the result directly.
 *
 * Hint: you can use bubble sorting algorithm or other sorting algorithms.
 *
 * Keep the input format in the example and make your code user-friendly.
 *
 * Example 1:
 * INPUT: [0, 1, 1, 0, 1, 2, 2, 3, 3, 4]
 * OUTPUT: [4, 3, 2, 1, 0]
 *
 * Example 2:
 * INPUT: [7, 0, 4, 2, 9]
 * OUTPUT: [9, 7, 4, 2, 0]
 *
 */

import java.util.Scanner;

public class Q3_RemoveDuplicates {
    static int[] bubbleSortAndRemoveDuplicates (int[] in) {
        // in case we're not allowed to use array.sort, this is the only sorting
        // algorithm i know
        boolean changed;
        do {
            changed = false;
            for (int i = 0; i < in.length-1; i++) {
                // we will remove duplicates inside the sorting algorithm :)
                if (in[i] != 0 && in[i]==in[i+1]) {
                    in[i] = 0;
                }

                if (in[i] < in[i+1]) {
                    int tmp = in[i];
                    in[i] = in[i+1];
                    in[i+1] = tmp;
                    changed = true;
                }
            }
        } while (changed);

        // now we just need to cut out the extra zeros
        int zeros = 0;
        for (int i : in) {
            if (i==0) zeros++;
        }

        int[] out = new int[in.length-zeros+1];
        for (int i = 0; i<out.length; i++) {
            out[i] = in[i];
        }

        return out;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Input array length");

        int l = sc.nextInt();
        int[] arr = new int[l];

        System.out.println("Enter each value of the array");
        for (int i = 0; i < arr.length; i++) {
            arr[i] = sc.nextInt();
        }

        int[] arrSorted = bubbleSortAndRemoveDuplicates(arr);
        for (int i : arrSorted) {
            System.out.printf(i + " ");
        }
        System.out.println();
    }
}
