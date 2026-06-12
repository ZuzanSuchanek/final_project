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
}