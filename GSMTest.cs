//7.
//Write a class GSMTest to test the GSM class:
//*Create an array of few instances of the GSM class.
//*Display the information about the GSMs in the array.
//*Display the information about the static property IPhone4S.



using System;
using System.Text;
using System.Collections.Generic;


    public class GSMTest
    {
        public static void Main()
        {
            //Create an array of few instances of the GSM class.
            List<GSM> GSMList = new List<GSM>();
            GSMList.Add(new GSM("Iphone4S", "Apple", "naskopicha", 1800, "AppleBattery", 15, 8, BatteryType.NiCd, 15, 2500));          
            GSMList.Add(new GSM("3310", "Nokia", "PoorPerson",200, "NokiaBattery", 3, 2, BatteryType.NiCd, 4, 200));
            //Display the information about the GSMs in the array

            for (int i = 0; i < GSMList.Count; i++)
            {
                Console.WriteLine(GSMList[i].ToString());
            }        
            //Display the information about the static property IPhone4S.
            GSM.IPhone4s = true;
            foreach (var mobile in GSMList)
            {

                if (mobile.Model == "Iphone4S") { Console.WriteLine("{0} : is iPhone4s: {1}\n", mobile.Model, GSM.IPhone4s); }
            }
        }
    }

