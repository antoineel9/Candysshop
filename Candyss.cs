using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candysshop.Pages
{
    public class Candyss
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CandysId{ get; set; }
        public int Name{ get; set; }
        public int Type { get; set; }

        //foreign key Connects Manufacturer Table
        public int MID { get; set; }
        [ForeignKey("MID")]
        public  Manufacturer Manufacturer { get; set; }

        //foreign key connects to Store table
        public int StoreId { get; set; }
        [ForeignKey("StoreId)")]
        public Store Stores{ get; set; }

       
        
    }

 
    
    
}