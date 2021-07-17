using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rookie.Ecom.DataAccessor.Entities
{
    public class Category
    {
       
        public Guid CategoryId { get; set; }

      
        public string CategoryName { get; set; }

        public string Description { get; set; }

       
        public IList<Product> Products { get; set; }
    }
}
