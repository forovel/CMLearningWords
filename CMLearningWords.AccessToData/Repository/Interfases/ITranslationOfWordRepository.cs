﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMLearningWords.DataModels.Models;

namespace CMLearningWords.AccessToData.Repository.Interfaces
{
    public interface ITranslationOfWordRepository : IRepository<TranslationOfWord>
    {
        TranslationOfWord GetOne(long id);
    }
}
