namespace HW_WebApplication_IntroductionToASP_NET.Model
{
    public class Product
    {
        public required int Id { get; set; }
        public required string Title { get; set; }

        public required string Description { get; set; }

        public required double Price{ get; set; }

        public required DateTime Date { get; set; }
    }
}
