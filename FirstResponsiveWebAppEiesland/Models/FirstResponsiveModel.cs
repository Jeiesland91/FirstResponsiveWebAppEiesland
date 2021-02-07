using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppEiesland.Models
{
    public class FirstResponsiveModel
    {
        private int CURRENT_YEAR = 2021;
        //private DateTime LAST_DATE_2021 = new DateTime(2021, 12, 31);


        public int AgeInCurrentYear = 0;

        [Required(ErrorMessage = "Please enter user name.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter year of birth.")]
        [Range(1900, 2021, ErrorMessage = "Number of years must be between 1900 and 2021.")]
        public int YearOfBirth { get; set; }

        public int AgeThisYear()
        {
            if (YearOfBirth < 1900 || YearOfBirth > 2021)
                return 0;
            
            int futureValue = CURRENT_YEAR - YearOfBirth;
            return futureValue;
        }
    }
}
