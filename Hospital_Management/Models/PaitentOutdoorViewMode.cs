using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hospital_Management.Models
{
    public class PaitentOutdoorViewMode
    {
        public IEnumerable<OutDoorPatient> PatientMode { get; set; }
        public IEnumerable<OutDoor>OutDoorsMode  { get; set; }

    }
}