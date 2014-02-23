using System;

namespace InvalidRange
{
    public class InvalidRangeException<T> : ApplicationException
    {
        string message = "The value is out of the range.";
        public string Message
        {
            get
            {
                return this.message;
            }
            set
            {
                this.message = value;
            }
        }

        public T Start { get; set; }

        public T End { get; set; }

        public InvalidRangeException(string msg, T start, T end)
            : base(string.Format(msg + "[{0} ... {1}]", start, end))
        {
            this.Start = start;
            this.End = end;
        }
    }
}
