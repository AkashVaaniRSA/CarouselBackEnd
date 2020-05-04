using System;
using System.Collections.Generic;
using Carousel.Models.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carousel.BusinessLogic
{
    public interface IBL
    {
        List<CarouselModel> GetCarouselData();
        List<CarouselModel> InsertCarouselData(CarouselModel saveData);
        string UpdateCarouselData(int carouselId, CarouselModel value);
        string DeleteCarouselData(int carouselId);
    }
}
