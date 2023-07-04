using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nilsa.TinderAssistent
{
    public class IncomeMessage
    {
        public IncomeMessage() { }
        public UnreadMessage[] MESSAGES { get; set; }
        public string UNREAD_COUNT { get; set; }
        public string CONTACTER { get; set; }
    }
}
