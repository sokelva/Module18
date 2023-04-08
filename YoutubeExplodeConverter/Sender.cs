using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YoutubeExplodeConverter
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class Sender
    {
        Command _command;
        

        public void SetCommand(Command command)
        {
            _command = command;
        }

        // Вывести в консоль
        public void ConsoleViewer(string url)
        {
            _command.ConsoleViewer(url);
        }

        // Выполнить скачивание
        public void DownLoadVideo(string url, string outputFilePath)
        {
            _command.DownLoadVideo(url, outputFilePath);
        }
    }
}
