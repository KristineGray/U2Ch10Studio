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

        /*
        Also at localhost:5001/skills/form, 
        use [HttpPost] and 
        request parameters to update the HTML with 
            an h1 stating the submitted date and 
            a list showing the user’s learning progress in the three programming languages they chose
        */

        [HttpPost]
        public IActionResult Form()
        {
            /*
            At localhost:5001 / skills / form, 
            add a form that lets the user 
                enter a date and 
                choose their learning progress in each of the programming skills listed at / skills
            */

            string formOpen = "<form>";
            string labelDate = "<label for='date'>Date:</label>";
            string inputDate = "<input type='date' id='date' />";

            string optionOne = "<option value='beginner'>Learning Basics</option>";
            string optionTwo = "<option value='intermediate'>Making Apps</option>";
            string optionThree = "<option value='expert'>Master Coder</option>";
            string select = $"<select>{optionOne}{optionTwo}{optionThree}</select>";

            string labelCSharp = "<label>C#</label>";
            string labelJavaScript = "<label>JavaScript</label>";
            string labelPython = "<label>Python</label>";

            string submit = "<input type='submit' value='Submit'>";
            string formClose = "</form>";

            string html = formOpen + labelDate + inputDate + labelCSharp + select + labelJavaScript + select + labelPython + select + submit + formClose;

            return Content(html, "text/html");
        }
    }
}
