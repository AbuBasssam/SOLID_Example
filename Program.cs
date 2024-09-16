

using System;
using ValidationExample;
class Program
{
    static void Main(string[] args)
    {
        PersonRepositary personRepositary = new PersonRepositary("Server=.;Database=DVLD;User Id=sa;Password=sa123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;");
        PersonValidation personValidation= new PersonValidation(personRepositary);

        PersonDTO PDTO = new PersonDTO
            (null,"N21",
            "Ali",
            "Maher",
            "Fadi",
            "Alahmad"
            ,DateTime.Now.AddYears(-25),
            0,
            "Suadi Arabia,Jeddah",
            "397597947",
            "Emailgmail.com",
            121,
            null
            );
        if (personValidation.IsValid(PDTO))
            Console.WriteLine("The Person is Valid to Add");

        else
            Console.WriteLine(personValidation.ErrorMessage());
        Console.ReadLine(); 

    }
}
