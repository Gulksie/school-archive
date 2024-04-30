/* Assignment 6 (100 marks in total; 5% of the final score of this course)
 *
 * Question 5 (20 marks)
 *
 * Write a complete static method that finds the largest value in a 2-dimension array of ints.
 * The method should have one parameter, which is a 2d array of type int. The largest number
 * in the array should be returned as the value of the method.
 *
 * INPUT: user input a 2-dimension array of type int
 * OUTPUT: the largest number in input array
 *
 * Note: considering how to take users' input, you can set some rules (give users some hints)
 * to make your code user-friendly.
 * User will follow your instruction to input test example.
 *
 * Example:
 * Input: 4  6  8
 *        5  8  9
 *        2  1  8
 * Output: 9
 *
 */

import java.util.Scanner;

public class Q5_GetMax {
    static int max (int[][] matrix) {
        int max = Integer.MIN_VALUE;

        for (int[] i : matrix) {
            for (int j : i) {
                if (j > max) max = j;
            }
        }

        return max;
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

        System.out.println(max(arr));
    }
}
