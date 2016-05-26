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
            joinOperators.CrossJoinByCategoriesLinq(DataProvider.GivenProducts());

            /*
                A left outer join produces a result set that includes all the left hand side elements 
                at least once, even if they don't match any right hand side elements.
            */
            joinOperators.LeftOuterJoinByCountryLambda(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());
            joinOperators.LeftOuterJoinByCountryLinq(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());


            /*
                For each customer in the table of customers, this query returns all the suppliers 
                from that same country, or else a string indicating that no suppliers from that country were found.
            */
            joinOperators.LeftOuterJoinByCountryForEachCustomerLambda(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());
            joinOperators.LeftOuterJoinByCountryForEachCustomerLinq(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());

            /*
                For each supplier in the table of suppliers, this query returns all the customers 
                from the same city and country, or else a string indicating that no customers from that city/country were found. 
                Note the use of anonymous types to encapsulate the multiple key values.
            */
            joinOperators.LeftOuterJoinByCountryAndCityForEachCustomerLambda(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());
            joinOperators.LeftOuterJoinByCountryAndCityForEachCustomerLinq(DataProvider.GivenCustomers(), DataProvider.GivenSuppliers());
        }
    }
}
