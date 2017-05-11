using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
namespace OutputViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardCatalog StandardCatalog = new StandardCatalog();
            ISaveable saveable = new StandardCatalog();
            IPersistable Persistable = new StandardCatalog();
            
            Console.WriteLine("Standard Implementation\n");
            Console.WriteLine("Concreate Clas: {0}", StandardCatalog.Save());
            Console.WriteLine("Isaveable: {0}", saveable.Save());
            Console.WriteLine("Ipersistable: {0}", Persistable.Save());
            Console.WriteLine("\n");

            Console.WriteLine("Concreate Clas: {0}", StandardCatalog.Save());
            Console.WriteLine("(ISaveable)Catalog: {0}", ((ISaveable)StandardCatalog).Save());
            Console.WriteLine("(IPersistable)Catalog: {0}", ((IPersistable)StandardCatalog).Save());
            Console.WriteLine("\n");

            Console.WriteLine("================================================================================");
            Console.WriteLine("\n");

            ExplicitCatalog ExplicitCatalog = new ExplicitCatalog();
            saveable = new ExplicitCatalog();
            Persistable = new ExplicitCatalog();

            Console.WriteLine("Explicit Implementation\n");
            Console.WriteLine("Concreate Clas: {0}", ExplicitCatalog.Save());
            Console.WriteLine("ISaveable: {0}", saveable.Save());
            Console.WriteLine("IPersistable: {0}", Persistable.Save());
            Console.WriteLine("\n");

            Console.WriteLine("Concreate Clas: {0}", ExplicitCatalog.Save());
            Console.WriteLine("(ISaveable)Catalog: {0}", ((ISaveable)ExplicitCatalog).Save());
            Console.WriteLine("(IPersistable)Catalog: {0}", ((IPersistable)ExplicitCatalog).Save());
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
