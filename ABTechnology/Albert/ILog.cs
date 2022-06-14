using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albert
{

    public delegate void LogEventHandler(string? message);

    /// <summary>
    /// Interface is designed to set up a Log System
    /// </summary>
    public interface ILog
    {
        event LogEventHandler OnLog;
        void Message (string _message,bool _isLogged);
        ViewModelList<LogRecord> Logs { get; set; }
    }
}
