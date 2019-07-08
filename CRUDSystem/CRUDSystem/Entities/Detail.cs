using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CRUDSystem.Entities
{
    public partial class Detail
    {
        public int ID { get; set; }

        public String FName { get; set; }

        public String LName { get; set; }

        public int Age { get; set; }

        public String Address { get; set; }

        public DateTime DOB { get; set; }

    }
}
