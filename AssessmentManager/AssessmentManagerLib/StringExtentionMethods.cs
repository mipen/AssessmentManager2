﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public static class StringExtentionMethods
    {
        public static bool NullOrEmpty(this string str)
        {
            if (str == null || str == "")
                return true;
            return false;
        }
    }
}
