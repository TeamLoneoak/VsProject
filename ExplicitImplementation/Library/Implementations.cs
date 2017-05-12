using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class StandardCatalog : ISaveable, IPersistable
    {
        public void Load()
        {
            //This is comment from medha
		// staging and hunks
		//amend commit
        }

        public string Save()
        {
            return "Catalog Save";
            // this changes is done for ticket no. cc-8888 by harshad dave
	   // again made changes in this file to check changes between this branch and BBTchanges.
	//check ammend commit
        }

	public string BBTchanges()
	{
		return "this branch is created from specified comment before change made in cc-8888 ticket ";
	}
    }

    public class ExplicitCatalog : ISaveable, IPersistable
    {
        public string Save()
        {
            return "Catalog Save";
        }

        string ISaveable.Save()
        {
            return "ISaveable Save";
        }

        string IPersistable.Save()
        {
            return "IPersistable Save";
        }

    }

    public class Catalog : ISaveable, IvoidSaveable
    {
        public string Save()
        {
            throw new NotImplementedException();
        }

        void IvoidSaveable.Save()
        {
            throw new NotImplementedException();
        }
    }

}
//This is second change done by medha and going to attempt pull request
