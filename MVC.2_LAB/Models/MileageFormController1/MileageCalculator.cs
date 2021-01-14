using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC._2_LAB.Models.MileageFormController1
{
    public class FormResultsViewModel
    {
 
        public int GallonsInTank { get; set; }
        public int Mileage { get; set; }
        public int Miles => Mileage * GallonsInTank;

    }

}
