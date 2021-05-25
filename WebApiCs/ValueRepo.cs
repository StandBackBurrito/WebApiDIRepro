using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCs
{
    public class ValueRepo : IValueRepo
    {
        public string GetValue(int id) => "value";

        public IEnumerable<String> GetValues() => new[] { "value1", "value2" };
    }
}
