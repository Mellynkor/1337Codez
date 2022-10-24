// See https://aka.ms/new-console-template for more information
/*
 * Ask the user for their input string
 */
Console.WriteLine("Input a string please");
string S = Console.ReadLine();
//

//Create two arrays to hold the normal delimited words, and the inverted words.
string[] words = S.Split(' ', ',', '"', '+', '.', '{', '}', '[', ']', '/', '\'');
string[] invertedWords = new string[words.Count()];

//Create two variables to hold the string to be reversed, and the inverted version of the string
var stringReverse = "";
var invertedString = "";


//If the input string contains spaces (assumes more than one word in string)
if (S.Contains(' '))
{
    Console.WriteLine("Here are the list of words delimited from the string input");

    //Loop through the words until we hit the end of the input
    for (int i = 0; i < words.Count(); i++)
    {
        Console.WriteLine("---------------------");
        Console.WriteLine(words[i]);

        stringReverse = words[i];
        for (int k = stringReverse.Length; k != 0; k--)
        {
            invertedString += stringReverse[k - 1]; //Inversely add the string characters to the inverted string
        }
        invertedWords[i] = invertedString;
        invertedString = "";
        Console.WriteLine(invertedWords[i]);
        Console.WriteLine("---------------------");

        if (words[i].ToLower().Equals(invertedWords[i].ToLower()))
        {
            Console.WriteLine($"Word {i} \"{words[i]}\" is palindromic");
        }
        else
        {
            Console.WriteLine($"Word {i} \"{words[i]}\" is not palindromic");
        }
    }
    Console.ReadLine();
}
Console.WriteLine();
Console.ReadKey();