using AutoMapper;

namespace Patterns.Factory.Concrete
{
    /// <summary>
    /// Automapper type adapter implementation
    /// </summary>
    public class AutomapperTypeAdapter
        : ITypeAdapter
    {
        #region ITypeAdapter Members

        /// <summary>
        /// <see cref="Patterns.Factory.ITypeAdapter"/>
        /// </summary>
        /// <typeparam name="TSource"><see cref="Patterns.Factory.ITypeAdapter"/></typeparam>
        /// <typeparam name="TTarget"><see cref="Patterns.Factory.ITypeAdapter"/></typeparam>
        /// <param name="source"><see cref="Patterns.Factory.ITypeAdapter"/></param>
        /// <returns><see cref="Patterns.Factory.ITypeAdapter"/></returns>
        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, new()
        {
            return Mapper.Map<TSource, TTarget>(source);
        }

        /// <summary>
        /// <see cref="Patterns.Factory.ITypeAdapter"/>
        /// </summary>
        /// <typeparam name="TTarget"><see cref="Patterns.Factory.ITypeAdapter"/></typeparam>
        /// <param name="source"><see cref="Patterns.Factory.ITypeAdapter"/></param>
        /// <returns><see cref="Patterns.Factory.ITypeAdapter"/></returns>
        public TTarget Adapt<TTarget>(object source) where TTarget : class, new()
        {
            return Mapper.Map<TTarget>(source);
        }

        #endregion
    }
}
