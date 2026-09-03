using Hl.Core.Common;
using Hl.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hl.Core.Entities
{
    public class Appointment:BaseEntities
    {
        public int PatientId { get; set; }
        public virtual AppUser AppUser { get; set; } = null!;
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; } = null!;
        public DateTime AppointmentDate { get; set; }
        public AppointmentStatus Status { get; set; } = AppointmentStatus.Scheduled;
    }
}
