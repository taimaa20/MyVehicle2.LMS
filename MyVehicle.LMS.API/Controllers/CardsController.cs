using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyVehicle.LMS.CORE.Data;
using MyVehicle.LMS.CORE.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyVehicle.LMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardService cardService;
        public CardsController(ICardService cardService)
        {
            this.cardService = cardService;
        }
        [HttpDelete("delete")]

        public bool DeleteCards([FromBody] Cards cards)
        {
            return cardService.DeleteCards(cards);
        }
        [HttpGet]
        [Route("GetAllCards")]
        public List<Cards> GetAllCards()
        {
            return cardService.GetAllCards();
        }
        [HttpGet]
        [Route("GetCardById")]
        public Cards GetCardById(Cards cards)
        {
            return cardService.GetCardById(cards);
        }
        [HttpPost]
        public bool InsertCards([FromBody] Cards cards)
        {
            return cardService.InsertCards(cards);

        }
        [HttpPut]
        public bool UpdateCards([FromBody] Cards cards)
        {
            return cardService.UpdateCards(cards);
        }
    }
}
