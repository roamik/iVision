using iVision.MODELS.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace iVision.MODELS.Entities
{
    public class Doctor : IPerson
    {
        [Key]
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
