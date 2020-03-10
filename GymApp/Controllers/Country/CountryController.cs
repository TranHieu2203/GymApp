using GymApp.Service.IR;
using GymApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymApp.Website.Controllers.Country
{
    public class CountryController : Controller
    {

        //initialize service object
        ICountryService _CountryService;

        public CountryController(ICountryService CountryService)
        {
            _CountryService = CountryService;
        }

        //
        // GET: /Country/
        public ActionResult Index()
        {
            return View(_CountryService.GetAll());
        }

        //
        // GET: /Country/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Country/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Model.Model.Country country)
        {

            // TODO: Add insert logic here
            if (ModelState.IsValid)
            {
                _CountryService.Create(country);
                return RedirectToAction("Index");
            }
            return View(country);

        }

        //
        // GET: /Country/Edit/5
        public ActionResult Edit(long id)
        {
            Model.Model.Country country = _CountryService.GetById(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        //
        // POST: /Country/Edit
        [HttpPost]
        public ActionResult Edit(Model.Model.Country country)
        {

            if (ModelState.IsValid)
            {
                _CountryService.Update(country);
                return RedirectToAction("Index");
            }
            return View(country);

        }

        //
        // GET: /Country/Delete/5
        public ActionResult Delete(long id)
        {
            Model.Model.Country country = _CountryService.GetById(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        //
        // POST: /Country/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, FormCollection data)
        {
            Model.Model.Country country = _CountryService.GetById(id);
            _CountryService.Delete(country);
            return RedirectToAction("Index");
        }
    }
}