using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Sample.ViewModels;
using MVC_Sample.Services;
namespace MVC_Sample.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentService _studentService = new();
        public async Task<IActionResult> IndexAsync()
        {
            var students = await _studentService.ReadAllAsync();
            var viewModel = new StudentListViewModel(
                Students: students.Select(student => new StudentListItemViewModel(
                    Id: student.Id,
                    Name: student.Name,
                    ClassCount: student.Classes.Count()
                ))
            );
            return View(viewModel);
        }
    }
}
