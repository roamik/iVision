using iVision.MODELS.Abstract.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iVision.MODELS.Entities
{
    public class Patient : Person
    {
        [Key]
        public int PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int? MedicalCardId { get; set; }

        public virtual User User { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual MedicalCard MedicalCard { get; set; }
    }
}
