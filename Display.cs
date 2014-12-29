//display characteristics 
//(size and number of colors).

using System;
using System.Text;

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
        public override string ToString()
        {
            StringBuilder information = new StringBuilder();
            if (this.size != 0) { information.Append("\nSize of the display : " + this.size); }
            if (this.numberOfColors != 0) { information.Append("\nNumber of colors of the display : " + this.numberOfColors); }
            return information.ToString();
        }
    }


