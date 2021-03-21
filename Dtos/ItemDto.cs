using System;

namespace Catalog.Dtos
{
    public class ItemDto
    {       
        public Guid Id { get; init; } //can only set when intialized
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }    
}