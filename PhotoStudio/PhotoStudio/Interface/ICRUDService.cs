﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoStudio.Interface
{
   public interface ICRUDService<TModel,Tsearch,TInsert,TUpdate>:IService<TModel,Tsearch>
    {
        TModel Insert(TInsert request);
        TModel Update(int id, TUpdate request);
        void Delete(int id);

    }
}