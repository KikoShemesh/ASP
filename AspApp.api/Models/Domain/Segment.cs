namespace AspApp.api.Models.Domain
{
    public class Segment
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public double Area { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        public IEnumerable<Road> Paths { get; set; } //One segment can get multiple paths 
    }
}
