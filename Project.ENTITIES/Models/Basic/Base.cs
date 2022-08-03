using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models.Basic
{
   public class Base
    {
        public DateTime create_time { get; set; }
        public DateTime update_time { get; set; }
        public bool isactive { get; set; }
    }
}
