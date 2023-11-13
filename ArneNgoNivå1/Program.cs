namespace ArneNgoNivå1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team.teams = new()
            {
                new Star("Arne", 19, "King of basketball"),
                new Player("Arman", 21),
                new Star("Tomas", 11, "Badass leader"),
                new Player("Madeleine", 32)

            };


            Team.PrintTeam();


        }
    }
}