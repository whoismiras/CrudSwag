using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace CrudSwag.Models
{
    public class Interaction
    {
      

        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int ProjectId { get; set; }
        public int TaskId { get; set; }


    }
}
