using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _unitOfWork.Category.GetAll().ToList();
            return View(objCategoryList);
        }
        public IActionResult Upsert(int? id)
        {
            var category = _unitOfWork.Category.Get(u => u.Id == id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Upsert(int? id, Category obj)
        {
            if (id == 0 || id == null)
            {
                if (obj.Name == obj.DisplayOrder.ToString())
                {
                    ModelState.AddModelError("Name", "Cannot be the same");
                    return View();
                }
                if (!ModelState.IsValid)
                {
                    return View(obj);
                }

                _unitOfWork.Category.Add(obj);
                TempData["Message"] = "Category Created Successfully";
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            _unitOfWork.Category.Update(obj);
            TempData["Message"] = "Category Updated Successfully";
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (!ModelState.IsValid)
            {
                return View(obj);
            }
            _unitOfWork.Category.Update(obj);
            TempData["Message"] = "Category Updated Successfully";
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _unitOfWork.Category.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(obj);
            TempData["Message"] = "Category Deleted Successfully";
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
