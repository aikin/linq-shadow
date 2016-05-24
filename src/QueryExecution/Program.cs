using Linq.Shadow.Common;

namespace QueryExecution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var queryExecution = new QueryExecution();

            /*
                The following sample shows how query execution is deferred until the query is enumerated at a foreach statement.
            */
            queryExecution.DeferredExecution(DataProvider.GivenNumbers());


            /*
               The following sample shows how, because of deferred execution, queries can be used again after data changes and will then operate on the new data.
           */
            queryExecution.QueryReuse(DataProvider.GivenNumbers());            
            
            
            /*
                The following sample shows how queries can be executed immediately, and their results stored in memory, with methods such as ToList.
            */
            queryExecution.ImmediateExecution(DataProvider.GivenNumbers());
        }
    }
}
