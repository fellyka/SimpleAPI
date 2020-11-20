using System.Collections.Generic;
using simpleAPI.Models;

namespace simpleAPI.DataRepository
{
    public class MockSimpleAPI : ISimpleAPIRepo
    {
        /*Note: Use this class only for testing purposes
           while the database hasn't been set yet
        */
        public IEnumerable<SimpleAPI> getAllData()
        {
            //hard-coded values for testing purposes
            var api = new List<SimpleAPI>
            {
               new SimpleAPI{Id = 100, Name = "Felly KANYIKI", JobTitle = "Software developer" , YearJoined = 2017},
               new SimpleAPI{Id = 110, Name = "Fanny ELONGAMA", JobTitle = "Accountant" , YearJoined = 2019},
               new SimpleAPI{Id = 215, Name = "Jovial KANYIKI" , JobTitle = "Mechanical engineer", YearJoined = 2018}
            };

            return api;
        }//end of getAllData method

        public SimpleAPI getDataById(int id)
        {
            //hard-coded values for testing purposes
            return new SimpleAPI
            {
                Id = 100,
                Name = "Felly KANYIKI",
                JobTitle = "Software developer",
                YearJoined = 2017
            };
        }//end of getDataById method

        public void UpdateSimpleApi(SimpleAPI api)
        {
            throw new System.NotImplementedException();
        }

        void ISimpleAPIRepo.CreateData(SimpleAPI api)
        {
            throw new System.NotImplementedException();
        }

        bool ISimpleAPIRepo.SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}