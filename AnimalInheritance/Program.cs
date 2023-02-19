// base Class 
class Animal
{
    private string name; // only accessible within this class
    protected string species; //accessible from derived classes
    public string color;  // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setSpecies(string species)
    {
        this.species = species;
    }
    public virtual string getSpecies()
    {
        return this.species;
    }
}
// derived class 
    class Fish : Animal
    {
        public string length;  // accessible from any class
        protected int age;  //accessible from derived classes

        public void setAge(int age)
        {
            this.age = age;
        }
        public virtual int getAge()
        {
            return age;
        }

        // access name through base because it is private
        public override string getName()
        {
            return base.getName();
        }

        // access species directly because it is protected and this is a derived class
        public override string getSpecies()
        {
            return species;
        }

        public virtual string agression()
        {
            return "This species is agressive. Please be careful when placing this fish in a community tank.";
        }
    }// end of fish

class Program
{

    static void Main(string[] args)
    {
        // object of the base class Animal
       
        Animal onefish = new Animal();
        onefish.setName("Boogie");
        onefish.setSpecies("Oscar");
        // color is a public field and can be accessed anywhere
        onefish.color = "Orange & Black";
        Console.WriteLine("");
        Console.WriteLine("Fish Information...");
        Console.WriteLine($"My name is {onefish.getName()}");
        Console.WriteLine($"I am an {onefish.getSpecies()}");
        Console.WriteLine($"I am an {onefish.color} color");
        Console.WriteLine();

        // object of derived class Fish
        Fish twofish = new Fish();
        twofish.setName("Dolorado");
        twofish.setSpecies("Parrotfish");
        // color is a public field and can be accessed anywhere
        twofish.color = "Orange";
        // breed is a public field
        twofish.length = "12";
        // age is a protected field
        twofish.setAge(3);

        Console.WriteLine("Fish Information");
        Console.WriteLine($"My name is {twofish.getName()}");
        Console.WriteLine($"I am {twofish.length} inches long & a {twofish.getSpecies()}");
        Console.WriteLine($"I am a vibrant {twofish.color} color");
        Console.WriteLine($"I am {twofish.getAge()} years old");
        Console.WriteLine($"{twofish.agression()}");

        Console.ReadLine(); // pauses end of program display
    } // end of main 

}// end of program 
