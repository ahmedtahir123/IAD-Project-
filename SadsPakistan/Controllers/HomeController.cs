using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SadsPakistan.Models;

namespace SadsPakistan.Controllers
{
    public class HomeController : Controller
    {

        sadspakEntities DB = new sadspakEntities();

        public ActionResult Index()
        {
            return View();
        }
        [ActionName("volunteer")]
        public ActionResult About()
        {

            return View("About");
        }

        public ActionResult Brand()
        {

            return View();
        }

        public ActionResult Confirmation()
        {

            return View();
        }

        public ActionResult coorpoarte()
        {

            return View();
        }

        [HttpPost]
        public ActionResult coorpoarte(CoOrporate c)
        {
            Contact a = new Contact();
            a.contactName = c.Name;
            a.Email = c.Email;
            a.phoneNo = c.Contact;
            a.CT_ID = 2;
            DB.Contacts.Add(a);
            DB.SaveChanges();

            var q = DB.Contacts.Where(x => x.Email == (c.Email)).SingleOrDefault();
            Message m = new Message();

            m.subject = c.Subject;
            m.C_ID = q.C_ID;
            m.MT_ID = 1;
            return View();

        }

        public ActionResult Detail()
        {

            return View();
        }
        public ActionResult form()
        {

            return View();
        }
        [HttpPost]
        public ActionResult form(FormClass1 fm)
        {

            return View("Mobile");
        }

        public ActionResult Mobile()
        {

            return View();
        }
        public ActionResult NGO()
        {

            return View();
        }
        public ActionResult offer()
        {

            return View();
        }

        [HttpGet]
        public ActionResult personal()
        {

            return View();
        }



        public ActionResult smart()
        {

            return View();
        }
        public ActionResult story()
        {

            return View();
        }
        public ActionResult work()
        {

            return View();
        }
        [HttpPost]
        public ActionResult personal(CoOrporate c)
        {
            
           

            Contact a = new Contact();
            a.contactName = c.Name;
            a.Email = c.Email;
            a.phoneNo = c.Contact;
            a.CT_ID = 1;
            DB.Contacts.Add(a);
            DB.SaveChanges();

            var q = DB.Contacts.Where(x => x.Email==c.Email).SingleOrDefault();
            Message m = new Message();

            m.subject = c.Subject;
            m.C_ID = q.C_ID;
            m.MT_ID = 1;
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}