using System; 
namespace ClassLibrary1
{

    public class Nhlanhla_proccessor
    {
        public static string JoinName(string? fullName, string? lastName, string? IDnumber,string? CellPhoneNumber,string? course)
        {

            return fullName + " " + lastName + " " + course + " " + IDnumber + " "+CellPhoneNumber;
        }
    }

}


