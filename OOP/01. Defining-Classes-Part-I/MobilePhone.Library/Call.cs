using System;

namespace MobilePhone.Library
{
    class Call
    {
        private DateTime date;
        private TimeSpan time;
        private uint dialedPhoneNumber;
        private uint duration;

        public Call(uint dialedNumber, uint duration)
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

        public uint DialedPhoneNumber
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
