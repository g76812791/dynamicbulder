using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApplication17.Models;

namespace WebApplication17.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            People people= new People(){name="231",eage = "234",address = "beijing"};


            ViewBag.tip = JsonConvert.SerializeObject(people);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Test([ModelBinder(typeof(JObjectModelBinder))]dynamic en)
        {
            string name = en.name;
            return  new EmptyResult();
        }
    }
}