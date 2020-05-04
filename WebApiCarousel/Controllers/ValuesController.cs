using System;
using System.Collections.Generic;
using Carousel.BusinessLogicData.CarouselBusinessLogic;
using Carousel.Models.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Carousel.BusinessLogic;

namespace WebApiCarousel.Controllers
{
    [EnableCors("http://localhost:4200", "*", "GET,POST,PUT")]
    public class ValuesController : ApiController
    {
        private readonly IBL _BL;
        public ValuesController(IBL BL)
        {
            _BL = BL;
        }

        //CarouselBL bl = new CarouselBL();
        // GET api/values/5

        public IEnumerable<CarouselModel> Get()
        {
            return _BL.GetCarouselData();
        }

        // POST api/values
        public IEnumerable<CarouselModel> Post([FromBody]CarouselModel value)
        {
            return _BL.InsertCarouselData(value);

        }

        // PUT api/values/5
        public string Put(int carouselId, [FromBody]CarouselModel value)
        {
            return _BL.UpdateCarouselData(carouselId, value);
        }


        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}




