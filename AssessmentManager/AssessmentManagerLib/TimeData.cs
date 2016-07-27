using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentManager
{
    [Serializable]
    public class TimeData
    {
        private DateTime plannedDate;
        private bool dateIsPlanned = false;

        //The number of minutes for the assessment
        private int minutes = 0;
        private int readingMinutes = 0;
        private bool minutesArePlanned = false;

        //The time that the user started the assessment
        public DateTime TimeStarted;

        public TimeData()
        {

        }

        public bool MinutesArePlanned
        {
            get
            {
                return minutesArePlanned;
            }
            set
            {
                minutesArePlanned = value;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                minutes = value;
            }
        }

        public int ReadingMinutes
        {
            get
            {
                return readingMinutes;
            }
            set
            {
                readingMinutes = value;
            }
        }

        public DateTime PlannedDate
        {
            get
            {
                return plannedDate;
            }
            set
            {
                plannedDate = value;
            }
        }

        public bool DateIsPlanned
        {
            get
            {
                return dateIsPlanned;
            }
            set
            {
                dateIsPlanned = value;
            }
        }

    }
}
