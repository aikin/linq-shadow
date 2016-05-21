using System.Collections.Generic;
using Linq.Shadow.Common;
using Machine.Specifications;

namespace ProjectionOperators.Test
{

    [Subject("Projectioin Operators")]
    public class ProjectionOperatorsSpec
    {
        private Establish context = () =>
        {
            projectionOperators = new ProjectionOperator();
        };

        private Because Of = () => items = projectionOperators.PlusOneForEachItemLinq(DataProvider.GivenNumbers());

        private It should_return_right_count = () => items.Count.ShouldEqual(10);

        private static List<int> items;
        private static ProjectionOperator projectionOperators;
    }
}
