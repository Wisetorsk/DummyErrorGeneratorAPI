using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebInterface.DTO
{
    public class ErrorData
    {
        public string OS { get; set; }
        public string Date { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }

        public ErrorData(string line)
        {
            var elements = line.Replace("\"", "").Split('|');

            OS = elements[2];
            Date = elements[0];
            ErrorCode = elements[1];
            Message = elements[4];
            Path = elements[3];
        }
    }
}
