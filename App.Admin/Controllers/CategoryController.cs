using System;
using App.Application.Interfaces.Shop;
using App.Application.ViewModels.Shop;
using App.Domain.Core.Notifications;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace App.Admin.Controllers
{
    [Authorize]
    public class CategoryController : BaseController
    {
        private readonly ICategoryAppService _categoryAppService;

        public CategoryController(ICategoryAppService categoryAppService,
                                  INotificationHandler<DomainNotification> notifications) : base(notifications)
        {
            _categoryAppService = categoryAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Category-management/list-all")]
        public IActionResult Index()
        {
            return View(_categoryAppService.GetAll());
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Category-management/Category-details/{id:int}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CategoryViewModel = _categoryAppService.GetById(id.Value);

            if (CategoryViewModel == null)
            {
                return NotFound();
            }

            return View(CategoryViewModel);
        }

        [HttpGet]
        [Authorize(Policy = "CanWriteCategoryData")]
        [Route("Category-management/register-new")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "CanWriteCategoryData")]
        [Route("Category-management/register-new")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid) return View(categoryViewModel);
            //categoryViewModel.CategoryId = Guid.NewGuid();

            _categoryAppService.Create(categoryViewModel);

            if (IsValidOperation())
                ViewBag.Sucesso = "Category Created!";

            return View(categoryViewModel);
        }

        [HttpGet]
        [Authorize(Policy = "CanWriteCategoryData")]
        [Route("Category-management/edit-Category/{id:int}")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoryViewModel = _categoryAppService.GetById(id.Value);

            if (categoryViewModel == null)
            {
                return NotFound();
            }

            return View(categoryViewModel);
        }

        [HttpPost]
        [Authorize(Policy = "CanWriteCategoryData")]
        [Route("Category-management/edit-Category/{id:int}")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryViewModel categoryViewModel)
        {
            if (!ModelState.IsValid) return View(categoryViewModel);

            _categoryAppService.Update(categoryViewModel);

            if (IsValidOperation())
                ViewBag.Sucesso = "Category Updated!";

            return View(categoryViewModel);
        }

        [HttpGet]
        [Authorize(Policy = "CanRemoveCategoryData")]
        [Route("Category-management/remove-Category/{id:int}")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CategoryViewModel = _categoryAppService.GetById(id.Value);

            if (CategoryViewModel == null)
            {
                return NotFound();
            }

            return View(CategoryViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [Authorize(Policy = "CanRemoveCategoryData")]
        [Route("Category-management/remove-Category/{id:int}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _categoryAppService.Remove(id);

            if (!IsValidOperation()) return View(_categoryAppService.GetById(id));

            ViewBag.Sucesso = "Category Removed!";
            return RedirectToAction("Index");
        }

        //[AllowAnonymous]
        //[Route("Category-management/Category-history/{id:guid}")]
        //public JsonResult History(int id)
        //{
        //    var categoryHistoryData = _categoryAppService.GetAllHistory(id);
        //    return Json(categoryHistoryData);
        //}
    }
}
