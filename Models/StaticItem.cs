using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParserPages.Models
{
    public class StaticItem
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int StaticItemId { get; set; }
        public string Word { get; set; }
        public int Frequency { get; set; }
        
        public string PageAddress { get; set; }

    }
}
