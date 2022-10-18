//namespace MethodsExercise

    public class Program
    {
    static void Main(string[] args)

    {
        Console.WriteLine("What is your first name?");
        var myName = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        var myColor = Console.ReadLine();
        Console.WriteLine("What is your favorite animal?");
        var myAnimal = Console.ReadLine();
        Console.WriteLine("What is your favorite band?");
        var myBand = Console.ReadLine();
        MyResult(myName, myColor, myAnimal, myBand);
    }
    static void MyResult(string myName, string myColor, string myAnimal, string myBand)

    {
        var myStory = ($"This is a very short story about {myName}. ");
        myStory = myStory + ($"Who loved his {myColor} {myAnimal}. ");
        myStory = myStory + ($"And they both loved to listen to the {myBand}.");
        Console.WriteLine(myStory);
    }




    


}



