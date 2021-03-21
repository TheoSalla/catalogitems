using System;

namespace Catalog.Entites
{
    //! Record Types - Use for immutable objects
    public record Item
    {
        public Guid Id { get; init; } //! can only set when intialized
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }


        
    }
    
}