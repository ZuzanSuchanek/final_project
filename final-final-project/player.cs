public class Player
{
    public string Name { get; set; }
    public int Score { get; set; }
 
    public Player(string name)
    {
        Name = name;
        Score = 0;
    }
 
    public void AddPoints(int points)
    {
        Score += points;
    }
 
    public void ShowResult(int totalPoints)
    {
        Console.WriteLine($"\n=============================");
        Console.WriteLine($"  Hráč: {Name}");
        Console.WriteLine($"  Skóre: {Score} / {totalPoints} bodů");
 
        double percentage = (double)Score / totalPoints * 100;
        string rank;
        
        if (percentage >= 80)
        {
            rank = "diamond rank";
        }
        else if (percentage >= 60)
        {
            rank = "gold rank";
        }
        else if (percentage >= 40)
        {
            rank = "silver rank";
        }
        else
        {
            rank = "Bronze rank";
        }

 
        Console.WriteLine($"  Hodnocení: {rank}");
        Console.WriteLine($"=============================\n");
    }
}