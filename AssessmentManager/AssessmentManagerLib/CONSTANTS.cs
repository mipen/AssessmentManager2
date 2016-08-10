﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    public static class CONSTANTS
    {
        public static readonly string ASSESSMENT_EXT = ".exm";
        public static readonly string ASSESSMENT_SCRIPT_EXT = ".exms";
        public static readonly string XML_EXT = ".xml";

        public static readonly string ASSESSMENT_FILTER = $"Assessment Files (*{ASSESSMENT_EXT}) | *{ASSESSMENT_EXT}";
        public static readonly string ASSESSMENT_SCRIPT_FILTER = $"Assessment Script Files (*{ASSESSMENT_SCRIPT_EXT}) | *{ASSESSMENT_SCRIPT_EXT}";
        public static readonly string COMBINED_FILTER = $"Assessment Files (*{ASSESSMENT_EXT}; *{ASSESSMENT_SCRIPT_EXT}) | *{ASSESSMENT_EXT}; *{ASSESSMENT_SCRIPT_EXT}";
        public static readonly string XML_FILTER = $"XML Document (*{XML_EXT}) | *{XML_EXT}";

        public static string DESKTOP_PATH = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string DOCUMENTS_PATH = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static readonly DateTime UNPLANNED = new DateTime(1975, 1, 1, 1, 1, 1, 1);

        public static string AUTOSAVE_FOLDER_NAME(string assessmentName)
        {
            return $"{assessmentName}_autosaves";
        }
    }
}
