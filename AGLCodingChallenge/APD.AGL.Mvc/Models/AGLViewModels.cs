using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APD.AGL.Mvc.Models
{
    public class AGLViewModel
    {
        public List<String> MalesCat { get; set; }

        public List<String> FemalesCat { get; set; }

        public AGLViewModel()
        {
            MalesCat = new List<string>();
            FemalesCat = new List<string>();
        }
    }
}