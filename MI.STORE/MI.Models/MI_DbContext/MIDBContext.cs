using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MI.Models.MI_DbContext
{
    public class MIDBContext : DbContext
    {
        public MIDBContext():base("MIDBContext") { }
    }
    
}
