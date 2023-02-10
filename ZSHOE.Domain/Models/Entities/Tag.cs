using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;

namespace ZSHOE.Domain.Models.Entities
{
    public class Tag : BaseEntity
    {
        [Required]
        public string Text { get; set; }

        public virtual ICollection<BlogPostTagItem> TagCloud { get; set; }
    }
}
