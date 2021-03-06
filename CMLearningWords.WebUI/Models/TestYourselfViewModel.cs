﻿using CMLearningWords.DataModels.Models;
using CMLearningWords.WebUI.Enums;
using CMLearningWords.WebUI.HelpAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMLearningWords.WebUI.Models
{
    public class GenerateTestYourselfViewModel
    {
        [MinValue(5, ErrorMessage = "Нельзя ниже 5")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        public int Number { get; set; }
    }

    public class CreatedTestYourselfViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<TranslationOfWord> TranslationOfWords { get; set; }

        [Required(ErrorMessage = "Поля обязательно для заполнения")]
        public string NameOfCurrentInputTranslation { get; set; }

        public ExeptionInTranslation MadeMistake { get; set; } = ExeptionInTranslation.WithMistake;
    }
}
