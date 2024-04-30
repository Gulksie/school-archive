/* Assignment 11 (100 marks in total; 5% of the final score of this course)
 *
 * Question 2 (50 marks in total)
    Use the Q1_TreeMapByBST to implement a WordCounter to count words in documents.
    You cannot use JCF provided map.
 */

import java.io.*;
import java.util.ArrayList;
import java.util.Locale;

public class Q2_WordCounter {
    // use the m_treemap as the data structure for word counting
    Q1_TreeMapByBST m_treemap = new Q1_TreeMapByBST();

    // Question 2.1 (15 marks) implement buildTreeMap() to build a treemap that stores
    // the words and word frequencies of a document into m_treemap.
    // "filename" is the path to the file. Please use the "JingleBell.txt" under folder "data".
    // You can ONLY modify the body of this method including the return statement.
    public void buildTreeMap(String filename) throws IOException {
        Reader r = new FileReader(filename);

        BufferedReader br = new BufferedReader(r);

        StringBuilder fullFile = new StringBuilder();
        for (String lineString = br.readLine(); lineString != null; lineString = br.readLine()) {
            fullFile.append(lineString).append(" ");
        }

        // remove (certain) punctuation and numbers from words and force lowercase
        String fileAsString = fullFile.toString();
        fileAsString = fileAsString.replaceAll("[-_]", " "); // dash and underscore becomes space
        // everything else (expect apostrophe) i kill
        fileAsString = fileAsString.replaceAll("[\\d\\p{Punct}&&[^']]", "").toLowerCase();

        for (String s : fileAsString.split(" ")) {
            if (s.equals("")) continue; // empty strings could pop up if a "word" consisted of only punctuation/numbers

            int instances = m_treemap.get(s);
            // get outputs -1 if the word isnt in the tree, otherwise it outputs the frequency of the word
            if (instances == -1) {
                m_treemap.put(s, 1);
            } else {
                m_treemap.put(s, instances + 1);
            }
        }
    }

    // Question 2.2 (15 marks) print all the counted words in the document in alphabetical order.
    // You can ONLY modify the body of this method including the return statement.
    public void printWordsAlphabetical(){
        ArrayList<String> al =  m_treemap.getKeysInAlphabeticalOrder();

        for (String i : al) {
            System.out.println(i);
        }

        System.out.println();
    }

    // Question 2.3 (15 marks) write an output file named "Output.txt" under folder "data"
    // The output of will consist of two lists.
    // Each list contains all the words from the file, along with the number of times
    // that the word occurred.
    // One list is sorted alphabetically.
    // The other list is sorted according to the number of occurrences, with the most
    // common words (i.e., a word with a larger frequency or count is said to be more common)
    // at the top and the least common at the bottom.
    // IMPORTANT: the output format is given in the file "Output_Example.txt" under folder "data".
    // Input parameter "filename" is the path to the output file.
    public void outputResult(String filename) throws IOException{
        outputResult(filename, false);
    }

    public void outputResult(String filename, boolean print) throws IOException {
        ArrayList<String> sortedAlphabetically = m_treemap.getKeysInAlphabeticalOrder();

        StringBuilder out1 = new StringBuilder("List of words in alphabetical order (with counts in parentheses):\n\n");
        for (String i : sortedAlphabetically) {
            out1.append("\t").append(i).append(" (").append(m_treemap.get(i)).append(")\n");
        }

        String[] keys = new String[sortedAlphabetically.size()];
        keys = sortedAlphabetically.toArray(keys);

        // BUBBLE SORT, EVERYONE'S FAVOURITE
        // :)))))))))))))))
        boolean swapped;
        do {
            swapped = false;
            for (int i = 0; i < keys.length-1; i++) {
                if (m_treemap.get(keys[i]) < m_treemap.get(keys[i+1])) {
                    String tmp = keys[i];
                    keys[i] = keys[i+1];
                    keys[i+1] = tmp;

                    swapped = true;
                }
            }
        } while (swapped);

        StringBuilder out2 = new StringBuilder("List of words by frequency of occurrence:\n\n");
        for (String i : keys) {
            out2.append("\t").append(i).append(" (").append(m_treemap.get(i)).append(")\n");
        }

        String toOut = m_treemap.size() + " words found in file:\n\n" +  out1 + "\n" + out2;
        if (print) {
            System.out.println(toOut);
        }

        // output to file
        FileOutputStream fos = new FileOutputStream(filename);
        Writer writer = new OutputStreamWriter(fos);

        writer.write(toOut);
        writer.close();
    }

    // Question 2.4 (5 marks) call each of the above methods in the main() method to
    // successfully count the words and produce expected outputs.
    public static void main(String[] args){
        Q2_WordCounter wordCounter = new Q2_WordCounter();

        // please use the full path to the file if this does not work by default
        // file systems can be messy and intellij certainly doesnt help with that
        String prePath = "src\\data\\";
        try {
            System.out.println("Building treemap...");
            wordCounter.buildTreeMap(prePath + "JingleBell.txt");

            System.out.println("Done!\nPrinting words in alphabetical order\n");
            wordCounter.printWordsAlphabetical();

            System.out.println("Done!\nOutputting Results...\n");
            wordCounter.outputResult(prePath + "output.txt");
            System.out.println("Done!");
        } catch (IOException ex) {
            ex.printStackTrace();
            System.out.println("IOException, try using full file path?");
        }
    }
}
