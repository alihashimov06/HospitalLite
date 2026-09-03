using System;
using System.Collections.Generic;
using System.Text;

namespace Hl.Core.Enum
{
    public enum AppointmentStatus
    {
        Scheduled = 1, //Gorus mueyyenlesdirilib
        Checked = 2, // Xesde xedexanaya gelib
        InExamination = 3, // Xesde muayine olunur
        LabPending = 4, // Xesdenin analizi gozlenir
        Completed = 5, // Muayine ve analizler tamamlanib
        Canceled = 6 // Ləğv edilib
    }
}
