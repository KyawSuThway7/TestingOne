﻿using CloudHRMSTest.Models.ViewModel;
using CloudHRMSTEST.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
namespace CloudHRMSTEST.Controllers
{ 
    public class PositionController : Controller
    {
        private readonly IPositionService _positionService;

        public PositionController(IPositionService positionService)
        {
            this._positionService = positionService;
        }
        public IActionResult List() //Show
        {
            return View(_positionService.GetAll());
        }

        public IActionResult Edit(string id)
        {
            if (id != null)
            {

                return View(_positionService.GetById(id));
            }
            else
            {
                return RedirectToAction("List");
            }
        }
        [HttpPost]
        public IActionResult Update(PositionViewModel position)
        {
            try
            {
                _positionService.Update(position);
                ViewBag.Info = "successfully save a record to the system";
            }
            catch (Exception ex)
            {
                ViewBag.Info = "Error occur when  saving a record  to the system";
            }
            return RedirectToAction("List");
        }

        public IActionResult Delete(string id)
        {
            try
            {
                _positionService.Delete(id);
                TempData["Info"] = "Save Successfully";
            }
            catch (Exception ex)
            {
                TempData["Info"] = "Error Occur When Deleting";
            }
            return RedirectToAction("List");
        }
        public IActionResult Entry() => View();
        [HttpPost]
        public IActionResult Entry(PositionViewModel ui)
        {
            try
            {
                _positionService.Create(ui);
                ViewBag.Info = "successfully save a record to the system";
            }
            catch (Exception ex)
            {
                ViewBag.Info = "Error occur when  saving a record  to the system";
            }
            return View();
        }
    }
}