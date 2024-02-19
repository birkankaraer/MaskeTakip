using Business.Concrete;
using Entities.Concrete;

namespace Workspace
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person();
			person1.NationalIdentity = 11111111111;
			person1.FirstName = "Mustafa Birkan";
			person1.LastName = "Karaer";
			person1.DateOfBirthYear = 2000;

			PttManager pttManager = new PttManager(new CitizenManager());
			pttManager.GiveMask(person1);
		}
	}
}
