/* Assignment 1 (100 marks in total; 5% of the final score of this course) 
 * 
 * Question 4 (20 marks)
 * 
 * Write a Java program to print the area and perimeter of a circle.
 * 
 * INPUT: radius input by a user.
 * OUTPUT: the area and the perimeter of the circle defined by the radius. All results must use two significant digits after decimal point.
 * 
 * Hint: you may use java.util.Scanner to take user input real valued radius.
 * 
 */

import java.util.Scanner;

public class Q4_AreaOfCircle {
	public static void main(String[] args) {
		// init scanner
		Scanner scan = new Scanner(System.in);

		// get radius
		double r = scan.nextDouble();

		// calculations
		double perimeter = 2*Math.PI*r;
		double radius = Math.PI*Math.pow(r, 2);

		// output our stuff
		System.out.printf("Perimeter: %.2f\tRadius:%.2f", perimeter, radius);
	}
}
