public class MultipleChoiceQuestion : Question
{
    public string[] Options { get; set; }
    private string _correctAnswer;
 
    public MultipleChoiceQuestion(string text, string[] options, string correctAnswer, int points)
        : base(text, points)
    {
        Options = options;
        _correctAnswer = correctAnswer.ToUpper();
    }
    
    public override bool CheckAnswer(string answer)
    {
        return answer.Trim().ToUpper() == _correctAnswer;
    }
 

    public override void Display()
    {
        base.Display();
 
        string[] labels = { "A", "B", "C", "D" };
        for (int i = 0; i < Options.Length; i++)
        {
            Console.WriteLine($"   {labels[i]}) {Options[i]}");
        }
    }
}

