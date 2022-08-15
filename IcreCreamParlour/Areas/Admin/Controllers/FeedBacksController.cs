using IcreCreamParlour.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IcreCreamParlour.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FeedBacksController : Controller
    {
        private readonly IFeedbackService _feedback;

        public FeedBacksController(IFeedbackService feedback)
        {
            _feedback = feedback;
        }

        public IActionResult Index()
        {
            var feedback = _feedback.GetAll().ToList();
            return View(feedback);
        }

        public IActionResult Detail(int id)
        {
            var feedbackDetail = _feedback.FindById(id);
            return View(feedbackDetail);
        }
    }
}
