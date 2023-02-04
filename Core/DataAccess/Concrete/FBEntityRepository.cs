using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Abstract
{
    public class FBEntityRepository<TEntity, TConfig> : IEntityRepository<TEntity>
        where TEntity : class, IEntity , new()
        where TConfig : FBConfig, new()
    {
        public IFirebaseClient client;
        public FBEntityRepository()
        {
            TConfig config = new TConfig();
            IFirebaseConfig _config = new FirebaseConfig
            {
                AuthSecret = config.AuthSecret,
                BasePath = config.BasePath
            };
            this.client = new FireSharp.FirebaseClient(_config);
        }
        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null)
        {
            var response = client.Get("");
            Dictionary<string, TEntity> responseAS = response.ResultAs<Dictionary<string, TEntity>>();
            List<TEntity> entityList = new List<TEntity>();
            foreach (var entity in responseAS)
            {
                entityList.Add(entity.Value);
            }
            return entityList;
        }
    }
}
