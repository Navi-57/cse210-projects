class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bubba", "Bob", 53);

        Console.WriteLine(myPerson.GetPersonInformation());

        Policeman myPoliceman = new Policeman("Cooper", "Silver", 34);
        Console.WriteLine(myPoliceman.GetPersonInformation());
    }
}