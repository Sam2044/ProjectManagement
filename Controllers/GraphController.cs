using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectMgt.Models;
using ProjectMgt.ViewModels;
using Syncfusion.EJ2.Base;
using Syncfusion.EJ2.Charts;

namespace ProjectMgt.Controllers
{
    public class GraphController : Controller
    {
        private ApplicationDbContext _context;

        public GraphController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Graph
        public ActionResult Graph()
        {

            var spList = _context.SP.ToList();
            var knbs = _context.Kanban.ToList();

            var viewModel = new KanbanViewModel
            {
                TasksList = knbs,
                StatusPriorities = spList
            };
            
            var selectY = (from k in viewModel.TasksList where k.Status == "Done" select k).ToList().Count;
            
            

                //UK-Done
        List<StackedColumnChartData> chartData = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { x= "Completed", y= selectY}
                
            };
        ViewBag.dataSource = chartData;


            var selectY1 = (from k in viewModel.TasksList where k.Status == "In Progress" select k).ToList().Count;
            //Germany-In Progress
            List<StackedColumnChartData> chartData1 = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { x= "Pending", y=selectY1  },
                
            };
            ViewBag.dataSource1 = chartData1;

            var selectY2 = (from k in viewModel.TasksList where k.Status == "Open" select k).ToList().Count;
            //Open
            List<StackedColumnChartData> chartData2 = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { x= "Pending", y= selectY2 },
                
            };
            ViewBag.dataSource2 = chartData2;

            //France-Review
            var selectY3 = (from k in viewModel.TasksList where k.Status == "Review" select k).ToList().Count;
            List<StackedColumnChartData> chartData3 = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { x= "Pending", y= selectY3 },

            };
            ViewBag.dataSource3 = chartData3;

            var selectY4 = (from k in viewModel.TasksList where k.Status == "Validate" select k).ToList().Count;
            //Italy-Validate
            List<StackedColumnChartData> chartData4 = new List<StackedColumnChartData>
            {
                new StackedColumnChartData { x= "Pending", y= selectY4 }
            };
            ViewBag.dataSource4 = chartData4;

            return View();
        }

        public class StackedColumnChartData
        {
            public string x;
            public double y;
        }
    }
}