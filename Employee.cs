using System.Text;
using System.Threading.Tasks;
using System.Xml; // using xml reader
using System.Xml.Serialization;

namespace XMLSample2
{
    [Serializable]
    public class Employee //NOTE YOU CANNOT SERIALIZE PRIVATE FIELDS
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double SSNumber { get; set; }
        public DateTime EntryDate { get; set; } // using DateTime method. Predefined method in .NET Framework
    }  
}
