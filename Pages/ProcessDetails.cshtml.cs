using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace WebpageYay.Pages
{
    public class ProcessDetailsModel : PageModel
    {
        public void OnGet(int id)
        {
            Process? process = Process.GetProcessById(id);
            if (process != null)
            {
                // ViewData["ProcessName"] = process.ProcessName;
                // ViewData["StartTime"] = process.StartTime;
                // ViewData["TotalProcessorTime"] = process.TotalProcessorTime;
                ViewData["ProcessInfo"] = process;
            }
        }
    }
}
