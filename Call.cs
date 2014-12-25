//Create a class Call to hold a call performed through a GSM. 
//It should contain date, time, dialed phone number and duration (in seconds).




using System;

    public class Call
    {
        //Fields
        private DateTime callDateAndTime;
        private int dialedNumber;
        private int duration;

        //Properties
        public DateTime CallDateAndTime { get; set; }
        public int DialedNumber { get; set; }
        public int Duration { get ; set; }

        //Constructor
        public Call(DateTime datetime,int dailednumber,int duration)
        {
            this.callDateAndTime = datetime;
            this.dialedNumber = dailednumber;
            this.duration = duration;
        }
        //Print Call | Method
        public void PrintCallInfo()
        {
            Console.WriteLine("Call was made on : {0}",this.callDateAndTime);
            Console.WriteLine("You dialed : {0}",this.dialedNumber);
            Console.WriteLine("You talked : {0} seconds",this.duration);
        }

    }

