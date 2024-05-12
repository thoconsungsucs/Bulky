using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;
namespace BulkyBookWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    /*   [Authorize(Roles = SD.Role_Admin)]*/
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CompanyController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            List<Company> objCompanyList = _unitOfWork.Company.GetAll().ToList();
            return View(objCompanyList);
        }

        public IActionResult Upsert(int? id)
        {

            //Create
            if (id == null || id == 0)
            {
                return View(new Company());
            }
            // Edit
            var companyObj = _unitOfWork.Company.Get(u => u.Id == id);
            if (companyObj == null)
            {
                return NotFound();
            }
            return View(companyObj);
        }
        [HttpPost]

        public IActionResult Upsert(int? id, Company companyObj)
        {

            if (!ModelState.IsValid)
            {
                return View(companyObj);
            }


            if (id != 0 && id != null)
            {
                //Edit Company
                _unitOfWork.Company.Update(companyObj);
                _unitOfWork.Save();
                TempData["Message"] = "Company Edited Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                _unitOfWork.Company.Add(companyObj);
                TempData["Message"] = "Company Created Successfully";
                _unitOfWork.Save();
                return RedirectToAction("Index");
            }
        }



        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            var objCompanyList = _unitOfWork.Company.GetAll();
            return Json(new { data = objCompanyList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var deletedCompany = _unitOfWork.Company.Get(u => u.Id == id);
            if (deletedCompany == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            _unitOfWork.Company.Remove(deletedCompany);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete Successful" });
        }
        #endregion
    }
}
