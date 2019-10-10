using iVision.MODELS.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iVision.MODELS.Entities
{
    public class Patient : IPerson
    {
        [Key]
        public int PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int? MedicalCardId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual MedicalCard MedicalCard { get; set; }
    }
}
