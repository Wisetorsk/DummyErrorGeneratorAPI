using System;
using ErrorCoder.ErrorEnums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorCoder
{
    interface IError
    {
        public DomainCode Domain { get; set; }
        public ServerCode Server { get; set; }
        public OsCode Os { get; set; } 
        public ApplicationCode Application { get; set; }
        public ActionCode Action { get; set; }
        public byte[] CodeArray { get; }
        public string ErrorString { get; }
    }
}
