/* Assignment 3 (100 marks in total; 5% of the final score of this course)
 *
 * Question 2 (20 marks)
    Write a Java program to convert a decimal number (i.e., int value) to octal number.
    Please DO NOT use any Java provided subroutines or any third party subroutines to do the conversion.
    You should write your own code to convert a decimal number to octal number.

    Decimal number: The decimal numeral system is the standard system for denoting integer and non-integer numbers. It is also called base-ten positional numeral system.
    Octal number: The octal numeral system is the base-8 number system, and uses the digits 0 to 7.


 * INPUT: a user input decimal number x
 * OUTPUT: an octal number y converted from x

* Hint: For a decimal number x=1256, the corresponding octal number is y=2350.
 */

import java.util.Scanner;

public class Q2_Decimal2Octal {
    public static void main(String args[])
    {
        Scanner sc = new Scanner(System.in);
        System.out.printf("Enter an integer to convert to octal:\t");
        int decimal = sc.nextInt();

        System.out.println(decimalToOctal(decimal));
    }

    public static String decimalToOctal(int decimal) {
        // simple algorithm for changing from decimal, you could change to any base you wanted < 10 by changing the value of base
        int base = 8;
        StringBuilder octal = new StringBuilder();

        // when dividing by 8, the remainder will be the new digit and the quotient will be what we work with next
        do {
            octal.insert(0,decimal % base);  // set the digit at position 0 to be the remainder
            decimal /=base;  // new quotient is what we will work with next round
        } while(decimal>0);

        return octal.toString();
    }
}
