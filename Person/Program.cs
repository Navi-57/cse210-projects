class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bubba", "Bob", 53);

        Console.WriteLine(myPerson.GetPersonInformation());

        Policeman myPoliceman = new Policeman("Cooper", "Silver", 34, "Club");
        Console.WriteLine(myPoliceman.GetPolicemanInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 56, "Hammer");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}