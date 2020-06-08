using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8.models;

namespace lab8._2.finale
{
    class SortByDuration:IComparer<StorageCamera>
    {     
          public int Compare(StorageCamera storage1,StorageCamera storage2)
          {
                return storage1.storingDuration - storage2.storingDuration;
          }
    }
    class SortByWeight : IComparer<StorageCamera>
    {
        public int Compare(StorageCamera storage1, StorageCamera storage2)
        {
            return storage1.baggageWeight - storage2.baggageWeight;
        }
    }
    class SortByNameAndSurname : IComparer<StorageCamera>
    {
        public int Compare(StorageCamera storage1,StorageCamera storage2)
        {
            return string.Compare(storage1.ownerNameAndSurname, storage2.ownerNameAndSurname);
          
            
        }
    }
}
