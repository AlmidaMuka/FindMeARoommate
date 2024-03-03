using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Entities
{
    
    public  class Dormitory
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string Code { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
    }
}
