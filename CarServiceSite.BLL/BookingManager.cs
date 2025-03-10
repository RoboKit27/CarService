using AutoMapper;
using CarServiceSite.BLL.Mappers;
using CarServiceSite.Core.OutputModels;
using CarServiceSite.DAL;

namespace CarServiceSite.BLL
{
    public class BookingManager
    {
        private BookingRepository _bookingRepository;
        private Mapper _mapper;

        public BookingManager()
        {
            _bookingRepository = new BookingRepository();
            var configuration = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddProfile(new BookingMapperProfile());
                });
            _mapper = new Mapper(configuration);
        }

        public List<WorkOutputModel> GetAllWorks()
        {
            var dtos = _bookingRepository.GetAllWorks();
            var outputModels = _mapper.Map<List<WorkOutputModel>>(dtos);
            return outputModels;
        }
    }
}
