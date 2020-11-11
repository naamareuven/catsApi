using System.Collections.Generic;
using Cat.Models;
namespace Cats.Data{
    public interface ICatsRepos {
        IEnumerable<Kitten> GetAllCats();
        Kitten getCatById(int id);

    }
}