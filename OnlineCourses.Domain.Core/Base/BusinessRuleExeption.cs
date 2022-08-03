using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Domain.Core.Base
{
    public class BusinessRuleExeption : Exception
    {
        public BusinessRuleExeption(string message) : base(message)
        {

        }
    }
}
