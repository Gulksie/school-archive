/* Assignment 1 (100 marks in total; 5% of the final score of this course) 
 * 
 * Question 2 (20 marks)
 * 
 * Write a Java program to print the sum of two user input integer numbers.
 * 
 * INPUT: two user input integer numbers
 * OUTPUT: the sum of the two user input integer numbers
 * 
 * Hint1: you may use java.util.Scanner to take user input numbers.
 * 
 */

import java.util.Scanner;


public class Q2_SumTwoNumbers {
	public static void main(String[] args) {
		// init scanner
		Scanner scan = new Scanner(System.in);

		//get our two numbers and add em
		int num1 = scan.nextInt();
		int num2 = scan.nextInt();
		int sum = num1 + num2;

		// throw them back into the void that is sout
		System.out.println(sum);
	}
}
