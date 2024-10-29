using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
       

    }

    public static int[] AllocateRooms(int[][] customers)
    {
        List<int> Results = new();
        List<int> RoomAvailabiltyDay = new();
        //Logic
        for (int i = 0; i < customers.Length; i++)
        {
            if (RoomAvailabiltyDay.Count == 0)
            {
                Results.Add(1);
                RoomAvailabiltyDay.Add(customers[i][1]);

            }
            else
            {
                bool RoomFound = false;
                for (int j = 0; j < RoomAvailabiltyDay.Count; j++)
                {
                    if (customers[i][0] > RoomAvailabiltyDay[j])
                    {
                        Results.Add(j + 1);
                        RoomAvailabiltyDay[j] = customers[i][1];
                        RoomFound = true;
                        break;
                    }

                }
                //No available room
                if (RoomFound == false)
                {
                    Results.Add(RoomAvailabiltyDay.Count + 1);
                    RoomAvailabiltyDay.Add(customers[i][1]);
                }
            }
        }
        return Results.ToArray();
    }
}
