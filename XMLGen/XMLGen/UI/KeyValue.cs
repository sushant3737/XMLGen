using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGen.UI
{
    [Serializable]
    public class KeyValue
    {
        public string Key { get; set; }
        public string ValueType { get; set; }
        public object Value { get; set; }
    }
}
