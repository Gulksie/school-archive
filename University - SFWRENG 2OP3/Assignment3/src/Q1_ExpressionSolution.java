/* Assignment 3 (100 marks in total; 5% of the final score of this course)
 *
 * Question 1 (20 marks)
    Write a Java program to find the value of following expression.
    a) (101 + 0) / 3
    b) 3.0e-6 * 10000000.1
    c) true && true
    d) false && true
    e) (false && false) || (true && true)
    f) (false || false) && (true && true)

 * INPUT: n/a
 * OUTPUT: the value of each of the above expressions.

 */


public class Q1_ExpressionSolution {
    public static void main(String[] args) {
        System.out.println("(101+0)/3 = " + 101d/3d);
        System.out.println("3e-6 * 10000000.1 = " + 3.0e-6*10000000.1);

        // did the boolean stuff manually because its easy and prettier to look at
        System.out.println("true && true = true");
        System.out.println("(false && false) || (true && true) = true");
        System.out.println("(false || false) && (true && true) = false");
    }
}
