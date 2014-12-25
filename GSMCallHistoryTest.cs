//12.
//Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
//Create an instance of the GSM class.
//Add few calls.
//Display the information about the calls.
//Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
//Remove the longest call from the history and calculate the total price again.
//Finally clear the call history and print it.


using System;
using System.Text;
using System.Collections.Generic;

public class GSMCallHistoryTest
{
    public static void Main()
    {
        //Create an instance of the GSM class.
        GSM Telefonche = new GSM("Iphone 4S", "Apple", "naskopicha", 1000, null, 10, 8, BatteryType.LiIon, 0, 1000000);

        //Add few calls.
        DateTime currentDateAndTime = DateTime.Now;
        DateTime currentDateAndTime2 = new DateTime(2014, 12, 15, 15, 20, 34);
        DateTime currentDateAndTime3 = new DateTime(2014, 12, 12, 15, 10, 23);
        Telefonche.AddCall(currentDateAndTime, 0897861603, 120);
        Telefonche.AddCall(currentDateAndTime2, 0899135151, 40);
        Telefonche.AddCall(currentDateAndTime3, 0899135353, 400);

        //Display the information about the calls.
        for (int i = 0; i < Telefonche.CallHistory.Count; i++)
        {
            Telefonche.CallHistory[i].PrintCallInfo();
            Console.WriteLine();
        }
        Console.WriteLine();

        //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        Console.WriteLine("The servise costs {0} for a 0.37 price per minute.", Telefonche.CalculateCallPrice(0.37m));
        Console.WriteLine();


        //Remove the longest call from the history and calculate the total price again.
        string longestCallNumber = null;
        int longestCallDuration = 0;
        for (int i = 0; i < Telefonche.CallHistory.Count; i++)
        {
            if (Telefonche.CallHistory[i].Duration > longestCallDuration)
            {
                longestCallNumber = Telefonche.CallHistory[i].DialedNumber.ToString();
            }
        }
        Telefonche.DeleteCall(longestCallNumber);
        Console.WriteLine("The servise costs {0} for a 0.37 price per minute.", Telefonche.CalculateCallPrice(0.37m));
        Console.WriteLine();

        //Finally clear the call history and print it.
        Telefonche.ClearHistory();
        //Print calls | expect nothing to be printed
        for (int i = 0; i < Telefonche.CallHistory.Count; i++)
        {
            Telefonche.CallHistory[i].PrintCallInfo();
            Console.WriteLine();
        }
        Console.WriteLine();

    }
}

