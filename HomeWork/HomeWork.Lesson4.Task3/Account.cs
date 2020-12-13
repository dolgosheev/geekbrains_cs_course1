using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Lesson4.Task3
{
    internal struct Account
    {
        internal string Login { get; private set; }
        internal string Password { get; private set; }

        public Account(Dictionary<string,string> dictionary,string searchedLogin)
        {
            var searched = dictionary.Where(r => r.Key == searchedLogin).FirstOrDefault();
            if (!string.IsNullOrWhiteSpace(searched.Key))
            {
                Login = searched.Key;
                Password = searched.Value;
            }
            else
            {
                Login = default(string);
                Password = default(string);
            }
        }
    }
}