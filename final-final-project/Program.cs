Console.Write("Zadej jméno: ");
string name = Console.ReadLine();
Player player = new Player(name);

List<Question> otazky = new List<Question>
{
    new MultipleChoiceQuestion("Jaký typ má Charmander?",
        new[] { "Voda", "Tráva", "Oheň", "Elektřina" }, "C", 10),

    new MultipleChoiceQuestion("Kolik Pokémonů je v původní Kanto Pokédex?",
        new[] { "100", "151", "251", "386" }, "B", 10),

    new MultipleChoiceQuestion("Kdo je evoluce Pikachu?",
        new[] { "Raichu", "Pichu", "Jolteon", "Electabuzz" }, "A", 10),
};

Quiz quiz = new Quiz("Pokémon Kvíz");
quiz.Start(player, otazky);