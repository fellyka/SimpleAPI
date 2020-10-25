using System.Collections.Generic;
using simpleAPI.Models;

namespace simpleAPI.DataRepository
{
    public interface ISimpleAPIRepo
    {
       IEnumerable <SimpleAPI> getAllData();  
       SimpleAPI getDataById(int id);
    }
}