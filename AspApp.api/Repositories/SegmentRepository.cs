using AspApp.api.DB;
using AspApp.api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspApp.api.Repositories
{
    public class SegmentRepository : ISegmentRepository
    {
        private readonly IsraelTrailContext israelTrailContext;
        public SegmentRepository(IsraelTrailContext israelTrailContext)
        {
            this.israelTrailContext = israelTrailContext;
        }
        public async Task<IEnumerable<Segment>> GetAllAsync()
        {
            return await israelTrailContext.Segment.ToListAsync();
        }
    }
}
