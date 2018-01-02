using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.frm.ui.web.controller.ViewModel;
using demo.frm.infrastructure;
using demo.frm.infrastructure.Adapter;

namespace demo.frm.ui.web.controller.Extensions
{
    public static class AdapterExtensions
    {
        public static TProjection Traduzir<TProjection>(this EntityBase item)
            where TProjection : class, new()
        {
            var adapter = TypeAdapterFactory.CreateAdapter();
            return adapter.Adapt<TProjection>(item);
        }

        public static List<TProjection> TraduzirLista<TProjection>(this IEnumerable<EntityBase> items)
            where TProjection : class, new()
        {
            var adapter = TypeAdapterFactory.CreateAdapter();
            return adapter.Adapt<List<TProjection>>(items);
        }

        public static TProjection Traduzir<TProjection>(this ViewModelBase item)
            where TProjection : class, new()
        {
            var adapter = TypeAdapterFactory.CreateAdapter();
            return adapter.Adapt<TProjection>(item);
        }

        public static List<TProjection> TraduzirLista<TProjection>(this IEnumerable<ViewModelBase> items)
            where TProjection : class, new()
        {
            var adapter = TypeAdapterFactory.CreateAdapter();
            return adapter.Adapt<List<TProjection>>(items);
        }
    }
}
