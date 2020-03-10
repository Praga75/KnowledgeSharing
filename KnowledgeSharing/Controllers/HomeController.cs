﻿using System;
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
        ICategoriesService categoriesService;

        public HomeController(IQuestionsService questionService,ICategoriesService categoriesService)
        {
            this.questionService = questionService;
            this.categoriesService = categoriesService;
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
        public ActionResult Categories()
        {
            List<CategoryViewModel> categoriesList = categoriesService.GetCategories();
            return View(categoriesList);
        }
    
        public ActionResult Questions()
        {
            List<QuestionViewModel> questions = questionService.GetQuestions();
            return View(questions);
        }
    }
}