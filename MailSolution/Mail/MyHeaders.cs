using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mail
{
    public class MyHeaders
    {
        public String From;
        public String Subject;
        public String Date;

        public MyHeaders(String From, String Subject, String Date)
        {
            this.From = From;
            this.Subject = Subject;
            this.Date = Date;
        }
    }
}
