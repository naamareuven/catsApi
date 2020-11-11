using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Cat.Models;
using Cats.Data;
using Cat.Data;
namespace Cat.Controllers{
    //api/Cats
    [Route("api/[controller]")]
    [ApiController]
public class CatsController: ControllerBase{
    private readonly ICatsRepos _repository;
    public CatsController(ICatsRepos repository){
        _repository = repository;

    }
    //private readonly MockCatRepo _repository = new MockCatRepo();
        public ActionResult<IEnumerable<Kitten>> GetAllCats()
        {
            var catItems = _repository.GetAllCats();
            return Ok(catItems);

        }

        [HttpGet("{id}")]
    public ActionResult <Kitten> GetCatById(int id){
        var catItem = _repository.GetCatById(id);
        return Ok(catItem);

    }

}
}