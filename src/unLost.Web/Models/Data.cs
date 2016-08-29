using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace unLost.Web.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public int? ItemLogNo { get; set; }
        public int? PupilId { get; set; }
        public int ItemCat { get; set; }
        public int ItemSubcat { get; set; }
        public string ItemDesc { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Mailed { get; set; }
        public DateTime? Collected { get; set; }

        public virtual Pupil Pupil { get; set; }
    }

    public class Pupil
    {
        public int PupilId { get; set; }
        public string CandNo { get; set; }
        public string Surname { get; set; }
        public string Forename { get; set; }
        public int? TutorGpId { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }

        // Navigation property 
        public virtual ICollection<Item> Items { get; set; }
        public virtual TutorGp TutorGp { get; set; }
    }

    public class TutorGp
    {
        public int GpId { get; set; }
        public string Name { get; set; }
        public string Tutor { get; set; }
    }
}
