/* Assignment 5 (100 marks in total; 5% of the final score of this course)
 *
 * Question 5 (20 marks)
 *
 * Write a java program to convert Roman numbers to integer.
 * Roman numerals are represented by seven different symbols:
 * I, V, X, L, C, D and M
 *
 * Symbol   Value
 *   I        1
 *   V        5
 *   X        10
 *   L        50
 *   C        100
 *   D        500
 *   M        1000
 *
 * For example, 2 is written as II in Roman numeral, just two one's added together.
 * 12 is written as XII, which is simply X + II.
 * The number 27 is written as XXVII, which is XX + V + II.
 *
 * Roman numerals are usually written largest to smallest from left to right.
 * However, the numeral for four is not IIII. Instead, the number four is written
 * as IV. Because the one is before the five we subtract it making four.
 * The same principle applies to the number nine, which is written as IX.
 * There are six instances where subtraction is used:
 *  I can be placed before V (5) and X (10) to make 4 and 9.
 *  X can be placed before L (50) and C (100) to make 40 and 90.
 *  C can be placed before D (500) and M (1000) to make 400 and 900.
 *
 * Input: Roman number (user input, string type)
 * Output: print out corresponding integer
 *
 * Example: if the user enters 'LVIII', the program should output 'LVIII -> 58'
 *
 */

import java.util.Scanner;
public class Q5_Roman2Integer {

    static int parseRomanNumeral(String numeral) {
        // this implementation will use a big ol switch statement
        // is there a better way to do this? almost certainly
        // BUT this isnt an algorithms class so it doesnt *need* to be the most efficient

        // the premise here is that for each character, we will check if its one of the characters capable of subtracting
        // if it is, we will keep track of it in the ints defined below
        // once we get to one of the characters thats able to be subtracted from we will check if theres been a subtraction
        // character already
        // if there has been one, we'll add the subtracted number to our total, otherwise we'll just add the regular number
        // if we added a subtracted number we will also reset the count for that subtraction character
        // finally after we have looped through all the characters we will multiply the subtraction character count
        // by their value and add them to the total

        int num = 0;
        int previousI = 0;
        int previousX = 0;
        int previousC = 0;
        for (char i : numeral.toCharArray()) {
            switch (i) {
                case 'I': // I is a subtraction character, so we dont add it right away
                    previousI++;
                    break;
                case 'X':
                    // X can be subtracted from, but is also a subtraction character. we need to check if there have been
                    // any Is which can subtract from X before we increment the X counter
                    if (previousI > 0) {
                        num += 9;
                        previousI = 0;
                    } else {
                        previousX++;
                    }
                    break;
                case 'C':
                    if (previousX > 0 ) {
                        num += 90;
                        previousX = 0;
                    } else {
                        previousC++;
                    }
                    break;

                case 'V':
                    // V is not a subtraction character
                    // the only necessary actions are to add 5 if there hasnt previously been an I or add 4 if there has
                    if (previousI > 0) {
                        num += 4;
                        previousI = 0;
                    } else {
                        num += 5;
                    }
                    break;

                case 'L':
                    if (previousX > 0) {
                        num += 40;
                        previousX = 0;
                    } else {
                        num += 50;
                    }
                    break;

                case 'D':
                    if (previousC > 0) {
                        num += 400;
                        previousC = 0;
                    } else {
                        num += 500;
                    }
                    break;

                case 'M':
                    if (previousC > 0) {
                        num += 900;
                        previousC = 0;
                    } else {
                        num += 1000;
                    }
                    break;
            }
        }

        num += previousI;
        num += previousX*10;
        num += previousC*100;

        return num;
    }

    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        System.out.println("Input roman numeral");

        String numeral = sc.nextLine();

        System.out.println(parseRomanNumeral(numeral));
    }
}
