﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Factory
{
    /// <summary>
    /// Base contract for adapter factory
    /// </summary>
    public interface ITypeAdapterFactory
    {
        /// <summary>
        /// Create a type adater
        /// </summary>
        /// <returns>The created ITypeAdapter</returns>
        ITypeAdapter Create();
    }
}
