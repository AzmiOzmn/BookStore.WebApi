using BookStore.BusinessLayer.Abstract;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult CagegoryList()
        {
            var value = _categoryService.TGetAll();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.TAdd(category);
            return Ok("Ekleme İşlemi Başarılı");
        }
    }
}
