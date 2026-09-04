using Hl.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hl.Core.Entities
{
    public class Department:BaseEntities
    {
        public string Name { get; set; } = string.Empty;

        public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
    }
}
