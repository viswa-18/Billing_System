using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bill_book.BLL
{
    class productBLL
    {
        //Getters and Setters for Product module
        public int id { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public decimal weight { get; set; }
        public decimal rate { get; set; }
        public decimal qty { get; set; }
        public DateTime date { get; set; }
        public int added_by { get; set; }

    }
}
