using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FamilyApp.Models
{
    public class Family
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string Origin { get; set; }
        public virtual List<Member> Members { get; set; }
    }
}