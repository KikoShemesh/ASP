using AspApp.api.Models.Domain;

namespace AspApp.api.Models.Dto
{
    public class Segment
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public double Area { get; set; }
        public double Long { get; set; }
        public long Population { get; set; }

        public IEnumerable<Road> Paths { get; set; }
    }
}
