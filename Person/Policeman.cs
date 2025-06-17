class Policeman : Person
{
    private string _weapons;
    public Policeman(string firstname, string lastname, int age, string weapons)
    : base(firstname, lastname, age)
    {
        _weapons = weapons;
    }

    public string GetPolicemanInformation()
    {
        return $"{GetPersonInformation()} :: Weapons: {_weapons}";
    }
}