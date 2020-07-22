using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    public class Comment : BaseEntity, IEntity
    {
        public string Content { get; set; }
        public string Email { get; set; }
        public Article Article { get; set; }

        [ForeignKey("Article")]
        public int ArticleID { get; set; }






    }
}
