namespace Foosinator.Models
{
    public class LeaderboardRow
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int Items { get; set; }
        public string ProfilePicture { get; set; }

        public int Points { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
    }
}