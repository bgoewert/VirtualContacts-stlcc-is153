namespace VirtualContacts
{
    enum DayOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    internal struct Contact
    {
        public string Name;
        public int Age;
        public string PhoneNumber;
        public string EmailAddress;
        public string PreferredContactMethod;
        public DayOfWeek DayOfBirth;
        public string StreetAddress;
    }
}
