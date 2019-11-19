using System;
using System.Collections.Generic;
using System.Text;
using DatabaseModels;

namespace DataAccess.Repositories
{
    public interface IRepository<TModel, TKey> where TModel : IEntity<TKey>
    {
        IEnumerable<TModel> List { get; }
        void Add(TModel entity);
        void Delete(TModel entity);
        void Update(TModel entity);
        TModel FindById(TKey id);
    }
}
