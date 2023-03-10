namespace EbayScraperWPF
{
    public class UserData
    {
        private string firstName;
        private string lastName;
        private string email;
        private string telephone;
        private string addressLine1;
        private string addressLine2;
        private string country;
        private string state;
        private string city;
        private string county;
        private string postalCode;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string County
        {
            get { return county; }
            set { county = value; }
        }
        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }
    }
}
