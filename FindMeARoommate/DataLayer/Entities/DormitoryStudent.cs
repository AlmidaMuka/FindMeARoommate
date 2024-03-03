using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMeARoommate.DataLayer.Entities
{
    public class DormitoryStudent
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Student")]  //must match
        public int StudentID { get; set; }
        public Student Student { get; set; } //here name of object must match with foreign key anotation name (emrin brenda kllapave te foreign key)
        [ForeignKey("Dormitory")]
        public int DormitoryID { get; set; }
        public Dormitory Dormitory { get; set; }
    }
}
