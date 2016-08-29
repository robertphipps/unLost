using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace unLost.Web.Models
{
    public class Forms
    {
        public class ItemEditFormPostback
        {
            public int Id { get; set; }
            public int? LogNo { get; set; }
            public int? Pupil { get; set; }
            public int Cat { get; set; }
            public int Subcat { get; set; }
            public string Desc { get; set; }
        }

        public class PupilEditFormPostback
        {
            public int Id { get; set; }
            public string Candno { get; set; }
            public string Forename { get; set; }
            public string Surname { get; set; }
            public int? TutorGpId { get; set; }
            public string Email { get; set; }
        }
    }
}
