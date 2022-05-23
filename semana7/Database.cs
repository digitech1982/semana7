using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace semana7
{
    public interface Database
    {
        SQLiteAsyncConnection GetConnection();//Implementacion en cada proyecto Android,iOS

    }
}
