using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp14NewFeatures
{

    public static class EnumerableExtensions
    {

        //Extension block for IEnumerable<TSource> below

        extension<TSource>(IEnumerable<TSource> source)
        {
            //Extension property using getter block syntax
            public bool IsEmpty
            {
                get
                {
                    return !source.Any();
                }
            }

            //Extension property with expression body (more compact syntax)
            public bool HasItems => source.Any();

            // Extension method:
            public IEnumerable<TSource> Filter(Func<TSource, bool> predicate) { 
             return source.Where(predicate); //just an alias for Where ..            
            }

        }

        //Extension block with receiver type only. (skipping the variable name source below is the difference, also the members must be static 
        extension<TSource>(IEnumerable<TSource>)
        {
            //static extension property 
            public static IEnumerable<TSource> Identity => Enumerable.Empty<TSource>();

            //static user defined operator +
            public static IEnumerable<TSource> operator + (IEnumerable<TSource> first, IEnumerable<TSource> second) => first.Concat(second);

            //static user defined operator -
            public static IEnumerable<TSource> operator - (IEnumerable<TSource> first, IEnumerable<TSource> second) => first.Except(second);
        }



    }

}
