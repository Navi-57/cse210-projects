class Doctor : Person
{
    private string _tools;
    public Doctor(string firstname, string lastname, int age, string tools)
    : base(firstname, lastname, age)
    {
        _tools = tools;
    }

    public string GetDoctorInformation()
    {
        return $"{GetPersonInformation()} :: Tools: {_tools}";
    }
}