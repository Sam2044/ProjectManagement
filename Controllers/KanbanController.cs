using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMgt.Models;
using ProjectMgt.ViewModels;



namespace ProjectMgt.Controllers
{
    [Authorize]
    public class KanbanController : Controller
    {
        private ApplicationDbContext _context;

        public KanbanController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        List<Kanban> kanbans = new List<Kanban>{
                new Kanban
                {
                    Title = "Task  - 29001", Status = "Open",
                    Summary = "Analyze the new requirements gathered from the customer.", Type = "Story",
                    Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Nancy Davloio",
                    RankId = 1, Color = "#8b447a"
                },
                new Kanban{
                    Title = "Task  - 29001", Status = "Open",
                    Summary = "Analyze the new requirements gathered from the customer.", Type = "Story",
                    Priority = "Low", Tags = "Analyze,Customer", Estimate = 3.5, Assignee = "Nancy Davloio",
                    RankId = 1, Color = "#8b447a"
                },
                new Kanban
                {
                    Title = "Task  - 29002", Status = "InProgress",
                    Summary = "Improve application performance", Type = "Improvement", Priority = "Normal",
                    Tags = "Improvement", Estimate = 6, Assignee = "Andrew Fuller", RankId = 1, Color = "#7d7297"
                },
                new Kanban
                {
                    Title = "Task  - 29003", Status = "Open",
                    Summary = "Arrange a web meeting with the customer to get new requirements.", Type = "Others",
                    Priority = "Critical", Tags = "Meeting", Estimate = 5.5, Assignee = "Janet Leverling", RankId = 2,
                    Color = "#27AE60"
                },
                new Kanban
                {
                     Title = "Task  - 29004", Status = "InProgress",
                    Summary = "Fix the issues reported in the IE browser.", Type = "Bug", Priority = "Release Breaker",
                    Tags = "IE", Estimate = 2.5, Assignee = "Janet Leverling", RankId = 2, Color = "#cc0000"
                },
                new Kanban
                {
                    Title = "Task  - 29005", Status = "Review",
                    Summary = "Fix the issues reported by the customer.", Type = "Bug", Priority = "Low",
                    Tags = "Customer", Estimate = 3.5, Assignee = "Steven walker", RankId = 1, Color = "#cc0000"
                },
                new Kanban
                {
                    Title = "Task  - 29007", Status = "Validate", Summary = "Validate new requirements",
                    Type = "Improvement", Priority = "Low", Tags = "Validation", Estimate = 1.5,
                    Assignee = "Robert King", RankId = 1, Color = "#7d7297"
                },
                new Kanban
                {
                     Title = "Task  - 29009", Status = "Review",
                    Summary = "Fix the issues reported in Safari browser.", Type = "Bug", Priority = "Release Breaker",
                    Tags = "Fix,Safari", Estimate = 1.5, Assignee = "Nancy Davloio", RankId = 2, Color = "#cc0000"
                }

        };

        
        // GET: Kanban
        //Kanban/Kanban
        public ActionResult Kanban()
        {


            var spList = _context.SP.ToList();
            var knbs = _context.Kanban.ToList();
            
            var viewModel = new KanbanViewModel
            {
                TasksList = knbs,
                StatusPriorities = spList
            };



            return PartialView(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Kanban kanban)
        {
            var spList = _context.SP.ToList();
            

            if (kanban.RankId == 0)
                _context.Kanban.Add(kanban);
            else
            {
                var kanbanInDb = _context.Kanban.Single(k => k.RankId == kanban.RankId);
                kanbanInDb.Title = kanban.Title;
                kanbanInDb.Summary = kanban.Summary;
                kanbanInDb.Estimate = kanban.Estimate;
                kanbanInDb.Assignee = kanban.Assignee;
                kanbanInDb.Status = kanban.Status;
                kanbanInDb.Priority = kanban.Priority;
                kanbanInDb.Color="#ffffff";
                kanbanInDb.Tags = "";
                kanbanInDb.Id = kanban.Id;
                kanbanInDb.Summary = "IDk";

            }

            try
            {
                _context.SaveChanges();
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }

            

            return RedirectToAction("Kanban", "Kanban");
        }

        
    }
}