/* Assignment 6 (100 marks in total; 5% of the final score of this course)
 *
 * Question 4 (20 marks)
 *
 * Write a java program to compute the transpose of a user input matrix,
 * whose elements are all integers.
 *
 * Converting rows of a matrix into columns and columns of a matrix into
 * row is called transpose of a matrix.
 *
 * INPUT: user input matrix (2D array).
 * OUTPUT: the transpose of input matrix.
 *
 * Note: considering how to take users' input, you can set some rules
 * (give users some hints) to make your code user-friendly.
 * User will follow your instruction to input test example.
 *
 * Example:
 * INPUT: 4  6  8
 *        5  8  9
 *        2  1  8
 *
 * OUTPUT: 4  5  2
 *         6  8  1
 *         8  9  8
 *
 */

import java.util.Scanner;

public class Q4_TransposeMatrix {
    static int[][] transpose(int[][] in) {
        int[][] out = new int[in.length][in[0].length];
        for (int i = 0; i < in[0].length; i++) {
            for (int j = 0; j < in.length; j++) {
                out[i][j] = in[j][i];
            }
        }

        return out;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter matrix width and then height");
        int width = sc.nextInt();
        int height = sc.nextInt();

        int[][] arr = new int[height][width];
        System.out.println("Enter each line as numbers seperated by spaces");

        for (int i = 0; i < height; i++) {
            String rawLine = sc.nextLine();
            String[] rawLineSplit = rawLine.split(" ");
            if (rawLineSplit.length != width) {
                System.out.println("Incorrect width, try again");
                i--;
                continue;
            }

            int[] line = new int[width];
            for (int j = 0; j < width; j++) {
                line[j] = Integer.parseInt(rawLineSplit[j]);
            }

            arr[i] = line;
        }

        arr = transpose(arr);

        for (int[] i : arr) {
            for (int j : i) {
                System.out.printf(j + " ");
            }
            System.out.println();
        }
    }
}
