public class Person
{
    public string Name {get; set;}

    public string Lastname {get; set;}

    public DateTime BirthDate {get; set;}

    public Person(string name, string lastname, DateTime birthDate)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.BirthDate = birthDate;
    }
}