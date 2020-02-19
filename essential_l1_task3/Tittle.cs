using System;
namespace essential_l1_task3
{
    public class Tittle
    {
        string text;
        public string Text
        {
            set { text = value; }
            get { return text; }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
