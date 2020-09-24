using System;

namespace CustomerAndInventory
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }

        public bool ValidateName()
        {
            bool FirstNameIsValid = FirstName.Length > 1;
            
            bool LastNameIsValid = LastName.Length > 1;

            return FirstNameIsValid && LastNameIsValid;
        }
    }
}
