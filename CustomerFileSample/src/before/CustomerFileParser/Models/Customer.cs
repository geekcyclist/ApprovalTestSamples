using System.IO.MemoryMappedFiles;

namespace CustomerFileParser.Models
{
    public class Customer : BaseModel
    {
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _suffix;
        private string _street;
        private string _city;
        private string _state;
        public int Id { get; set; }

        public string FirstName
        {
            get => _firstName?.ToUpper();
            set => _firstName = value;
        }

        public string MiddleName
        {
            get => _middleName?.ToUpper();
            set => _middleName = value;
        }

        public string LastName
        {
            get => _lastName?.ToUpper();
            set => _lastName = value;
        }

        public string Suffix
        {
            get => _suffix?.ToUpper();
            set => _suffix = value;
        }

        public string Street
        {
            get => _street?.ToUpper();
            set => _street = value;
        }

        public string City
        {
            get => _city?.ToUpper();
            set => _city = value;
        }

        public string State
        {
            get => _state?.ToUpper();
            set => _state = value;
        }

        public string Zip { get; set; }

        public string Zip4 { get; set; }

        public int Age { get; set; }
    }
}
