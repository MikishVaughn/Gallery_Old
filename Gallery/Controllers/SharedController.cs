﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Gallery.Models;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Gallery.Controllers
{
    public class BaseController : Controller
    {
        protected IActionResult GalleryView(string viewName = "Gallery")
        {
            ViewData["ViewName"] = viewName;
            return View();
            }
        }

    public class GalleriesController : BaseController
    {
        public IActionResult Index() => View("Galleries");
    }

    public class APController : BaseController
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
    }

    public class BCController : BaseController
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
    }

    public class MVController : BaseController
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
    }

    public class LaserController : BaseController
    {
        public IActionResult Index() => GalleryView();
        public IActionResult Gallery(string viewName) => GalleryView(viewName);
    }
}
