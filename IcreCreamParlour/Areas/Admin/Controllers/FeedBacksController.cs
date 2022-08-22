using IcreCreamParlour.Mapper;
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
        private readonly IUserService _userService;

        public FeedBacksController(IFeedbackService feedback, IUserService userService)
        {
            _feedback = feedback;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var feedback = _feedback.GetAll().ToList().Select(feedback =>
            {
                var feedbackDTO = feedback.Convert();
                feedbackDTO.Responder = _userService.FindById(feedback.UserId.Value).Name;
                return feedbackDTO;
            });
            return View(feedback);
        }

        public IActionResult Detail(int id)
        {
            var feedbackDetail = _feedback.FindById(id);
            return View(feedbackDetail);
        }
    }
}
