
List<Person> persons = new List<Person>
{
    new Person("Leonardo G", 22),
    new Person("Bruna A", 24),
    new Person("Bruna C", 28)
};

foreach (Person person in persons)
{
    var test = person.name.Split(" ");
    Console.WriteLine(test[0]);
}


List<Person> filteredPersons = persons
    .Where(person => person.age < 25)
    .OrderBy(person => person.name.Split(" ")[1])
    .ThenBy(person => person.age)
    .ToList();

foreach (Person person in filteredPersons)
{
    Console.WriteLine(person.name);
}



class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}