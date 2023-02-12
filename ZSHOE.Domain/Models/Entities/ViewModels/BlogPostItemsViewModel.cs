using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZSHOE.Domain.Models.Entities.ViewModels
{
    public class BlogPostItemsViewModel
    {
        public BlogPost BlogPost { get; set; }

        public ICollection<BlogPostLike> BlogPostLikes { get; set; }
    }
}
