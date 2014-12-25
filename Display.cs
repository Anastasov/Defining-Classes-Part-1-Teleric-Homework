//display characteristics 
//(size and number of colors).

using System;


    public class Display
    {
        private decimal size;
        private int numberOfColors;


        //Mandatory requirements for a display | Constructor
        public Display(decimal size)
        {
            this.size = size;
        }
        //Mandatory requirements for a display + number of colors | Constructor
        public Display(decimal size, int numberOfColors)
            : this(size)
        {
            this.numberOfColors = numberOfColors;
        }

        //Properties of the Display
        public decimal Size { get; set; }
        public int NumberOfColors { get; set; }

        //Print Info for Display
        public void PrintDisplayInfo()
        {
            if (this.size != 0) { Console.WriteLine("Size of the display : {0}", this.size); }
            if (this.numberOfColors != 0) { Console.WriteLine("Number of colors of the display : {0}", this.numberOfColors); }
        }
    }


