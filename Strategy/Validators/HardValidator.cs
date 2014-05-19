using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Validators
{
    class HardValidator: IValidator
    {
        public bool Validate(string s)
        {
            bool haveLetersUpper = false;
            bool haveLetersLower = false;
            bool haveDigits = false;
            bool havePunctuations = false;

            for (int i = 0; i < s.Length; ++i)
            {
                if (char.IsLetter(s[i]))
                {
                    if (char.IsUpper(s[i]))
                        haveLetersUpper = true;
                    else
                        haveLetersLower = true;
                }
                if (char.IsDigit(s[i]))
                    haveDigits = true;

                if (char.IsPunctuation(s[i]))
                    havePunctuations = true;

                if (haveDigits && haveLetersUpper && haveLetersLower && havePunctuations)
                    return true;
            }
            return false;    
        }
    }
}
