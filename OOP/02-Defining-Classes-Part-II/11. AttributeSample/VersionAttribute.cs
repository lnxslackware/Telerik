using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeSample
{
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class |
        AttributeTargets.Interface | AttributeTargets.Enum |
        AttributeTargets.Method, AllowMultiple = false)]
    public class VersionAttribute : Attribute
    {
        private int minor;
        private int major;
        public int Major
        {
            get
            {
                return this.major;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The version cannot have negative numbers in it.");
                }

                this.major = value;
            }
        }
        public int Minor
        {
            get
            {
                return this.minor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The version cannot have negative numbers in it.");
                }

                this.minor = value;
            }
        }

        public VersionAttribute(string version)
        {
            string[] versionMinorAndMajor = version.Split('.');
            Major = int.Parse(versionMinorAndMajor[0]);
            Minor = int.Parse(versionMinorAndMajor[1]);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("{0}.{1}", this.Major, this.Minor));
            return result.ToString();
        }
    }
}
