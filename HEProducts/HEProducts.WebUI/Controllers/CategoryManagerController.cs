using HEProducts.Core.Model;
using HEProducts.DataAccess.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HEProducts.WebUI.Controllers
{
    public class CategoryManagerController : Controller
    {
        ProductCategoryRepository context;

        public CategoryManagerController()
        {
            context = new ProductCategoryRepository();
        }
        // GET: CategoryManager
        public ActionResult Index()
        {
            List<ProductCategory> productsCategorys = context.Collection().ToList();
            return View(productsCategorys);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ProductCategory cat = new ProductCategory();
            return View(cat);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCategory cat)//Model binding
        {
            if (!ModelState.IsValid)
            {
                return View(cat);
            }
            else
            {
                context.Insert(cat);
                context.Commit();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Edit(string Id)
        {
            ProductCategory cat = context.Find(Id);
            if (cat == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(cat);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProductCategory cat, string Id)
        {
            ProductCategory productToEdit = context.Find(cat.Id);
            if (productToEdit == null)
            {
                return HttpNotFound();
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return View(cat);
                }
                productToEdit.Category = cat.Category;


                context.Commit();
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public ActionResult Delete(string Id)
        {
            ProductCategory productToDelete = context.Find(Id);
            if (productToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(productToDelete);
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            ProductCategory productToDelete = context.Find(Id);

            if (productToDelete == null)
            {
                return HttpNotFound();
            }
            else
            {
                context.Delete(Id);
                context.Commit();
                return RedirectToAction("Index");

            }
        }
    }
}