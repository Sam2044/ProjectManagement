using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMgt.Models;
using ProjectMgt.ViewModels;

namespace ProjectMgt.Controllers
{
    public class KanbanController : Controller
    {
        // GET: Kanban
        //Kanban/Kanban
        public ActionResult Kanban()
        {
            
             List<Kanban> kanbans = new List<Kanban>{
                new Kanban
                {
                    Id = "Task 1", Title = "Task  - 29001", Status = "Open",
                    Summary = "Analyze the new requirements gathered from the customer.", Type = "Story",
                    Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Nancy Davloio",
                    RankId = 1, Color = "#8b447a"
                },
                new Kanban{
                    Id = "Task 1", Title = "Task  - 29001", Status = "Open",
                    Summary = "Analyze the new requirements gathered from the customer.", Type = "Story",
                    Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Nancy Davloio",
                    RankId = 1, Color = "#8b447a"
                },
                new Kanban
                {
                    Id = "Task 2", Title = "Task  - 29002", Status = "InProgress",
                    Summary = "Improve application performance", Type = "Improvement", Priority = "Normal",
                    Tags = "Improvement", Estimate = 6, Assignee = "Andrew Fuller", RankId = 1, Color = "#7d7297"
                },
                new Kanban
                {
                    Id = "Task 3", Title = "Task  - 29003", Status = "Open",
                    Summary = "Arrange a web meeting with the customer to get new requirements.", Type = "Others",
                    Priority = "Critical", Tags = "Meeting", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 2,
                    Color = "#27AE60"
                },
                new Kanban
                {
                    Id = "Task 4", Title = "Task  - 29004", Status = "InProgress",
                    Summary = "Fix the issues reported in the IE browser.", Type = "Bug", Priority = "Release Breaker",
                    Tags = "IE", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 2, Color = "#cc0000"
                },
                new Kanban
                {
                    Id = "Task 5", Title = "Task  - 29005", Status = "Review",
                    Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Low",
                    Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1, Color = "#cc0000"
                },
                new Kanban
                {
                    Id = "Task 6", Title = "Task  - 29007", Status = "Validate", Summary = "Validate new requirements",
                    Type = "Improvement", Priority = "Low", Tags = "Validation", Estimate = 1.5,
                    Assignee = "Robert King", RankId = 1, Color = "#7d7297"
                },
                new Kanban
                {
                    Id = "Task 7", Title = "Task  - 29009", Status = "Review",
                    Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker",
                    Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Nancy Davloio", RankId = 2, Color = "#cc0000"
                }

        };

            var viewModel = new KanbanViewModel
            {
                TasksList = kanbans
            };







            return View(viewModel);
        }
    }
}