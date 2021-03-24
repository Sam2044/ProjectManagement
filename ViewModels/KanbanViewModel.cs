using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectMgt.Models;

namespace ProjectMgt.ViewModels
{
    public class KanbanViewModel
    {
        public List<Kanban> TasksList { get; set; }

        public Kanban Kanban { get; set; }

        public List<StatusPriority> StatusPriorities { get; set; }
    }
}