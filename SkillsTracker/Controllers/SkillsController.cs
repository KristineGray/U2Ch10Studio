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

            string formOpen = "<form method='post' action='/skills/form'>";
            string labelDate = "<label for='date'>Date:</label>";
            string inputDate = "<input type='date' name='date' id='date' />";

            string optionOne = "<option value='Learning Basics'>Learning Basics</option>";
            string optionTwo = "<option value='Making Apps'>Making Apps</option>";
            string optionThree = "<option value='Master Coder'>Master Coder</option>";
            
            string labelCSharp = "<label>C#</label>";
            string csSelect = $"<select for='csharp' name='csharpOption'>{optionOne}{optionTwo}{optionThree}</select>";

            string labelJavaScript = "<label>JavaScript</label>";
            string jsSelect = $"<select for='javascript' name='jsOption'>{optionOne}{optionTwo}{optionThree}</select>";
            
            string labelPython = "<label>Python</label>";
            string pySelect = $"<select for='python' name='pythonOption'>{optionOne}{optionTwo}{optionThree}</select>";

            string submit = "<input type='submit' value='Submit'>";
            string formClose = "</form>";

            string html = formOpen + labelDate + inputDate + labelCSharp + csSelect + labelJavaScript + jsSelect + labelPython + pySelect + submit + formClose;

            return Content(html, "text/html");
        }

        /*
        Also at localhost:5001/skills/form, 
        use [HttpPost] and 
        request parameters to update the HTML with 
            an h1 stating the submitted date and 
            a list showing the user’s learning progress in the three programming languages they chose
        */

        [HttpPost("/skills/form")]
        public IActionResult SubmittedForm(string date, string csharpOption, string jsOption, string pythonOption)
        {
            string title = $"<h1>{date}</h1>";
            string olStart = "<ol>";
            string csharp = $"<li>C#: {csharpOption}</li>";
            string js = $"<li>JavaScript: {jsOption}</li>";
            string python = $"<li>Python: {pythonOption}</li>";
            string olEnd = "</ol>";

            string html = title + olStart + csharp + js + python + olEnd;

            return Content(html, "text/html");
        }

        /*
        [HttpPost("/skills/form")]
        public IActionResult SubmittedForm(string submittedDate, Dictionary<string, string> langProgression)
        {

            string dateTag = $"<h1>{submittedDate}</h1>";
            string listTag = "<ol>";
            foreach (KeyValuePair<string, string> pair in langProgression)
            {
                string progress = $"<li>{pair.Key}: {pair.Value}</li>";
                listTag += progress;
            }
            listTag += "</ol>";

            string html = dateTag + listTag;
            return Content(html, "text/html");
        }
        */
    }
}
