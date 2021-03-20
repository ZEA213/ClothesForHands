using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsrtest.EF
{
    class AppData
    {
        public static Entities Context { get; } = new Entities();
    }
}