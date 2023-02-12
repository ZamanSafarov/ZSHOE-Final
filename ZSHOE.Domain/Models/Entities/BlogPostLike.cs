using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSHOE.Domain.AppCode.Infrastructure;
using ZSHOE.Domain.Models.Entities.Membership;

namespace ZSHOE.Domain.Models.Entities
{
    public class BlogPostLike : BaseEntity
    {
        public int BlogPostId { get; set; }

        public virtual BlogPost BlogPost { get; set; }

        public ZSHOEUser CreatedByUser { get; set; }

        public int CreatedByUserId { get; set; }
    }
}
