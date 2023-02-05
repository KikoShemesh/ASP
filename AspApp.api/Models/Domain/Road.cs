namespace AspApp.api.Models.Domain
{
    public class Road
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Lengh { get; set; }
        public Guid TripId { get; set; }
        public Guid DifficaltyId { get; set; }
        public Segment Segment { get; set; }
        public Difficulty Difficalty { get; set; }
    }
}
