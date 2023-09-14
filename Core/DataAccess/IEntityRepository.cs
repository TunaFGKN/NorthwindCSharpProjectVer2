using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//Core katmanı diğer katmanları referans almaz

namespace Core.DataAccess
{
    //Generic Constraint: T'yi kısıtlıyoruz
    //T referans tip olabilir diye kısıtladık ve IEntity veya onu implemente eden bir şey olabilir diye kısıtladık sonra new'lenebilir olmalı dedik
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //Databaseden verileri çekmek, filtre vermiyorsa tümünü getirir filtre verirse uyanları getirir
        T Get(Expression<Func<T, bool>> filter); //Databaseden tek bir veriyi çekme, filtre vermek zorunlu (null değil)
        void Add(T entity); //Databaseye veri ekleme
        void Update(T entity); //Databaseden veri güncelleme
        void Delete(T entity); //Databaseden veri silme     
    }
}
