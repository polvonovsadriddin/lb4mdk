using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4mdk
{
    public class Notes :ICloneable,IComparable<Notes>
    {
        public string FullName { get; set; }
        public long Number { get; set; }
        public DateOnly  BirthDate { get; set; }
        public Notes(string fullName, int number, DateOnly birthDate) 
        {
            FullName= fullName;
            Number= number;
            BirthDate= birthDate;
        }
        
        public object Clone()
        {
            return new Notes(this.FullName, (int)this.Number, this.BirthDate);
        }
       

        public int CompareTo(Notes obj)
        {
            int nameComparison = string.Compare(this.FullName, obj.FullName, StringComparison.OrdinalIgnoreCase);
            if (nameComparison != 0)
            {
                return nameComparison; 
            }
            return this.BirthDate.CompareTo(obj.BirthDate);

        }
    }
}
