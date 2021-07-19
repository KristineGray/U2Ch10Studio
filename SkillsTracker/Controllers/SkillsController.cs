using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet]
        [Route("/skills/")]
        public IActionResult Index()
        {
            /*
            At localhost:5001 / skills, 
            add text that states the three possible programming languages someone could be working on. 
            You need to have 
                an h1 with the title “Skills Tracker”, 
                an h2, and 
                an ol containing three programming languages of your choosing.
            */

            string title = "<h1>Skills Tracker</h1>";
            string subTitle = "<h2>Coding skills to learn:</h2>";
                       
            string langOne = "<li>C#</li>";
            string langTwo = "<li>Python</li>";
            string langThree = "<li>JavaScript</li>";
            string orderedList = "<ol>" + langOne + langTwo + langThree + "</ol>";

            string html = title + subTitle + orderedList;

            return Content(html, "text/html");
        }

        public IActionResult Form()
        {
            /*
            At localhost:5001 / skills / form, 
            add a form that lets the user 
                enter a date and 
                choose their learning progress in each of the programming skills listed at / skills
            */

            string formOpen = "<form>";
            string labelDate = "<label>Date:</label>";
            string labelCSharp = "<label>C#</label>";
            string labelJavaScript = "<label>JavaScript</label>";
            string labelPython = "<label>Python</label>";
            string formClose = "</form>";

            string html = formOpen + labelDate + date + labelCSharp + csharp + labelJavaScript + js + labelPython + python + formClose;

            return Content(html, "text/html");
        }
    }
}
