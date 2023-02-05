using AspApp.api.DB;
using AspApp.api.Models.Domain;

namespace AspApp.api.Repositories
{
    public class SegmentRepository : ISegmentRepository
    {
        private readonly IsraelTrailContext israelTrailContext;
        public SegmentRepository(IsraelTrailContext israelTrailContext)
        {
            this.israelTrailContext = israelTrailContext;
        }
        public IEnumerable<Segment> GetAll()
        {
            return israelTrailContext.Segment.ToList();
        }
    }
}
