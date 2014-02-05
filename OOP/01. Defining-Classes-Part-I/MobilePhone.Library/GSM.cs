using System;
using System.Collections.Generic;
using System.Text;

namespace MobilePhone.Library
{
    public class GSM
    {
        private string manufacturer;
        private string model;
        private int? price;
        private string owner;
        private List<Call> callHistory = new List<Call>();
        private Battery battery;
        private Display display;
        private static GSM iPhone4S = new GSM("iPhone", "4S", 1300, "LnX", new Battery("53GAK3", BatteryType.LiIon), new Display(3.5, 16));

        public GSM(string manufacturer, string model)
            : this(manufacturer, model, null, null, null, null)
        {

        }

        public GSM(string manufacturer, string model, int? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;            
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid manufacturer.");
                }

                this.manufacturer = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid model.");
                }

                this.model = value;
            }
        }

        public int? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than zero.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        private List<Call> CallHistory
        {
            get
            {
                return callHistory;
            }

            set
            {
                callHistory = value;
            }
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }

        public void AddCall(uint calledNumber, uint duration)
        {
            List<Call> currentCalls = CallHistory;
            currentCalls.Add(new Call(calledNumber, duration));
            CallHistory = currentCalls;
        }

        public void DeleteCall(int callId)
        {
            List<Call> currentCalls = CallHistory;
            currentCalls.RemoveAt(callId);
            CallHistory = currentCalls;
        }

        public void PrintCallHistory()
        {
            int counter = 0;
            foreach (var call in CallHistory)
            {
                Console.WriteLine("ID: {0}", counter);
                Console.WriteLine("Date: {0} Time: {1}", call.Date, call.Time);
                Console.WriteLine("Phone number: {0}", call.DialedPhoneNumber);
                Console.WriteLine("Duration: {0}", call.Duration);
                Console.WriteLine(new string('-', 20));
            }
        }

        public void ClearCalls()
        {
            CallHistory = new List<Call>();
        }

        public decimal CalculateTotalCallPrice(decimal callPrice)
        {
            long totalMinutes = 0;

            foreach (var call in CallHistory)
            {
                totalMinutes += call.Duration;
            }

            int reminder = (int)(totalMinutes % 60);
            totalMinutes = totalMinutes / 60;

            if (reminder > 0)
            {
                totalMinutes++;
            }

            return totalMinutes * callPrice;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Mobile phone info:");
            info.AppendLine(string.Format("Manufactufer: {0}", Manufacturer));
            info.AppendLine(string.Format("Model: {0}", Model));
            info.AppendLine(string.Format("Price: {0}", Price.ToString() ?? "Unknown"));
            info.AppendLine(string.Format("Owner: {0}", Owner ?? "Unknown"));
            if (battery != null)
            {
                info.AppendLine("Battery Info:");
                info.AppendLine(string.Format("Model: {0}", battery.Model ?? "Unknown"));
                info.AppendLine(string.Format("Type: {0}", battery.Type));
                info.AppendLine(string.Format("Hours Idle: {0}", battery.HoursIdle.ToString() ?? "Unknown"));
                info.AppendLine(string.Format("Hours Talk: {0}", battery.HoursTalk.ToString() ?? "Unknown"));
            }

            if (display != null)
            {
                info.AppendLine("Display Info:");
                info.AppendLine(string.Format("Size: {0}\"", display.Size.ToString() ?? "Unknown"));
                info.AppendLine(string.Format("Colors: {0}", display.Colors.ToString() ?? "Unknown"));
            }

            info.AppendLine(new string('-', 20));

            return info.ToString();
        }
    }
}
