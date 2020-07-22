using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Article : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int Hit { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public List<Comment> Comments { get; set; }


    }
}
