using System.Collections.Generic;
using System.Globalization;


namespace MvcPersonnalTest.BusinessModel
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Address> Addresses { get; set; }
        public bool Active { get; set; }

        public string Initials
        {
            get 
            {
                string initials = GetFirstLetter(FirstName) + GetFirstLetter(LastName);
                return initials;
            }
        }

        private string GetFirstLetter(string word)
        {
            if (string.IsNullOrEmpty(word))
                return string.Empty;

            return word[0].ToString(CultureInfo.InvariantCulture);
        }
    }
}
