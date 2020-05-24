using System.Data;

namespace NPSBS.Core
{
    public interface ICrud<T> where T : class
    {
        int Save(T obj);

        int Update(T obj);

        int Delete(int Id);

        DataTable Select();

        DataTable SelectById(int id);
    }
}
