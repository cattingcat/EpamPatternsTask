using Strategy.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class PasswordValidator
    {
        public IValidator PasswordStrategy { get; set; }

        public PasswordValidator()
        {
            PasswordStrategy = new NormalValidator();
        }

        public bool IsCorrectPassword(string password)
        {
            return PasswordStrategy.Validate(password);
        }
    }
}
