using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sisystem.Models
{
    public class StudentDetail
    {
        [Key]
        public int studentId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        [Column(TypeName = "nvarchar(14)")]

        public string NationalId { get; set; }
        [Column(TypeName = "nvarchar(11)")]

        public string PhoneNumber { get; set; }

    }
}
