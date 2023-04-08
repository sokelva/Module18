using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExplodeConverter
{
    /// <summary>
    /// Базовый класс команды
    /// </summary>
    abstract class Command
    {
        public abstract void ConsoleViewer(string url);
        public abstract void DownLoadVideo(string url, string outputFilePath);
    }
}
