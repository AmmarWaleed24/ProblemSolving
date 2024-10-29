using System;
using System.Collections.Generic;
using System.Linq;

public class HotelRoomAllocator
{
    public static int[] AllocateRooms(int[][] customers)
    {
        // Sorting customers by arrival day to allocate rooms in order
        var sortedCustomers = customers.Select((c, index) => new { arrival = c[0], departure = c[1], index })
                                       .OrderBy(c => c.arrival)
                                       .ToArray();

        // Lists to store the result and room availability
        List<int> results = new();
        List<int> roomAvailabilityDay = new();
        
        foreach (var customer in sortedCustomers)
        {
            int arrival = customer.arrival;
            int departure = customer.departure;
            int customerIndex = customer.index;

            bool roomFound = false;
            
            // Check if there's an available room
            for (int j = 0; j < roomAvailabilityDay.Count; j++)
            {
                if (arrival > roomAvailabilityDay[j]) // Room is available
                {
                    results.Add(j + 1); // Allocate existing room
                    roomAvailabilityDay[j] = departure; // Update the room's new availability day
                    roomFound = true;
                    break;
                }
            }
            
            // If no room was available, allocate a new room
            if (!roomFound)
            {
                results.Add(roomAvailabilityDay.Count + 1); // New room number
                roomAvailabilityDay.Add(departure); // Add its availability day
            }
        }

        // Rearrange results to original customer order
        int[] orderedResults = new int[customers.Length];
        foreach (var customer in sortedCustomers)
        {
            orderedResults[customer.index] = results[sortedCustomers.ToList().IndexOf(customer)];
        }

        return orderedResults;
    }

    public static void Main()
    {
        int[][] customers = new int[][] { new int[] { 1, 5 }, new int[] { 2, 4 }, new int[] { 6, 8 }, new int[] { 7, 7 } };
        int[] roomAssignments = AllocateRooms(customers);

        Console.WriteLine("Room Assignments:");
        foreach (int room in roomAssignments)
        {
            Console.WriteLine(room);
        }
    }
}
