using countyContest.Win.DataModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countyContest.Win.DataModel
{
    class Country: ICountry
    {
        public string name;
        public string capital;
        public string dialogCode;
        public string currency;

        public Country(string name,string capital,string dialogCode,string currency)
        {
            this.name = name;
            this.capital = capital;
            this.dialogCode = dialogCode;
            this.currency = currency;
       
        }
       
    }
}
