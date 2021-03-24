using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMgt.Models
{
    public class Kanban
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string Type { get; set; }
        public string Priority { get; set; }
        public string Tags { get; set; }
        public double Estimate { get; set; }
        public string Assignee { get; set; }
        public int RankId { get; set; }
        public string Color { get; set; }

        

       
    }
}