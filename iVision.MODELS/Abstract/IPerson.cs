using System;
using System.Collections.Generic;
using System.Text;

namespace iVision.MODELS.Abstract
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Gender { get; set; }

    }
}
