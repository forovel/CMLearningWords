﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMLearningWords.AccessToData.Context;
using CMLearningWords.AccessToData.Repository.Interfaces;
using CMLearningWords.DataModels.Models;

namespace CMLearningWords.AccessToData.Repository.Classes
{
    public class StageOfMethodRepository : Repository<StageOfMethod>, IStageOfMethodRepository
    {
        public StageOfMethodRepository(ApplicationContext context) : base(context) { }

        public StageOfMethod GetOne(long id)
        {
            return Context.StageOfMethods.Find(id) ?? null;
        }

    }
}
