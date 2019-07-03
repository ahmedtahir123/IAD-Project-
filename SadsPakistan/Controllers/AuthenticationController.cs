using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SadsPakistan.Models;
using System.IO;
using PagedList;


namespace SadsPakistan.Controllers
{
    public class AuthenticationController : Controller


        


    {


      


        dbemarketingEntities db = new dbemarketingEntities();
        sadspakEntities DB = new sadspakEntities();

        // GET: Authentication
        public ActionResult AdminLogin()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AdminLogin(tbl_admin avm)
        {

            tbl_admin ad = db.tbl_admin.Where(x => x.ad_adminname == avm.ad_adminname && x.ad_password == avm.ad_password).SingleOrDefault();
            if (ad != null)
            {
                Session["ad_id"] = ad.ad_id.ToString();
                return RedirectToAction("ViewDonations");
            }
            else
            {
                ViewBag.error = "invalid user name and password";
            }
            return View();
        }

        public ActionResult ViewDonations(int?id)
        {
            switch (id)
            {

                case 1:
                    return RedirectToAction("Cloths");

                case 2:
                    return RedirectToAction("Footwear");
                case 3:
                    return RedirectToAction("Electronics");
                case 4:
                    return RedirectToAction("mattresses");
                case 5:
                    return RedirectToAction("stationary");

                case 6:
                    return RedirectToAction("toys");

                case 7:
                    return RedirectToAction("woolens");


                default:
                    return View();
                    break;
            }

        }



        public ActionResult woolens(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 4).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);
        }

        public ActionResult toys(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 5).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);
        }

        public ActionResult stationary(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 6).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);
        }

        public ActionResult mattresses(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 7).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);
        }


        public ActionResult Cloths(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 1).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);


        }



        public ActionResult Footwear(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 3).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);

        }
        public ActionResult Electronics(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 2).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);

        }
        public ActionResult Furniture(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 8).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);

        }
        public ActionResult kitchenware(int? page)
        {
            int pagesize = 9, pageindex = 1;
            pageindex = page.HasValue ? Convert.ToInt32(page) : 1;
            var list = DB.imgs.Where(x => x.img_status == 9).OrderByDescending(x => x.img_id).ToList();
            IPagedList<img> stu = list.ToPagedList(pageindex, pagesize);


            return View(stu);

        }

    }
}