using System;
namespace essential_l1_task3
{
    public class Content
    {
        string text;
        public string Text
        {
            set { text = value; }
            get { return text; }

        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
