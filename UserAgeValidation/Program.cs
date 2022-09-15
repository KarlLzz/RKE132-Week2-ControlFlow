// See https://aka.ms/new-console-template for more information

//Rakendus küsib kasutaja sugu (m/f)
//Rakendus küsib kasutaja perekonna nime
//lähtudes kasutaja valikust tervitab kasutajat järgmiselt:
//"Welcome, Mr.[kasutaja perekonnanimi] /"Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());//loeb konsoolist maha andmed string (sõne) formaadis

Console.WriteLine("Please enter your name:");
string userLastName = Console.ReadLine();

if(userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if(userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
