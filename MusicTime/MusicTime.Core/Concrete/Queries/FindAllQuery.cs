using System;
using System.Linq.Expressions;

namespace MusicTime.Core.Concrete.Queries
{
    public class FindAllQuery<T>
    {
        public FindAllQuery()
        {

        }

        public FindAllQuery(Expression<Func<T, bool>> lambdaFilter)
        {
            LambdaFilter = lambdaFilter;
        }

        public Expression<Func<T, bool>> LambdaFilter { get; private set; }
    }
}