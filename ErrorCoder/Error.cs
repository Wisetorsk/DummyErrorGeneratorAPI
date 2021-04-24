using System;
using ErrorCoder.ErrorEnums;

namespace ErrorCoder
{
    public class Error
    {
        public DomainCode Domain { get; set; } = 0;
        public ServerCode Server { get; set; } = 0;
        public OsCode Os { get; set; } = 0;
        public ApplicationCode Application { get; set; } = 0;
        public ActionCode Action { get; set; } = 0;
        public byte[] CodeArray => new byte[5] { (byte)Domain, (byte)Server, (byte)Os, (byte)Application, (byte)Action };
        public string ErrorString => BitConverter.ToString(CodeArray).Replace("-", ".");

        public override string ToString()
        {
            return ErrorString;
        }
    }
}
