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
    public class RecipeController : ControllerBase
    {
        private readonly IRepository<Recipe> _recipeRepository;
        public RecipeController(IRepository<Recipe> recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }
        [HttpGet]
        [Route("")]
        public IEnumerable<Recipe> GetRecipes() => _recipeRepository.GetAll();

        [HttpGet]
        [Route("{id}")]
        public Recipe GetRecipe(int id) => _recipeRepository.GetById(id);


    }
}
