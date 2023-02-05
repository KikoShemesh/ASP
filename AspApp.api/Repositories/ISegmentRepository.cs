using AspApp.api.Models.Domain;

namespace AspApp.api.Repositories
{
    public interface ISegmentRepository
    {
        Task<IEnumerable<Segment>> GetAllAsync();
    }
}
