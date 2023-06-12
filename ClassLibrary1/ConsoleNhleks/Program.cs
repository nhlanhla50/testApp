using ClassLibrary1; 

public class usingNhlanhlaPro
{
    public static void Main(string[] args)
    {
        Console.WriteLine("what is your full name:");
        string? fullName = Console.ReadLine();

        Console.WriteLine("what is your last name:");
        string? lastName = Console.ReadLine();

        Console.WriteLine("what is your ID number:");
        string? IDnumber = Console.ReadLine();

        Console.WriteLine("what is your cours:");
        string? Cours = Console.ReadLine();

        Console.WriteLine("what is your CellPhone number:");
        string? CellPhoneNumber = Console.ReadLine();


        fullName = Nhlanhla_proccessor.JoinName( fullName, lastName, IDnumber, CellPhoneNumber,Cours );

        Console.WriteLine($"your full name is {fullName}");


        
    }

    
}


