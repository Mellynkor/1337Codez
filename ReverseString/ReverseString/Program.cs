// See https://aka.ms/new-console-template for more information
string S = "Hello";
for (int i = S.Length; i > 0; i--)
{
    Console.Write(S[i-1]);
}
Console.ReadKey();