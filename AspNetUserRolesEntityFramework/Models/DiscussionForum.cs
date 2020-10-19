using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Wk10Lab7:
using System.ComponentModel.DataAnnotations;

namespace AspNetUserRolesEntityFramework.Models 
{
    public class DiscussionForum
    {
        public int Id { get; set; }

        [Display(Name = "Post Date")]
        public DateTime PostDate { get; set; }

        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Topic Title")]
        public string TopicTitle { get; set; }

        [Required]
        [Display(Name = "Message Content")]
        public string MessageContent { get; set; }

        public int Like { get; set; }

        public bool canIncreaseLike { get; set; }
    }
}
