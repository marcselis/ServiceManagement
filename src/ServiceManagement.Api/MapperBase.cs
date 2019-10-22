using System.Collections.Generic;

namespace ServiceManagement.Api
{
    internal abstract class MapperBase<TIn, TOut> : IMapper<TIn, TOut> where TIn:class where TOut:class
    {
        public abstract TOut Map(TIn? input);

        public IEnumerable<TOut> MapAll(IEnumerable<TIn>? input)
        {
            if (input == null) yield break;
            foreach(var val in input)
            {
                var item = Map(val);
                if (item != null)
                    yield return item;
            }
        }
    }
}