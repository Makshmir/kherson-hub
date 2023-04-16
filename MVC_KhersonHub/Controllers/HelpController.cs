using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_KhersonHub.Models.Domain;
using System;
using System.Reflection.Metadata;

namespace MVC_KhersonHub.Controllers
{
    public class HelpController : Controller
    {
        private readonly DatabaseContext _ctx;
        public HelpController(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sended()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sended(UploadFile model)
        {


            Immigrant person = new Immigrant();
            person.FirstName = model.FirstName;
            person.IDP_number = model.IDP_number;
            person.Number = model.Number;
            person.Patronymic = model.Patronymic;
            person.ActualResidence = model.ActualResidence;
            person.Date = model.Date;
            person.Number_of_children = model.Number_of_children;
            person.RegisteredResidence = model.RegisteredResidence;
            person.SurName = model.SurName;
            if (!ModelState.IsValid)
            {
                return View();
            }


            try
            {
                if (model.MyImage.Length > 0)

                {

                    byte[] p1 = null;
                    using (var fs1 = model.MyImage.OpenReadStream())
                    using (var ms1 = new MemoryStream())
                    {
                        fs1.CopyTo(ms1);
                        p1 = ms1.ToArray();
                    }
                    person.Img = p1;

                }


                _ctx.Immigrant.Add(person);
                _ctx.SaveChanges();
                TempData["msg"] = "Вас успішно зареєстровано!";
                return RedirectToAction("Sended");

            }
            catch (Exception ex)
            {
                TempData["msg"] = "Щоб його чорт побрав! Якась помилка, зв'яжіться з адміністратором!";
                return View();
            }
        }


    }
}
