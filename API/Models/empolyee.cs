using System;
using System.Collections.Generic;
using System.IO;
using API.Models.Interfaces;

namespace mis321_project.API.Models
{
    public class empolyee
    {
        public int id {get; set;}
        public string empolyeeFName {get; set;}
        public string empolyeeLName {get; set;}
        public string empolyeeStatus {get; set;}
        public int empolyeeScore {get;set;}

    }
}