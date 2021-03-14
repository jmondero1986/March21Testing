using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjectWP.JULIEM.Models
{
   public class RequestBlankFormModel
    {

        public string FirstName;
        public string LastName;
        public string BusinessName;
        public string EmailAdd;
        public string PhoneNum;
        public string RequestMsg;
     

        public RequestBlankFormModel(string v1, string v2, string v3, string v4, string v5, string v6)
        {
            this.FirstName = v1;
            this.LastName = v2;
            this.BusinessName = v3;
            this.EmailAdd = v4;
            this.PhoneNum = v5;
            this.RequestMsg = v6;
        }
    }
}
