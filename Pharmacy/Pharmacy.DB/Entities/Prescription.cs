using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy.DB.Entities
{
    public partial class Prescription
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrescriptionNo { get; set; }
        public int AuthorizeId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int Iuser { get; set; }
        public int? Uuser { get; set; }
        public DateTime Idate { get; set; }
        public DateTime? Udate { get; set; }
        public int Imedicine { get; set; }
    }
}
