using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_DataAccess
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string  Details { get; set; }
        public int StockAvailable { get; set; }
    }
}
