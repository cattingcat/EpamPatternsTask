using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Validators
{
    class NormalValidator: IValidator
    {
        public bool Validate(string s)
        {
            bool haveLeters = false;
            bool haveDigits = false;
            bool havePunctuations = false;

            for (int i = 0; i < s.Length; ++i)
            {
                if (char.IsLetter(s[i]))
                    haveLeters = true;

                if (char.IsDigit(s[i]))
                    haveDigits = true;

                if (char.IsPunctuation(s[i]))
                    havePunctuations = true;

                if (haveDigits && haveLeters && havePunctuations)
                    return true;
            }
            return false;            
        }
    }
}
