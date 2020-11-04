using System.Collections.Generic;
using simpleAPI.Models;

namespace simpleAPI.DataRepository
{
    public interface ISimpleAPIRepo
    {
       IEnumerable <SimpleAPI> getAllData();  
       SimpleAPI getDataById(int id);
       void CreateData(SimpleAPI api);




       bool SaveChanges(); //This method saves the chages we write in the db
    }
}