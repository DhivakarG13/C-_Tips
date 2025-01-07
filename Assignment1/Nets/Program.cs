using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

List<ContactManager> CallLog = new List<ContactManager>();
List<ContactManager> Recents = new List<ContactManager>();

while (true)
{
    Console.WriteLine("[1] Create a new Contact");
    Console.WriteLine("[2] Search Contacts");
    Console.WriteLine("[3] View Dierectory");
    Console.WriteLine("[4] Recent Searches");
    Console.WriteLine("[5] Favourites");
    Console.WriteLine("[6] Exit");
    Console.WriteLine();

    Console.Write("Enter Your Choice: ");

    int UserChoice = int.Parse(Console.ReadLine());

if( UserChoice == 1 )
{
    Console.Write("Enter Name:");
    string name = Console.ReadLine();
    Console.WriteLine(name);

    Console.Write("Enter Mobile Number :");
    string? mobileNumber = Console.ReadLine();
    Console.WriteLine(mobileNumber);

    Console.Write("Enter EmailID       :");
    string? email = Console.ReadLine();
    Console.WriteLine(email);

    Console.Write("Enter a Note        :");
    string? note = Console.ReadLine();
    Console.WriteLine(note);

    Console.WriteLine("Add toFavourites(1/0):");
    int fav = int.Parse(Console.ReadLine());
    Console.WriteLine();

   ContactManager cls = new ContactManager{
        Name = name,
        MobileNumber = mobileNumber,
        EmailId = email,
        Notes = note,
        FavouriteStats = fav,
    };

    CallLog.Add(cls);
}
else if(UserChoice == 2)
{
    Console.Write("Enter Name          :");
    string? name = Console.ReadLine();

    foreach(ContactManager cls in CallLog)
    {
        if (cls.Name == name)
        {
            Console.WriteLine();
            Console.WriteLine(cls.Name);
            Console.WriteLine(cls.MobileNumber);
            Console.WriteLine(cls.EmailId);
            Console.WriteLine(cls.Notes);
            Console.WriteLine();

            Recents.Add(cls);
        }
    }
}
else if( UserChoice == 3)
{
    foreach (ContactManager cls in CallLog)
    {
        Console.WriteLine();
        Console.WriteLine(cls.Name);
        Console.WriteLine(cls.MobileNumber);
        Console.WriteLine(cls.EmailId);
        Console.WriteLine(cls.Notes);
        Console.WriteLine();
    }
}
else if(UserChoice == 4)
{
    foreach (ContactManager cls in Recents)
    {
        Console.WriteLine();
        Console.WriteLine(cls.Name);
        Console.WriteLine(cls.MobileNumber);
        Console.WriteLine(cls.EmailId);
        Console.WriteLine(cls.Notes);
        Console.WriteLine();
    }
}
    else if (UserChoice == 5)
    {
        foreach (ContactManager cls in CallLog)
        {
            if (cls.FavouriteStats == 1)
            {
                Console.WriteLine();
                Console.WriteLine(cls.Name);
                Console.WriteLine(cls.MobileNumber);
                Console.WriteLine(cls.EmailId);
                Console.WriteLine(cls.Notes);
                Console.WriteLine();
            }
        }
    }
    else
{
   break;
}
    Console.WriteLine("-------------------------------------------------");
}
public class ContactManager
{
    public string? Name { get; set; }
    public string? MobileNumber { get; set; }
    public string? EmailId {  get; set; }
    public string? Notes {  get; set; }
    public int FavouriteStats{  get; set; }
}