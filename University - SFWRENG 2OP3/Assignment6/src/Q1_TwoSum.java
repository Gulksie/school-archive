/* Assignment 6 (100 marks in total; 5% of the final score of this course)
 *
 * Question 1 (20 marks)
 *
 * Write a subroutine, user input an 1D array of integers and an integer target,
 * return indices of the two numbers such that they add up to target.
 *
 * INPUT: user input array and target
 * OUTPUT: the indices of the two numbers such that they add up to target.
 *
 * The array and target are parameters to the subroutine.
 * User can get hint to input array and target number, respectively.
 *
 * Keep the input format in the example and make your code user-friendly.
 *
 * Example:
 * INPUT: [2,7,11,15], 9
 * OUTPUT: [0,1]
 *
 */

import java.util.Scanner;

public class Q1_TwoSum {
    static int[] twoSum(int[] arr, int target) {
        // brute force
        for (int i = 0; i < arr.length; i++) {
            for (int j = i+1; j < arr.length; j++) {
                if (arr[i]+arr[j] == target) {
                    return new int[] {i, j};
                }
            }
        }

        return new int[] {-1, -1};
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter numbers in array seperated by spaces, then press enter when done");
        String rawArr = sc.nextLine();
        String[] splitArr = rawArr.split(" ");
        int[] arr = new int[splitArr.length];

        for (int i = 0; i < splitArr.length; i++) {
            arr[i] = Integer.parseInt(splitArr[i]);
        }

        System.out.println("\nEnter the target number");
        int N = sc.nextInt();

        int[] indexes = twoSum(arr, N);
        if (indexes[0] == -1) { // something has gone horribly wrong
            System.out.println("We weren't able to find a combination to match your target");
        } else {
            System.out.printf("Indexes are %d and %d%n", indexes[0], indexes[1]);
        }
    }

}
