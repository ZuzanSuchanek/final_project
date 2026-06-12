public class Quiz
{
    public string Title { get; set; }

    public Quiz(string title)
    {
        Title = title;
    }

    public void Start(Player player, List<Question> questions)
    {
        Console.WriteLine($"Vítej v kvízu: {Title}");
        Console.WriteLine($"Hráč: {player.Name}\n");

        foreach (Question question in questions)
        {
            question.Display();

            Console.Write("Tvoje odpověď: ");
            string answer = Console.ReadLine() ?? "";

            if (question.CheckAnswer(answer))
            {
                Console.WriteLine($"Správně! +{question.Points} bodů\n");
                player.AddPoints(question.Points);
            }
            else
            {
                Console.WriteLine("Špatně!\n");
            }
        }

        Console.WriteLine($"Konec! {player.Name} získal {player.Score} bodů.");
    }
}