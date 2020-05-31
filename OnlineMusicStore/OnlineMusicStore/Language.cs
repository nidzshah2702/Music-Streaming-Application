using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMusicStore
{
    class Language
    {
        string language_name { get; set; }
        string description { get; set; }

        public Language(string language_name, string description)
        {
            this.language_name = language_name;
            this.description = description;
        }

        public void AddLanguage(Language l)
        {

        }

        public void DeleteLanguage(int i)
        {

        }

        public void UpdateLanguage(Language l)
        {

        }
       // public IEnumerable<Language> ViewLanguages()
      //  {

      //  }

    }
}
