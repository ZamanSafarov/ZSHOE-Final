﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities
{
    public class Category : BaseEntity
    {
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Category> Children { get; set; }
        public string Name { get; set; }

    }
}
