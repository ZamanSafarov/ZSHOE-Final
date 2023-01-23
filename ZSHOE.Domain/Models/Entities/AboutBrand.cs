using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities
{
    public class AboutBrand:BaseEntity
    {
        public string Description { get; set; }
        public string Body { get; set; }

        public string ImagePath { get; set; }
    }
}
