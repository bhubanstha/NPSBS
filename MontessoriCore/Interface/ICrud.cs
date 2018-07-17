using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Montessori.Core
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
