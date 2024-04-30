/* Assignment 3 (100 marks in total; 5% of the final score of this course)
 *
 * Question 4 (20 marks)
    Write a Java program to print integer numbers between 1 to a user input integer n, which are divisible by 3, 5 and by both.

 * INPUT: a user input integer n
 * OUTPUT: all the integer numbers between 1 and n that are either divisible by 3 or by 5 or by both.

* Hint: For n=16, the output should be as follows.
    Divided by 3 -> 3, 6, 9, 12, 15.
    Divided by 5 -> 5, 10, 15.
    Divided by 3 and 5 -> 15.
 */

import java.util.Scanner;

public class Q4_FindNumbers {
    public static void main(String args[]) {
        findNumbers(16);
    }

    public static void findNumbers(int inital) {
        // i want to do this in a more fizzbuzz kind of way (think like adding onto a string, something like in pseudocode
        /*
        for 1<=i<=max {
            string toOut = ""
            if i%3==0{
                toOut += "Fizz"
            }
            if i%5==0{
                toOut+= "Buzz"
            }
            output(toOut)
        }
         */
        // which would work fine for fizzbuzz but i cant think of a way for it to work here
        // also intellij keeps bugging me to use stringbuilder so i decided to use it

        StringBuilder divBy3 = new StringBuilder("Divided by 3 -> ");
        StringBuilder divBy5 = new StringBuilder("Divided by 5 -> ");
        StringBuilder divBy3and5 = new StringBuilder("Divided by 3 and 5 -> ");
        for (int i = 1; i < inital; i++) {
            if (i%3==0)
                divBy3.append(i).append(", ");

            if (i%5==0)
                divBy5.append(i).append(", ");

            if (i%3==0&&i%5==0)
                divBy3and5.append(i).append(", ");
        }

        outFormattedString(divBy3);
        outFormattedString(divBy5);
        outFormattedString(divBy3and5);
    }

    public static void outFormattedString(StringBuilder in) {
        System.out.println(in.substring(0, in.length()-2) + ".");
    }
}
