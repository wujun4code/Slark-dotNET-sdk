using System;
namespace ConsoleApp
{
    public class Echo
    {
        public Echo(string input)
        {
            Text = input;
        }

        public string Text { get; set; }
        public void Print()
        {
            Console.WriteLine(Text);
        }
    }
}
