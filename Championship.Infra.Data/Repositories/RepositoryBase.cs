using Championship.Domain.Interfaces;
using System;
using System.Collections.Generic;
using Championship.Infra.Data.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Threading.Tasks;

namespace Championship.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        private IFirebaseClient client;

        public void Connect()
        {
            FireBaseConnectConfig connect = new FireBaseConnectConfig();
            this.client = connect.Connect();
        }

        public async void Add(TEntity obj)
        {   
            SetResponse response = await this.client.SetAsync("todos/set", obj);

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
