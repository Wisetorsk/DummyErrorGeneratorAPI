using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ErrorGenerator.Components
{
    public class ErrorData
    {
        public string OS { get; set; }
        public string Date { get; set; }
        public string ErrorCode { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }
        public string IP { get; set; }
        public Severity ErrorLevel { get; set; }
        public string AdditionalComments { get; set; }

        public ErrorData(string line)
        {
            var elements = line.Replace("\"", "").Split('|');

            OS = elements[2];
            Date = elements[0];
            ErrorCode = elements[1];
            Message = elements[4];
            Path = elements[3];
            IP = elements[5];
            ErrorLevel = (Severity)int.Parse(elements[6]);
            AdditionalComments = elements[7];
        }
        public ErrorData()
        {

        }
    }

    public enum Severity
    {
        Critical = 4,
        Priority_1 = 3,
        Priority_2 = 2,
        Warning = 1,
        Nominal = 0
    }
}
