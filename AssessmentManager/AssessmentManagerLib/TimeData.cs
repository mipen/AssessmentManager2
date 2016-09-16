using System;

namespace AssessmentManager
{
    [Serializable]
    public class TimeData
    {
        //The number of minutes for the assessment
        private int minutes = 60;
        private int readingMinutes = 0;
        private bool timeLocked = false;
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

        public bool TimeLocked
        {
            get
            {
                return timeLocked;
            }
            set
            {
                timeLocked = value;
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

        public bool HasReadingTime
        {
            get
            {
                return hasReadingTime;
            }
        }

        public bool Finished
        {
            get
            {
                return DateTime.Now >= FinishTime;
            }
        }

        public TimeSpan TimeRemaining
        {
            get
            {
                return FinishTime - DateTime.Now;
            }
        }

        #endregion

    }
}
