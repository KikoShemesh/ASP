using AspApp.api.Models.Domain;
using AspApp.api.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AspApp.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SegmentsController : Controller
    {
        private readonly ISegmentRepository segmentRepository;
        private readonly IMapper mapper;

        public SegmentsController(ISegmentRepository segmentRepository, IMapper mapper)
        {
            this.segmentRepository = segmentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSegments()
        {
            var segments = await segmentRepository.GetAllAsync();
            var segmentsDto = mapper.Map<List<Models.Dto.Segment>>(segments);
            return Ok(segmentsDto);


            //var segment = new List<Segment>()
            //{
            //    new Segment()
            //    {
            //        Id = Guid.NewGuid(),
            //        Code = "HaShfela",
            //        Area = 555,
            //        Long = 30,
            //        Population = 300
            //    },
            //    new Segment()
            //    {
            //        Id = Guid.NewGuid(),
            //        Code = "Negev Desert",
            //        Area = 85.425,
            //        Long = 441.6,
            //        Population = 650
            //    }
            //};

            //Return the implimation of SegmentRepository becouse Dependency injection
            //Retrun DTO's
            //var segmentsDto = new List<Models.Dto.Segment>();
            //segments.ToList().ForEach(segments =>
            //{
            //    var segmentDto = new Models.Dto.Segment()
            //    {
            //        Id = segments.Id,
            //        Area = segments.Area,
            //        Code = segments.Code,
            //        Long = segments.Long,
            //        Paths = segments.Paths,
            //        Population = segments.Population,
            //    };
            //    segmentsDto.Add(segmentDto);
            //});
            //return Ok(segmentsDto);
        }
    }
}
