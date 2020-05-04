using System;
using System.Collections.Generic;
using Carousel.DataAccess.Repositiories;
using Carousel.Models.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carousel.BusinessLogic;
using Carousel.DataAccess.Interfaces;

namespace Carousel.BusinessLogicData.CarouselBusinessLogic
{

    public class CarouselBL:IBL
    {
        private readonly ICarouselRepository _CarouselRepository;
        public CarouselBL(ICarouselRepository CarouselRepository)
        {
            _CarouselRepository = CarouselRepository;
        }

        public List<CarouselModel> GetCarouselData()
        {
            return _CarouselRepository.GetCarouselData();
        }

        public List<CarouselModel> InsertCarouselData(CarouselModel saveData)
        {

            return _CarouselRepository.InsertCarouselData(saveData);
        }

        public string UpdateCarouselData(int carouselId, CarouselModel value)
        {
            return _CarouselRepository.UpdateCarouselData(carouselId, value);
        }

        public string DeleteCarouselData(int carouselId)
        {
            return _CarouselRepository.DeleteCarouselData(carouselId);
        }
    }
}



