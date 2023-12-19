Person person1 = new Person();
person1.Firstname = "Yusufjon";
person1.Lastname = "Mirzoev";
person1.Age = 2008;
System.Console.WriteLine("My name is " + person1.GetFullName());
System.Console.WriteLine("My birth year is " + person1.GetBirthYear());




class Person
{
    public string Firstname;

    public string Lastname;

    public int Age;
    public string Address;

    public string GetFullName()
    {
        return $"{Firstname} {Lastname}";
    }
    public int GetBirthYear()
    {
        return Age;
    }
}