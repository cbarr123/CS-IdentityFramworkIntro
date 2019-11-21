using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityIntro.Models
{
    public class Animals
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Species { get; set; }

        public string color { get; set; }
        public string ApplicationUserId { get; set; }

        [Display(Name= "Owner")]
        public virtual ApplicationUser ApplicationUser { get; set; }


    }
}
