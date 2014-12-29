//battery characteristics 
//(model, hours idle and hours talk)


using System;
using System.Text;



public enum BatteryType
{
    LiIon,
    Lipoly,
    NiMH,
    NiCd
}

    public class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        //Battery type from enumeration
        private BatteryType type;

        //Mandatory requirements | Constructor
        public Battery(string model)
        {
            this.model = model;
        }

        //Mandatory requirements + Hours idle | Constructor
        public Battery(string model, int hoursIdle)
            : this(model)
        {
            this.hoursIdle = hoursIdle;
        }

        //Mandatory requirements + Hours idle + Hours talk | Constructor
        public Battery(string model, int hoursIdle, int hoursTalk)
            : this(model, hoursIdle)
        {
            this.hoursTalk = hoursTalk;
        }

        //Mandatory requirements + Hours idle + Hours talk + Type | Constructor
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
            : this(model, hoursIdle, hoursTalk)
        {
            this.type = type;
        }

        //Properties of the Battery
        public string Model { get; set; }
        public int HoursIdle { get; set; }
        public int HoursTalk { get; set; }
        public BatteryType Type { get; set; }

        //Print Info of Battery | Method
        public override string ToString()
        {
            StringBuilder information = new StringBuilder();
            if (this.model != null) { information.Append("\nBattery Model : " + this.model); }
            if (this.type != null) { information.Append("\nattery Type : " + this.type); }
            if (this.hoursIdle != 0) { information.Append("\nBattery survival without talking : " + this.hoursIdle); }
            if (this.hoursTalk != 0) { information.Append("\nBattery survival when talking : " + this.hoursTalk); }
            return information.ToString();
        }
    }
