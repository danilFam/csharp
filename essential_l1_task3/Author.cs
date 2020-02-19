using System;
namespace essential_l1_task3
{
    public class Author
    {
        string text;
        public string Text
        {
            set { text = value; }
            get { return text; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
