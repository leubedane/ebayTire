﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EbaySeller.Model.Source.Data.Interfaces;

namespace EbaySeller.ViewModel.Source.Filter
{
    public class WinterFilterCriteria: IFilterCriteria<IWheel>
    {
        public bool IsInFilter(IWheel article)
        {
            return article.IsWinter;
        }
    }
}