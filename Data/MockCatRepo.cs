using System.Collections.Generic;
using Cat.Models;
using Cats.Data;
namespace Cat.Data
{
    public class MockCatRepo : ICatsRepos
    {
        public  IEnumerable<Kitten> GetAllCats(){
            throw new System.NotImplementedException();
        }
        public Kitten getCatById(int id){
            throw new System.NotImplementedException();
        }
    }
}