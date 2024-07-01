namespace CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            string winner = "";
            int sum = 0;

            while (true)
            {
                if (player1[0] > player2[0])
                {
                    int curr = player1[0];
                    player1.RemoveAt(0);
                    player1.Add(curr);
                    player1.Add(player2[0]);
                    player2.RemoveAt(0);
                }
                else if (player2[0] > player1[0])
                {
                    int curr = player2[0];
                    player2.RemoveAt(0);
                    player2.Add(curr);
                    player2.Add(player1[0]);
                    player1.RemoveAt(0);
                }
                else
                {
                    player1.RemoveAt(0);
                    player2.RemoveAt(0);
                }

                if (player1.Count == 0)
                {
                    winner = "Second";
                    sum = player2.Sum();
                    break;
                }
                else if (player2.Count == 0)
                {
                    winner = "First";
                    sum = player1.Sum();
                    break;
                }
            }
            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}
