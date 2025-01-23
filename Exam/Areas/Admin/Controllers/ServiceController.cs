using BL.DTOs.ServiceDTO;
using BL.DTOs.Worker;
using BL.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Areas.Admin.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _service;


        public ServiceController(IServiceService service)
        {

            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                await _service.GetAllAsync();
            }
            catch
            {
                BadRequest("Something went wrong");
            }
            return View();
        }

        public async Task<IActionResult> CreateAsync(CreateServiceDTO serviceDTO)
        {
            try
            {
                await _service.CreateAsync(serviceDTO);
            }
            catch
            {
                BadRequest("Something went wrong");
            }
            return View();
        }
        public async Task<IActionResult> DeleteAsync(int id)
        {
            try
            {
                await _service.DeleteAsync(id);
            }
            catch
            {
                BadRequest("Something went wrong");
            }
            return View();
        }
    }
}
