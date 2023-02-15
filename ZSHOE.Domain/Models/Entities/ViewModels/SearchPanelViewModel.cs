using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.Models.Entities;

namespace ZSHOE.Domain.Models.ViewModels
{
    public class SearchPanelViewModel
    {
        public ProductColor[] Colors { get; set; }
        public ProductSize[] Sizes { get; set; }
        public Brand[] Brands { get; set; }
        public Category[] Categories { get; set; }

        public int Min { get; set; }
        public int Max { get; set; }
    }
}
