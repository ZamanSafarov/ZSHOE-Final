using ZSHOE.Domain.AppCode.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Models.Entities
{
    public class ContactPost : BaseEntity
    {
        [Required(ErrorMessage = "{0} bos buraxila bilmez")]
        public string Name { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "bos buraxila bilmez")]
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required(ErrorMessage = "bos buraxila bilmez")]
        public string Content { get; set; }

       

        public string Answer { get; set; }
        public string EmailAnswer { get; set; }

        public DateTime? AnswerDate { get; set; }
    }
}
