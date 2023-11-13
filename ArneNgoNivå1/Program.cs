namespace ArneNgoNivå1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
            
                Team.teams = new()
                    {
                        new Star("Arne", 19, "King of basketball"),
                        new Player("Arman", 21),
                        new Star("Tomas", 11, "Badass leader"),
                        new Player("Madeleine", 32)
                    };

                Team.PrintTeam();

                Team.teams[2]++;
                Console.WriteLine(Team.teams[2]);
                Team.teams[2]--;
                Console.WriteLine(Team.teams[2]);


                bool checker = Team.teams[0] == Team.teams[1];
                bool checker1 = Team.teams[0] != Team.teams[1];

                Console.WriteLine(checker);
                Console.WriteLine(checker1);
            }
            catch (Exception e) 
            {
                Console.WriteLine("Nivå2 never fails from me" + e.Message);
            }


        }
    }
}