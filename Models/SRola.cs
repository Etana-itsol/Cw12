using System;
using System.Collections.Generic;

namespace Cw12.Models
{
    public partial class SRola
    {
        public int RolaIdRola { get; set; }
        public string StudentIndexNumber { get; set; }

        public virtual Uprawnienia RolaIdRolaNavigation { get; set; }
        public virtual Student StudentIndexNumberNavigation { get; set; }
    }
}
