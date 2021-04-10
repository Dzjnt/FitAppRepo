using FitApp.DataAccess;
using FitApp.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRepository<Recipe> _recipeRepository;
        public RecipesController(IRepository<Recipe> recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
   
        [HttpGet]
        [Route("")]
        public  async Task<IEnumerable<Recipe>> GetRecipes() =>  await  _recipeRepository.GetAll();

        [HttpGet]
        [Route("{id}")]
        public async Task<Recipe> GetRecipe(int id) => await _recipeRepository.GetById(id);


    }
}
