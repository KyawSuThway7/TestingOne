using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace CloudHRMSTest.Controllers
{
    public class EmployeeReportController : Controller
    {
        private IWebHostEnvironment _webHostEnvironment;

        public EmployeeReportController(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;//To read EmployeeDetailReport
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);//For Uni Code
        }
        public IActionResult EmployeeByFromCode()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EmployeeByFromCode(string FromCode, string ToCode, string departmentId)
        {
            return View();
        }
    }
}
