using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Word myword = new Word("Bubba");
        myword.Display();
        myword.Hide();
        Console.WriteLine();
        myword.Display();

        Scripture myscripture = new  Scripture("Moses", 1, [39], "Behold, this is my work and my glory to bring to pass the immortality and eternal life of man");
        Console.Clear();
        myscripture.ShowScripture();
        

        
    }
}