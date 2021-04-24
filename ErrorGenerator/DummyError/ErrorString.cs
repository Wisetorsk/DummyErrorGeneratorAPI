using System;
using System.Text;

namespace ErrorGenerator.DummyError
{
    public static class ErrorStrings
    {
        public static DateTime Start { get; set; } = new DateTime(2019, 1, 1);
        public static int Range { get; set; } = (DateTime.Today - Start).Days;
        private static Random Rng { get; set; } = new Random(); // Naming violation???

        private static readonly string[] _drive = new string[] { 
            "C:",
            "D:",
            "E:",
            "F:",
            "G:"
        };

        private static readonly string[] _firstIndex = new string[] {
            "/Server",
            "/Client",
            "/RoomA",
            "/Host",
            "/Windows",
            "/Home"
        };

        private static readonly string[] _secondIndex = new string[]
        {
            "/Norkart",
            "/KommuneA",
            "/KommuneB",
            "/KommuneC",
            "/KommuneD",
            "/KommuneE",
            "/Brannforebygging",
            "/Kommuneinnsikt"
        };

        private static readonly string[] _thirdIndex = new string[]
        {
            "/Brannforebygging.exe",
            "/Kundeinnsikt.exe",
            "/KomtekForvaltning.exe",
            "/SlamAPI.exe",
            "/VaTilsyn.exe"
        };

        private static readonly string[] _os = new string[] {
            "Windows_UnknownVersion",
            "Linux_UnknownDistro",
            "WinServer",
            "UbuntuServer",
            "FreeBSD",
            "ChromeOS",
            "Win10",
            "Win8",
            "Win7"
        };

        private static readonly string[] _messages = new string[] { 
            "API_Error:",
            "NullReferenceError",
            "Request Timeout"

        };

        private static readonly int[] _htmlEC = new int[] { 
            100,101,203,204,205,206,300,301,302,303,304,305,400,401,402,403,
            404,405,406,407,408,409,410,411,412,413,414,415,418,500,501,502,503,504,505
        };

        private static byte[] _codeArray => new byte[5] { (byte)Rng.Next(256), (byte)Rng.Next(256), (byte)Rng.Next(256), (byte)Rng.Next(256), (byte)Rng.Next(256) };
        public static string Path => _drive[Rng.Next(_drive.Length)] + _firstIndex[Rng.Next(_firstIndex.Length)] + _secondIndex[Rng.Next(_secondIndex.Length)] + _thirdIndex[Rng.Next(_thirdIndex.Length)];

        public static string Message => _messages[Rng.Next(_messages.Length)];
        public static string OS => _os[Rng.Next(_os.Length)];
        public static DateTime Date => Start.AddDays(Rng.Next(Range)).AddHours(Rng.Next(0, 24)).AddMinutes(Rng.Next(0, 60)).AddSeconds(Rng.Next(0, 60));
        public static int HTMLError => _htmlEC[Rng.Next(_htmlEC.Length)];
        public static string EC => BitConverter.ToString(_codeArray).Replace("-", ".");

        public static string FullError()
        {
            string msg = Message;
            return $"{Date}|{EC}|{OS}|{Path}|{((msg == "API_Error:") ? $"API_Error: {HTMLError}" : msg)}";
        }

        public static string FullErrorJson()
        {
            string msg = Message;
            
            string jsonError = $"{{\"Date\":{Date}, \"ErrorCode\":{EC}, \"OS\":{OS}, \"Path\":{Path}, \"Message\":{ ((msg == "API_Error:") ? $"API_Error: {HTMLError}" : msg)}}}";
            return jsonError;
        }

        public static string FullErrorJsonNoBrackets()
        {
            string msg = Message;

            string jsonError = $"{{'Date':{Date}, 'ErrorCode':{EC}, 'OS':{OS}, 'Path':{Path}, 'Message':{ ((msg == "API_Error:") ? $"API_Error {HTMLError}" : msg)}}}";
            return jsonError;
        }

        

    }

}
