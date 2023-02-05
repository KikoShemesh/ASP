using AutoMapper;

namespace AspApp.api.Profiles
{
    public class SegmentProfile : Profile
    {
        public SegmentProfile()
        {
            CreateMap<Models.Domain.Segment, Models.Dto.Segment>();
        }
    }
}
