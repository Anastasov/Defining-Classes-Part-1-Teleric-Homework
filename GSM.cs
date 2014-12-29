//model, manufacturer, price, owner

//4.
//Add a method in the GSM class for displaying all information about it. 
//Try to override ToString().



using System;
using System.Text;
using System.Collections.Generic;


    public class GSM
    {
        //Fields
        private string model;
        private string manufacturer;
        private string owner;
        private decimal price;
        private Battery battery;
        private Display display;
        private static bool iPhone4S;
        public List<Call> CallHistory = new List<Call>();

        //Basic Properties of the GSM
        public string Model
        {
            get { return this.model; }
            set
            {
                if ((value.Length >= 0 && value.Length <= 9999) || (value.Length == 0))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Manufacturer 
        {
            get { return this.manufacturer; }
            set
            {
                if ((value.Length >= 0 && value.Length <= 9999) || (value.Length == 0))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public string Owner 
        {
            get { return this.owner; }
            set
            {
                if ((value.Length >= 0 && value.Length <= 9999) || (value.Length == 0))
                {
                    this.owner = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if ((value >= 0 && value <= 9999) || value == 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
        public Display Display { get {return this.display;} set{this.display = value;}}

        public Battery Battery { get; set; }


        //Iphone 4S properties | static
        public static bool IPhone4s
        {
            get { return iPhone4S; }
            set
            {
                iPhone4S = value;
            }
        }


        #region Constructors
        //Mandatory constructor | Constructor
        public GSM(string model, string manufacturer)
        {
            this.manufacturer = manufacturer;
            this.model = model;
        }

        //Mandatory constructor + Owner | Constructor
        public GSM(string manufacturer, string model, string owner)
            : this(manufacturer, model)
        {
            this.owner = owner;
        }

        //Mandatory constructor + Owner + Price | Constructor
        public GSM(string manufacturer, string model, string owner, decimal price)
            : this(manufacturer, model, owner)
        {
            this.price = price;
        }

        //Mandatory constructor + Owner + Price + Battery| Constructor
        public GSM(string manufacturer, string model, string owner, decimal price,string batteryModel, int hoursIdle,
            int hoursTalk, BatteryType type)
            : this(manufacturer, model, owner, price)
        {
            this.battery = new Battery(batteryModel, hoursIdle, hoursTalk, type);
        }

        
        //Full Constructor
        public GSM(string manufacturer, string model, string owner, decimal price,string batteryModel, int hoursIdle,
            int hoursTalk, BatteryType type, decimal size,int numberOfColors)
            : this(manufacturer, model, owner, price, batteryModel, hoursIdle,hoursTalk, type)
        {
            this.Display = new Display(size,numberOfColors);
        }
        #endregion


        //Display Information about the GSM (Override ToString())| Method
        public override string ToString()
        {
            StringBuilder information = new StringBuilder();
            if (this.model != null) { information.Append("Model : " + this.model); }
            if (this.manufacturer != null) { information.Append("\n" + "Manufacturer : " + this.manufacturer); }
            if (this.owner != null) { information.Append("\n" + "Owner : " + this.owner); }
            if (this.price != 0) { information.Append("\n"+"Price : " + this.price); }
            information.Append(this.battery.ToString());
            information.Append(this.display.ToString());
            information.Append("\n=============\n");
            return information.ToString();
        }

        //Call History

        //Add Call | Method
        public void AddCall(DateTime datetime, int dailednumber, int duration)
        {
            CallHistory.Add(new Call(datetime, dailednumber, duration));
        }

        //Delete Call | Method
        public void DeleteCall(string dialedNumber)
        {
            int callIndex = 0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                if (CallHistory[i].DialedNumber.ToString() == dialedNumber)
                {
                    callIndex = i;
                }
            }
            CallHistory.RemoveAt(callIndex);
        }

        //Clear History | Method
        public void ClearHistory()
        {
            CallHistory.Clear();
        }

        //Service Price | Method
        public decimal CalculateCallPrice(decimal pricePerMinute)
        {
            decimal priceResult = 0;
            for (int i = 0; i < this.CallHistory.Count; i++)
            {
                 priceResult += (this.CallHistory[i].Duration / 60) * pricePerMinute;
            }
            return priceResult;
        }

    }

