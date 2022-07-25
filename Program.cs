string []somewords = new string [7] {"шла", "саша", "по", "шоссе", "и", "сосала", "сушку"};
string []shortwords = new string [somewords.Length];

void ThreeLetters (string[]somewords, string[] shortwords)
{
    int count = 0;
    for (int i = 0; i < somewords.Length; i++)
    {
        if(somewords[i].Length <= 3)
        {
            shortwords[count] = somewords[i];
            count++;
        }
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

ThreeLetters (somewords, shortwords);
PrintArray (shortwords);