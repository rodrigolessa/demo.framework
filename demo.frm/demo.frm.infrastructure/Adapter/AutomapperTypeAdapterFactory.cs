using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace demo.frm.infrastructure.Adapter
{
    public class AutomapperTypeAdapterFactory : ITypeAdapterFactory
    {
        #region Constructor

        /// <summary>
        /// Create a new Automapper type adapter factory
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(s => s.FullName.StartsWith("demo."));
            List<Type> types = new List<Type>();

            assemblies.ToList().ForEach(s =>
                types.AddRange(s.GetTypes().AsEnumerable<Type>())
            );

            //scan all assemblies finding Automapper Profile
            var profiles = types.Where(s => s.BaseType == typeof(Profile));

            Mapper.Initialize(cfg =>
            {
                foreach (var item in profiles)
                {
                    if (item.FullName != "AutoMapper.SelfProfiler`2")
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