using AutoMapper;
using BL.DTOs.Worker;
using BL.Services.Abstractions;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkersController : Controller
    {
        private readonly IWorkerService _service;
        

        public WorkersController(IWorkerService service)
        {
            
            _service = service;
        }

        public  async Task<IActionResult> Index()
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

        public async Task<IActionResult> CreateAsync(CreateWorkerDTO workerDTO )
        {
            try
            {
                await _service.CreateAsync(workerDTO);
            }
            catch
            {
                BadRequest("Something went wrong");
            }
            return View();
        }
        
        


    }
}
