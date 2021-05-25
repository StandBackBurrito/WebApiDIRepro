using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApiCs
{
    public interface IValueRepo
    {
        string GetValue(int id);
        IEnumerable<String> GetValues();
    }
}
