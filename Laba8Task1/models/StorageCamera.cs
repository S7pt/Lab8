namespace Laba8Task1.models
{
    public class StorageCamera
    {
        public string storeDate;
        public int baggageWeight;
        public int storingDuration;
        public string specialNotes;
        public string ownerNameAndSurname;

        public StorageCamera(string storeDate, int baggageWeight, int storingDuration, string ownerNameAndSurname,string specialNotes)
        {
            this.storeDate = storeDate;
            this.baggageWeight = baggageWeight;
            this.storingDuration = storingDuration;
            this.specialNotes = specialNotes;
            this.ownerNameAndSurname = ownerNameAndSurname;
            
        }
        public override string ToString()
        {
            return storeDate + '|'+ baggageWeight + '|' + storingDuration + '|' + ownerNameAndSurname + '|' + specialNotes;
        }
    }
}