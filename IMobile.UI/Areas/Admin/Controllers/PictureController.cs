using Microsoft.AspNetCore.Mvc;

namespace IMobile.UI.Areas.Admin.Controllers
{
    public class PictureController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public PictureController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        public JsonResult UploadPicture(List<IFormFile> photoUrl)
        {
            List<string> photoList = new();
            for (int i = 0; i < photoUrl.Count; i++)
            {
                string path = "/uploads/" + Guid.NewGuid() + Path.GetExtension(photoUrl[i].FileName);
                using (var fileStream = new FileStream(_env.WebRootPath + path, FileMode.Create))
                {
                    photoUrl[i].CopyTo(fileStream);
                }
                photoList.Add(path);
            }
            return Json(photoList);
        }
    }
}
