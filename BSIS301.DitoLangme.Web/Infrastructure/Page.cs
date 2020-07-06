using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BSIS301.DitoLangme.Web.Infrastructure
{
    public class Page<T>
    {
        public List<T> Items { get; set; }

        public long QueryCount { get; set; }

        public long PageCount { get; set; }

        public long PageSize { get; set; }

        public long PageIndex { get; set; }
    }
}
