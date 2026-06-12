
    public abstract class Question
    {
        public string Text { get; set; }
        public int Points { get; set; }
 
        public Question(string text, int points)
        {
            Text = text;
            Points = points;
        }
        
        public abstract bool CheckAnswer(string answer);
        
        public virtual void Display()
        {
            Console.WriteLine($"\n❓ {Text}");
        }
    }