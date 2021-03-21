using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Dtos;
using Catalog.Entites;
using Catalog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace  Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        //private readonly InMemItemsRepository repository;
        private readonly IItemsRepository repository;
        
        public ItemsController(IItemsRepository repository)
        {
            this.repository = repository;
            //repository = new InMemItemsRepository();
        }

        // GET /items
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            var items = repository.GetItems().Select(item => new ItemDto{   //! can use the extension method too
                Id = item.Id,
                Name = item.Name,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            });

            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id)
        {
            var item = repository.GetItem(id);
            if (item is null)
            {
                return NotFound();
            }
            
            return item.AsDto(); //! Using extension method 
        }

        
    }
    
}