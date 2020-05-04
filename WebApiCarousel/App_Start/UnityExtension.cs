
using Carousel.BusinessLogicData.CarouselBusinessLogic;
using Carousel.DataAccess.Interfaces;
using Carousel.DataAccess.Repositiories;
using Unity;
using Unity.Extension;

namespace Carousel.BusinessLogic
{
    public class UnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<ICarouselRepository,CarouselRepository>();
            Container.RegisterType<ICarouselRepository, CarouselBL>();
        }
    }
}
