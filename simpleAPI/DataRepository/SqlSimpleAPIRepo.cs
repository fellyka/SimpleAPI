using System;
using System.Collections.Generic;
using System.Linq;
using simpleAPI.Models;

namespace simpleAPI.DataRepository
{
    public class SqlSimpleAPIRepo : ISimpleAPIRepo
    {
        private readonly SimpleAPIDbContext ctx;
        public SqlSimpleAPIRepo(SimpleAPIDbContext ctx)
        {
            this.ctx = ctx;
        }

        public void CreateData(SimpleAPI api)
        {
            if (api == null) // if null, throw an exception
                 throw new ArgumentNullException(nameof(api));
            ctx.MyData.Add(api); //Add data if api has value
        }

        public IEnumerable<SimpleAPI> getAllData()
        {
            return ctx.MyData.ToList();
        }

        public SimpleAPI getDataById(int id)
        {
            return ctx.MyData.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            //If method returns a positive vlue, change is effective
            return (ctx.SaveChanges() >= 0);
        }

        public void UpdateSimpleApi(SimpleAPI api)
        {
            //Noting
        }
    }
}