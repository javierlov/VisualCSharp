
namespace Indexers
{
	using System;

	sealed class PhoneBook
	{
		public PhoneBook()
		{
			int initialSize = 0;
			used = 0;
			names = new Name[initialSize];
			phoneNumbers = new PhoneNumber[initialSize];
		}
		
		public void Add(Name name, PhoneNumber number)
		{
			enlargeIfFull();
			names[used] = name;
			phoneNumbers[used] = number;
			used++;
		}
		
		// write 1st indexer here

		// write 2nd indexer here

		private void enlargeIfFull()
		{
			if (used == names.Length)
			{
				int bigger = used + 16;
				
				Name[] moreNames = new Name[bigger];
				names.CopyTo(moreNames, 0);
				
				PhoneNumber[] morePhoneNumbers = new PhoneNumber[bigger];
				phoneNumbers.CopyTo(morePhoneNumbers, 0);
						
				names = moreNames;
				phoneNumbers = morePhoneNumbers;
			}
		}

		private int used;
		private Name[] names;
		private PhoneNumber[] phoneNumbers;
	}
}