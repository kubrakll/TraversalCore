using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {

        //neden genericDal kullandık?
        //Birden fazla entitilerimizin CRUD işlemlerini tek tek yazmamak adına bir çatıda yazıyoruz 

        void Insert(T t); //Ekleme

        void Delete(T t); //Silme

        void Update(T t); //Güncelleme

        List<T> GetList(); //Listeleme

        T GetByID(int id);

        List<T> GetListByFilter(Expression<Func<T,bool>>filter); //Şartlı listeleme
    }
}
