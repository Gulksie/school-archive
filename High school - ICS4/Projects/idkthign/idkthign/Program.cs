using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            String input = Console.ReadLine();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine();
                Console.WriteLine("Select an option, 1-4, 0 to exit");
                String option = Console.ReadLine();
                Console.WriteLine();

                switch (option)
                {
                    case "0":
                        loop = false;
                        break;
                    case "1":
                        //find chars
                        Console.WriteLine("what char/string");
                        string find = Console.ReadLine();
                        Console.WriteLine();

                        //this is disgusting
                        int count = 0;
                        int found = 0;
                        int firstIndex = -5;
                        foreach (char i in input) {
                            if (i.ToString() == find.Substring(count))
                            {
                                found++;
                            }
                            else
                            {
                                found = 0;
                            }

                            if (found == find.Length)
                            {
                                firstIndex = count - find.Length;
                                break;
                            }
                        }

                        if (firstIndex == -5)
                            Console.WriteLine("String not found");
                        else
                            Console.WriteLine(find + " is first located at position " + firstIndex);
                        break;

                    case "2":
                        //replace chars
                        Console.WriteLine("what do you want replaced?");
                        string replace = Console.ReadLine();
                        Console.WriteLine("replace with?");
                        string substitute = Console.ReadLine();
                        Console.WriteLine();

                        string updated = input.Replace(replace, substitute);
                        Console.WriteLine(input + " has been replaced with: " + updated);
                        break;

                    case "3":
                        //count words, seperated by spaces ' '
                        string[] seperated = input.Split(' ');

                        Console.WriteLine("Words = " + seperated.Length);
                        break;

                    case "4":
                        //give "stats", constanants , vowels, percentages
                        int vowels = 0;
                        int constanants = 0;
                        int special = 0;

                        foreach (char i in input)
                        {
                            if ("aeiouy".Contains(i))
                            {
                                vowels++;
                            }
                            else if (",?!'.:;\"\\|`~<>!@#$%^&*()_-+={[}]".Contains(i))
                            {
                                special++;
                            } else if (i != ' ') { //dk if space is special char so we gonna ignore it
                                constanants++;
                            }

                            int lenWOSpace = input.Replace(" ", "").Length;

                            double percentVowelSp = Math.Round((double)vowels / input.Length * 100, 2);
                            double percentVowel = Math.Round((double)vowels / lenWOSpace * 100, 2);

                            double percentConstSp = Math.Round((double)constanants / input.Length * 100, 2);
                            double percentConst = Math.Round((double)constanants / lenWOSpace * 100, 2);

                            double percentSpecialSp = Math.Round((double)special / input.Length * 100, 2);
                            double percentSpecial = Math.Round((double)special / lenWOSpace * 100, 2);

                            Console.WriteLine("Vowels: %total=" + percentVowelSp + " %total(no space)=" + percentVowel);
                            Console.WriteLine("Constanats: %total=" + percentConstSp + " %total(no space)=" + percentConst);
                            Console.WriteLine("Special: %total=" + percentSpecialSp + " %total(no space)=" + percentSpecial);
                        }
                        break;
                }
            }
        }
    }
}
