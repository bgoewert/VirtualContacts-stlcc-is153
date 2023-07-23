using System;
using System.Collections.Generic;

//create your struct here
public struct Person
{
    public string Name;
    public int Age;
    public string PhoneNumber;
    public string EmailAddress;
    public string PreferredContactMethod;
}


class Program
{
    enum PreferredContactMethod{ E, P };

    static void Main(string[] args)
    {
        //create the necessary code for your program to run here
        Dictionary<string, Person> people = new Dictionary<string, Person>();

        // Create first person
        Person person1 = CreatePerson();
        people.Add(person1.Name, person1);

        // Create second person
        Person person2 = CreatePerson();
        people.Add(person2.Name, person2);

        DisplayPersonDetails(ref people);
    }

    //create the CreatePerson() method here
    static Person CreatePerson()
    {
        
        Console.WriteLine("Enter the details for a person:");
        
        // Get Name
        string name;
        do
        {
            Console.Write("Name: ");
            name = Console.ReadLine() ?? "";
        } while (name == "");

        // Get Age
        int intAge = 0;
        do
        {
            Console.Write("Age: ");
            string strAge = Console.ReadLine();
            
            // If given value does not convert to an integer, display error and try again.
            if (!Int32.TryParse(strAge, out intAge) && intAge <= 0)
                Console.WriteLine("Invalid input. Please enter a valid age.");
        } while (intAge <= 0);
        
        // Get Phone Number
        string phoneNumber;
        do
        {
            Console.Write("Phone Number: ");
            phoneNumber = Console.ReadLine() ?? "";
        } while (phoneNumber == "");

        // Get Email Address
        string emailAddress;
        do
        {
            Console.Write("Email Address: ");
            emailAddress = Console.ReadLine() ?? "";
        } while (emailAddress == "");

        // Get Preferred Contact Method
        string preferredContactMethod = "";
        do
        {
            Console.Write("Preferred Contact Method (E for Email Address, P for Phone Number): ");
            preferredContactMethod = Console.ReadLine() ?? "";
            
            // If given value does not match "E" or "P", display error and try again.
            if (preferredContactMethod != PreferredContactMethod.E.ToString() &&  preferredContactMethod != PreferredContactMethod.P.ToString())
                Console.WriteLine("Invalid input. Please enter 'E' for email address or 'P' for phone number.");
        } while (preferredContactMethod != PreferredContactMethod.E.ToString() &&  preferredContactMethod != PreferredContactMethod.P.ToString());

        
        
        // Return a new person
        return new Person
        {
            Name = name,
            Age = intAge,
            PhoneNumber = phoneNumber,
            EmailAddress = emailAddress,
            PreferredContactMethod = preferredContactMethod == PreferredContactMethod.E.ToString() ? "Email Address" : "Phone Number" 
        };
    }

        
    //create the DisplayPersonDetails() method here
    static void DisplayPersonDetails(ref Dictionary<string, Person> people)
    {
        foreach (Person person in people.Values)
        {
            Console.WriteLine(); // Add empty spacer line
            Console.WriteLine("Person Details:");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Phone Number: {person.PhoneNumber}");
            Console.WriteLine($"Email Address: {person.EmailAddress}");
            Console.WriteLine($"Preferred Contact Method: {person.PreferredContactMethod}");
        }
    }
}
