using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorCoder.ErrorEnums
{
    public enum ErrorCode : byte
    {
        
    }

    public enum DomainCode : byte
    {
        NorkartIntern = 0,
        UNCATEGORIZED = 255
    }

    public enum ServerCode : byte
    {
        NorkartIntern = 0,
        UNCATEGORIZED = 255
    }

    public enum OsCode : byte
    {
        WinServer = 0,
        UbuntuServer = 1,
        BSD = 2,
        Solaris = 3,
        UNCATEGORIZED = 255
    }

    public enum ApplicationCode : byte
    {
        NorkartIntern = 0,
        UNCATEGORIZED = 255
    }

    public enum ActionCode : byte
    {
        NorkartIntern = 0,
        UNCATEGORIZED = 255
    }
}
