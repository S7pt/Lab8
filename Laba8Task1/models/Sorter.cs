using System.Collections.Generic;

namespace Laba8Task1.models
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