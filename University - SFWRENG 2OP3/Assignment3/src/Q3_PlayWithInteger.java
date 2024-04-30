/* Assignment 3 (100 marks in total; 5% of the final score of this course)
 *
 * Question 3 (20 marks)
    Write a Java program that accepts an integer (n, 0 <= n <= 9) and computes the value of n+nn+nnn.

 * INPUT: a user input integer n
 * OUTPUT: the value of n+nn+nnn.

* Hint: For n=2, the output is 2+22+222=246
 */

import java.util.Scanner;

public class Q3_PlayWithInteger {
    public static void main(String[] args) {
        System.out.println(playWithInteger(2));
    }

    public static int playWithInteger (int n) {
        // the expected output is n+nn+nnn
        // conveniently this is equal to n*1+n*11+n*111
        if (n >= 0 && n <=9)  // conditions given at the beginning
            return n + n*11 + n*111;
        else
            return 0;
    }
}
