using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities
{
    public class AboutInfo : BaseEntity
    {
        public string ImagePath { get; set; }
        public string OurVision { get; set; }
        public string OurMission { get; set; }
        public string Slug { get; set; }


    }
}
