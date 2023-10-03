using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class TaxRules
    {
        public int Id { get; set; }
        public int MinHourTime { get; set; }
        public int MinMinuteTime { get; set; }

        public int MaxHourTime { get; set; }
        public int MaxMinuteTime { get; set; }

        public int TaxAmount { get; set; }
    }
}
