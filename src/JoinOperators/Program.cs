using Linq.Shadow.Common;

namespace JoinOperators
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var joinOperators = new JoinOperators();

            /*
                This sample shows how to perform a simple inner equijoin of two sequences to produce 
                a flat result set that consists of each element in suppliers that has a matching element in customers.
            */
            joinOperators.InnerJoinTwoSequencesLambda(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());
            joinOperators.InnerJoinTwoSequencesLinq(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());


            /*
                A group join produces a hierarchical sequence. 
                The following query is an inner join that produces a sequence of objects, 
                each of which has a key and an inner sequence of all matching elements.
            */
            joinOperators.GroupJoinTwoSequencesLambda(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());
            joinOperators.GroupJoinTwoSequencesLinq(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());


            /*
                The group join operator is more general than join, as this slightly more verbose 
                version of the cross join sample shows.
            */
            joinOperators.CrossJoinByCategoriesLambda(DataProvider.GivenProducts());
            joinOperators.GroupJoinTwoSequencesLinq(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());


        }
    }
}
