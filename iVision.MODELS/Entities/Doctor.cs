using iVision.MODELS.Abstract.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iVision.MODELS.Entities
{
    public class Doctor : Person
    {
        [Key]
        public int DoctorId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Patient> Patients { get; set; }
    }
}
