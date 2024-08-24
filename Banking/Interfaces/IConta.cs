using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Interfaces
{
    public interface IConta
    {
        public string Name { get; set; }
        public int Id {  get; set; }
        public decimal Saldo { get; set; }


    }
}
