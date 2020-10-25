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
        public IEnumerable<SimpleAPI> getAllData()
        {
            return ctx.MyData.ToList();
        }

        public SimpleAPI getDataById(int id)
        {
            return ctx.MyData.FirstOrDefault(x => x.Id == id);
        }
    }
}