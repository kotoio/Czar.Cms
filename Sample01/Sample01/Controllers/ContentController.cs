using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        private readonly Content contents;
        public ContentController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        /// <summary> 
        /// Content控制器
        /// </summary>
        public IActionResult Index()
        {
          
            return View(new ContentViewModel { Contents = new List<Content> { contents} });
        }
    }
}
