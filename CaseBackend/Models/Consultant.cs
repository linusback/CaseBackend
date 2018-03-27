using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseBackend.Models
{
    public class Consultant
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        //public List<string> Competences { get; set; }
        public string PictureLink { get; set; }
        //public List<string> Assigments { get; set; }
    }
}
