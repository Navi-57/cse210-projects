class Doctor : Person
{
    private string _tools;
    private double _salary;
    public Doctor(string firstname, string lastname, int age, string tools, double salary)
    : base(firstname, lastname, age)
    {
        _tools = tools;
        _salary = salary;
    }

    public string GetDoctorInformation()
    {
        return $"{GetPersonInformation()} :: Tools: {_tools}";
    }

    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()} :: Tools: {_tools}";
    }

    public override double GetSalary()
    {
        return _salary;
    }
}