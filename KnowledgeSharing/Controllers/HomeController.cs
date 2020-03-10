using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowledgeSharing.ServiceLayer;
using KnowledgeSharing.ViewModels;

namespace KnowledgeSharing.Controllers
{
    public class HomeController : Controller
    {
        IQuestionsService questionService;

        public HomeController(IQuestionsService questionService)
        {
            this.questionService = questionService;
        }
            
        public ActionResult Index()
        {
            List<QuestionViewModel> questions = questionService.GetQuestions().Take(10).ToList();
            return View(questions);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}