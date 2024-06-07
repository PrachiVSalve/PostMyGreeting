using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Table("Solution")]
     public class Solution
    {
        [Key]
        public Int64 SolutionId {  get; set; }
        public DateTime SolutionDate { get; set; }  
        public string SolutionDescription{ get; set; }
        [ForeignKey("Complaint")]
        public Int64 ComplaintId { get; set; }
        public virtual Complaint Complaint { get; set; }    
    }
}
