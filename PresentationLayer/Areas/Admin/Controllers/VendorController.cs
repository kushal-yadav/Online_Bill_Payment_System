using BusinessLogicLayer;
using Entities;
using PresentationLayer.CustomFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentationLayer.Areas.Admin.Controllers
{
    // [AuthorizeFilter(Roles = "Admin")]
    public class VendorController : Controller
    {
        Validation validation = new Validation();
        // GET: Admin/Vendor

        public ActionResult Index()
        {
            var vendorList = validation.GetAllValidVendors();
            return View(vendorList);
        }

        // GET: Admin/Vendor/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Vendor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Vendor/Create
        [HttpPost]
        public ActionResult Create(Vendors vendor)
        {
            int result = 0;
            try
            {
                result = validation.AddValidVendor(vendor);
                if (result > 0)
                    return RedirectToAction("Index");
                else
                    return Content("Unable to create vendor");
            }
            catch (Exception)
            {
                return View();
            }
        }

        // GET: Admin/Vendor/Edit/5
        public ActionResult Edit(int id)
        {
            Vendors vendor = validation.GetAllVendors().First(v => v.VendorID == id);
            return View(vendor);
        }

        // POST: Admin/Vendor/Edit/5
        [HttpPost]
        public ActionResult Edit(Vendors existingVendors, int id)
        {
            try
            {
                int result = validation.UpdateValidVendor(existingVendors, id);
                if (result > 0)
                    return RedirectToAction("Index");
                else
                    return Content("Unable to update vendor");
            }
            catch
            {
                return View();
            }
        }
    }
}
