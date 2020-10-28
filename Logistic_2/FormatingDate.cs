using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Logistic_2
{
    public class FormatingDate
    {
        public DateTime FortamExistingDate(DateTime dateTime)
        {
            string date = dateTime.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture);

            return Convert.ToDateTime(date);
        }
    }
}
