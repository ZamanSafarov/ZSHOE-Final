using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities
{
    public class ContactInfo : BaseEntity
    {

        public string Location { get; set; }

        public string PhoneNumber { get; set; }

        public string CompanyEmail { get; set; }
    }
}
