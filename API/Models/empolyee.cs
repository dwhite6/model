using System;
using System.Collections.Generic;
using System.IO;

namespace mis321_project.API.Models
{
    public class empolyee
    {
        public int id {get; set;}
        public string empolyeeFName {get; set;}
        public string empolyeeLName {get; set;}
        public string empolyeeStatus {get; set;}
        public int overallScore {get; set;}
        public int performanceScore {get;set;}
        public int leadershipScore {get;set;}

    }
}