using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iVision.MODELS.Entities
{
    public class MedicalCard
    {
        [Key]
        public int MedicalCardId { get; set; }

        public string Annotation { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
