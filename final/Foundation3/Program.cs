using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address instances
        Address address1 = new Address("100 Innovation Way", "Boston", "MA", "USA");
        Address address2 = new Address("45 Party Plaza", "Toronto", "ON", "Canada");
        Address address3 = new Address("Beachside Park", "San Diego", "CA", "USA");

        // Create Events
        Event lecture = new Lecture("AI and the Future", "Explore how AI is changing the world.", "2025-09-15", "18:00", address1, "Dr. Susan Clark", 100);
        Event reception = new Reception("Global Networking Night", "An evening of professional networking.", "2025-10-20", "19:30", address2, "rsvp@eventcorp.com");
        Event outdoor = new OutdoorGathering("Sunset Yoga", "Relax with yoga at sunset.", "2025-08-10", "17:00", address3, "Clear skies with a cool breeze");

        // List of events
        Event[] events = { lecture, reception, outdoor };

        // Display all messages for each event
        foreach (var ev in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\n=== Full Details ===");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\n=== Short Description ===");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 50));
        }
    }
}