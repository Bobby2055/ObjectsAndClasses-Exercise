namespace _07.OrderByAge
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            var inputInfo = Console.ReadLine();

            var listOfPersons = new List<Person>();


            while (inputInfo != "End")
            {
                var input = inputInfo.Split();

                var people = new Person();

                people.Name = input[0];
                people.ID = input[1];
                people.Age = int.Parse(input[2]);

                listOfPersons.Add(people);

                inputInfo = Console.ReadLine();
            }

            foreach (var person in listOfPersons.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");

            }
        }
    }
}