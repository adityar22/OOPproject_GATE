using System;
namespace gate_prjct
{
    public class MDictionary
    {
        public void menu(){
            Console.WriteLine("\nWelcome to Gate's Dictionary");
            int option = 0;
            Console.WriteLine("\n1)Search word's means\n2)Serach word's synonim");
            while (option != -1)
            {
                Console.WriteLine("Input your choice: ");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            mean();
                            break;
                        case 2:
                            synonym();
                            break;
                        default:
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please input a valid option");
                }
            }
        }
        private void mean(){
            CDictionary dictionary = new CDictionary();
            Console.WriteLine("\nInput a word: ");
            dictionary.word = Console.ReadLine();

            dictionary.wordMean();
            Console.WriteLine(dictionary.mean);
        }
        private void synonym(){
            CDictionary dictionary = new CDictionary();
            Console.WriteLine("\nInput a word");
            dictionary.word = Console.ReadLine();

            dictionary.wordSynonim();
            for (int i =0; i < dictionary.synonym.Length; i++)
            {
                Console.WriteLine(dictionary.synonym[i]);
            }
        }
    }
}