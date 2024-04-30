/* Assignment 1 (100 marks in total; 5% of the final score of this course) 
 * 
 * Question 5 (20 marks)
 * 
 * Write a Java program to display the following pattern.
 * 
 * INPUT: n/a
 * OUTPUT: the following pattern of JAVA.
 
 
	   J    a   v     v  a                                                  
	   J   a a   v   v  a a                                                 
	J  J  aaaaa   V V  aaaaa                                                
	 JJ  a     a   V  a     a
 
 */

public class Q5_PrintPattern {
	public static void main(String[] args) {
        // there very well could be a "correct" way to do this, for the life of me I can't figure it out
        // instead we just print the pattern, \n is a line break and \t is a tab

        String toOut = "\t   J    a   v     v  a   \n\t   J   a a   v   v  a a  \n\tJ  J  aaaaa   V V  aaaaa \n\t JJ  a     a   V  a     a";
        System.out.println(toOut);
    }
}
