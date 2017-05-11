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
        }

        public string Save()
        {
            return "Catalog Save";
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
