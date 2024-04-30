/* Assignment 6 (100 marks in total; 5% of the final score of this course)
 *
 * Question 2 (20 marks)
 *
 * Write a java program, use "subroutine" to finish sorting a 2-dimension array.
 *
 * User input a 2-dimension array of double type, return it in non-decreasing
 * order according to values in the first raw, if there are two or more same
 * element in the first raw, keep the original sequence.
 *
 * INPUT: a user input 2-dimension array.
 * OUTPUT: sorted input array in non-decreasing order according to values in the first raw.
 *
 * Note: considering how to take users' input, you can set some rules (give users some hints)
 * to make your code user-friendly.
 * User will follow your instruction to input test example.
 *
 * Example 1
 * INPUT: if user input array (Order 2*4) is
 *        1.45  0.25  8.95  0.99
 *        2.56  5.67  0.47  2.65
 *
 * OUTPUT: 0.25  0.99  1.45  8.95
 *         5.67  2.65  2.56  0.47
 *
 * Example 2
 * INPUT: if user input array (Order 5*5) is
 *        0.95  0.23  0.95  0.95  0.65
 *        2.56  5.67  0.47  2.65  0.47
 *        1.45  0.25  8.95  0.99  0.67
 *        5.67  2.65  0.25  8.95  0.99
 *        1.23  4.21  0.97  7.64  8.52
 *
 * OUTPUT: 0.23  0.65  0.95  0.95  0.95
 *         5.67  0.47  2.56  0.47  2.65
 *         0.25  0.67  1.45  8.95  0.99
 *         2.65  0.99  5.67  0.25  8.95
 *         4.21  8.52  1.23  0.97  7.64
 *
 */

import java.util.Arrays;
import java.util.Scanner;

public class Q2_Sort2DArray {
    static double[][] sort2DArray (double[][] arr) {
        double[][] out = new double[arr.length][arr[0].length];

        // sort the first row
        double[] first = bubbleSort(arr[0].clone());
        out[0] = first;

        // now find where each element moved
        int[] moved =  new int[arr[0].length];

        for (int i = 0; i < first.length; i++) {
            for (int j = 0; j < arr[0].length; j++) {
                if (arr[0][j]==first[i]) {
                    boolean alreadyUsed = false;
                    for (int k : moved) {
                        alreadyUsed = alreadyUsed || k == j;
                    }

                    if (!alreadyUsed) {
                        moved[i] = j;
                    }
                }
            }
        }

        // finally sort the rest of the columns based on the first one
        for (int i = 1; i < out.length; i++) {
            double[] toOut = new double[arr[0].length];

            for (int j = 0; j < toOut.length; j++) {
                toOut[j] = arr[i][moved[j]];
            }

            out[i] = toOut;
        }

        return out;
    }

    static double[] bubbleSort (double[] in) {
        // in case we're not allowed to use array.sort, this is the only sorting
        // algorithm i know
        boolean changed;
        do {
            changed = false;
            for (int i = 0; i < in.length-1; i++) {
                if (in[i] > in[i+1]) {
                    double tmp = in[i];
                    in[i] = in[i+1];
                    in[i+1] = tmp;
                    changed = true;
                }
            }
        } while (changed);

        return in;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter matrix width and then height");
        int width = sc.nextInt();
        int height = sc.nextInt();

        double[][] arr = new double[height][width];
        System.out.println("Enter each line as numbers seperated by spaces");

        for (int i = 0; i < height; i++) {
            String rawLine = sc.nextLine();
            String[] rawLineSplit = rawLine.split(" ");
            if (rawLineSplit.length != width) {
                System.out.println("Incorrect width, try again");
                i--;
                continue;
            }

            double[] line = new double[width];
            for (int j = 0; j < width; j++) {
                line[j] = Double.parseDouble(rawLineSplit[j]);
            }

            arr[i] = line;
        }

        double[][] sorted = sort2DArray(arr);

        for (int i = 0; i < height; i++) {
            for (int j = 0; j < width; j++) {
                System.out.printf(sorted[i][j] + " ");
            }
            System.out.println();
        }

    }

}
