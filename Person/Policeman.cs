class Policeman : Person
{
    private string _weapons;
    private double _hourlyWage;
    private int _hoursWorked;
    public Policeman(string firstname, string lastname, int age, string weapons, int hours, double wage)
    : base(firstname, lastname, age)
    {
        _weapons = weapons;
        _hourlyWage = wage;
        _hoursWorked = hours;

    }

    public string GetPolicemanInformation()
    {
        return $"{GetPersonInformation()} :: Weapons: {_weapons}";
    }

    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()} :: Weapons: {_weapons}";
    }

    public override double GetSalary()
    {
        double pay = _hoursWorked * _hourlyWage;
        if(_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }

        return pay;
    }
}