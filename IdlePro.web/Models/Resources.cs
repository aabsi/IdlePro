namespace IdlePro.web.Models
{
    public class Resources
    {
        public int gold { get; set; }
        public int wood { get; set; }
        public int stone { get; set; }
        public int food { get; set; }
        public int people { get; set; }

        public Resources(int gold, int wood, int stone, int food, int people)
        {
            this.gold = gold;
            this.wood = wood;
            this.stone = stone;
            this.food = food;
            this.people = people;
        }
    }
}
