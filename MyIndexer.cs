using System;

namespace TestNamespace;

internal class Program
{
  
    static void Main()
    {
        /*Note note = new Note { Pitch = 10, duration = 100};
        Console.WriteLine($"note.Pitch :{note.Pitch}\nnote.duration : {note.duration}");*/

        Sentence s = new Sentence();
        /*for(int i =0; i < 10; i++)
        {
            Console.WriteLine(s[i]);
        }*/
        Console.WriteLine(s[1]);
        Console.WriteLine(s[^1]);
        foreach(string item in s[..2]) Console.Write(item+" ");


        Console.ReadKey();
    }
}

public class Note
{
    public int Pitch { get; init; }
    public int duration { get; init; }

   
}

public class Sentence
{
    string[] words = "The lazy quick brown fox jumps over the fence".Split();

    //indexer 
    public string this[int index]
    {
        get { return words[index];  }
        set { words[index] = value; }
    }
    public string this[Index index] => words[index];
    public string[] this[Range range] => words[range];
}
