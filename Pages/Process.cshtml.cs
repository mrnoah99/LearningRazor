using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            var Procs = Process.GetProcesses();
            ViewData["Processes"] = Procs;
            ViewData["Message"] = "This is our first day in the 2024 Fall Term";
        }
    }
}
