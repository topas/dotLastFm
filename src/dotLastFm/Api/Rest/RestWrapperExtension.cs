//-----------------------------------------------------------------------
// <copyright file="RestWrapperExtension.cs" company="IxoneCz">
//  Copyright (c) 2011 Tomas Pastorek, www.Ixone.Cz. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotLastFm.Api.Rest
{
    /// <summary>
    /// Rest wrapper extensions
    /// </summary>
    public static class RestWrapperExtension
    {
        /// <summary>
        /// Methods the specified wrapper.
        /// </summary>
        /// <param name="wrapper">The wrapper.</param>
        /// <param name="method">The method.</param>
        /// <returns>Fluent wrapper</returns>
        public static FluentRestWrapper Method(this RestWrapper wrapper, string method)
        {
            return new FluentRestWrapper(wrapper, method);
        }
    }
}
