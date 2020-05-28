using System;
using System.Collections.Generic;

namespace Cw12.Models
{
    public partial class Uprawnienia
    {
        public Uprawnienia()
        {
            SRola = new HashSet<SRola>();
        }

        public int IdRola { get; set; }
        public string Rola { get; set; }

        public virtual ICollection<SRola> SRola { get; set; }
    }
}
