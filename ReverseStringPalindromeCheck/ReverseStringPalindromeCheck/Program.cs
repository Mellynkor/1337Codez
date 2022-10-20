// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input a string please");
string S = Console.ReadLine();
string iS = "";
for (int i = S.Length; i > 0; i--)
{
    iS += S[i - 1];

}
Console.WriteLine(iS);
if (iS.ToLower().Equals(S.ToLower()))
{
    Console.WriteLine("The input string was a palindrome");
}
else
{
    Console.WriteLine("The input string was not a palindrome");
}
Console.ReadKey();