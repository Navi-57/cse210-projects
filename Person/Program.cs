class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bubba", "Bob", 53);

        // Console.WriteLine(myPerson.GetPersonInformation());

        Policeman myPoliceman = new Policeman("Cooper", "Silver", 34, "Club", 56, 35);
        // Console.WriteLine(myPoliceman.GetPolicemanInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 56, "Hammer", 450000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myPoliceman);
        myPeople.Add(myDoctor);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.GetPersonInformation());
        Console.WriteLine($" ::  Salary: ${person.GetSalary()}");
    }


}