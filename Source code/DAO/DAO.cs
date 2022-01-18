using QLXM.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace QLXM.DAO
{
    public interface DAO<T>
    {
        T get(long id);

        List<T> getAll();

        bool Insert(T t);

        bool Update(T t);

        bool Delete(T t);
    }
}
