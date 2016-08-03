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
        private bool dateIsPlanned = false;

        //The number of minutes for the assessment
        private int minutes = 0;
        private int readingMinutes = 0;
        private bool minutesArePlanned = false;
        private bool hasReadingTime = false;

        //The time that the user started the assessment
        public DateTime StartTime;
        //Time that the assessment will finish
        public DateTime FinishTime;
        //Time that reading time will finish
        public DateTime ReadingFinishTime;

        public TimeData()
        {

        }

        #region Properties

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
                if (readingMinutes > 0)
                    hasReadingTime = true;
                else
                    hasReadingTime = false;
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

        public bool HasReadingTime
        {
            get
            {
                return hasReadingTime;
            }
        }

        #endregion

    }
}
