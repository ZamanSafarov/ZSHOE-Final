using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Models.Entities.ViewModels
{
    public class AboutViewModel
    {
        public ICollection<AboutBrand>AboutBrands { get; set; }
        public AboutInfo AboutInfos { get; set; }
        public ICollection<AboutTeam> AboutTeam { get; set; }
        public AboutWhoWeAre AboutWhoWeAre { get; set; }
        public ICollection<AboutCustomer> AboutCustomers { get; set; }
    }
}
