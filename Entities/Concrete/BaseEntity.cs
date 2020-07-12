﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            IsDeleted = false;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
