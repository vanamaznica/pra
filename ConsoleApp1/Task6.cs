Console.Write("Enter a sentence: ");
string s = Console.ReadLine();

string[] words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine("Number of words: " + words.Length);