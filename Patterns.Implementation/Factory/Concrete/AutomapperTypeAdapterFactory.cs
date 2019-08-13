﻿using System;
using System.Linq;
using AutoMapper;

namespace Patterns.Factory.Concrete
{
    public class AutomapperTypeAdapterFactory
            : ITypeAdapterFactory
    {
        #region Constructor

        /// <summary>
        /// Create a new Automapper type adapter factory
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            //scan all assemblies finding Automapper Profile
            var assys = AppDomain.CurrentDomain.GetAssemblies();

            var profiles = assys.SelectMany(a => a.GetTypes())
                .Where(t => t.BaseType == typeof(Profile));

            Mapper.Initialize(cfg =>
            {
                foreach (var item in profiles)
                {
                    if (item.Name == "TestProfile")
                        cfg.AddProfile(Activator.CreateInstance(item) as Profile);
                }
            });
        }

        #endregion

        #region ITypeAdapterFactory Members

        public ITypeAdapter Create()
        {
            return new AutomapperTypeAdapter();
        }

        #endregion
    }
}
