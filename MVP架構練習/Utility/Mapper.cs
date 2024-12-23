using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVP架構練習.Utility
{
    internal class Mapper
    {
        public static Dest Map<Source, Dest>(Source source, Action<IMappingExpression<Source, Dest>> action = null)
        {
            MapperConfiguration config = MapperConfigSetting(action);

            var mapper = config.CreateMapper();
            var result = mapper.Map<Source, Dest>(source);
            return result;
        }

        public static IEnumerable<Dest> Map<Source, Dest>(IEnumerable<Source> source, Action<IMappingExpression<Source, Dest>> action = null)
        {
            MapperConfiguration config = MapperConfigSetting(action);

            var mapper = config.CreateMapper();
            var result = mapper.Map<IEnumerable<Dest>>(source);
            return result;
        }

        private static MapperConfiguration MapperConfigSetting<Source, Dest>(Action<IMappingExpression<Source, Dest>> action)
        {
            var config = new MapperConfiguration(cfg =>
            {
                var expression = cfg.CreateMap<Source, Dest>();
                if (action != null)
                    action.Invoke(expression);
                expression.ReverseMap();
            });

            return config;
        }

    }
}
