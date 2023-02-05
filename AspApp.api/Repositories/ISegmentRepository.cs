using AspApp.api.Models.Domain;

namespace AspApp.api.Repositories
{
    public interface ISegmentRepository
    {
        IEnumerable<Segment> GetAll();
    }
}
