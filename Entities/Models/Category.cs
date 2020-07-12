using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Category : BaseEntity, IEntity
    {
        public string Name { get; set; }

    }
}
