/* Assignment 5 (100 marks in total; 5% of the final score of this course)
 *
 * Question 2 (20 marks)
 *
 * Use a "subroutine" and a lambda expression to implement function
 * f(x,y) = sqrt(x*x-y*y), both x and y are real numbers.
 * Meanwhile, your code can throw an IllegalException (custom run-time exception,
 * which can be one provided by Java) if the value of (x*x-y*y) is negative.
 *
 * INPUT: the value of x and y (user input)
 * OUTPUT: the value of sqrt(x*x-y*y)
 *
 * Note: output must be displayed using four significant digits after decimal point.
 *
 */

import java.util.Scanner;

public class Q2_LambdaExpression {
    public interface Fxy {
        double fxy(double x, double y);
    }

    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter first number");
        double num1 = sc.nextDouble();

        System.out.println("Enter second number");
        double num2 = sc.nextDouble();

        Fxy function = (x, y) -> {
            double calc1 = x*x-y*y;
            if (calc1 < 0) throw new IllegalArgumentException();

            return Math.sqrt(calc1);
        };

        try {
            System.out.printf("%.4f", function.fxy(num1, num2));
        } catch (IllegalArgumentException ex) {
            System.out.println("x^2-y^2 was negative and the function will produce an imaginary number.");
        }
    }
}
