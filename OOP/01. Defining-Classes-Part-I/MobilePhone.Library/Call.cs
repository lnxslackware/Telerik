using System;

namespace MobilePhone.Library
{
    class Call
    {
        private DateTime date;
        private TimeSpan time;
        private string dialedPhoneNumber;
        private uint duration;

        public Call(string dialedNumber, uint duration)
        {
            this.date = DateTime.Now.Date;
            this.time = DateTime.Now.TimeOfDay;
            this.dialedPhoneNumber = dialedNumber;
            this.duration = duration;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }
        }

        public TimeSpan Time
        {
            get
            {
                return this.time;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
        }

        public uint Duration
        {
            get
            {
                return this.duration;
            }
        }
    }
}
