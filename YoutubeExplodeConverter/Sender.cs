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
        public void ConsoleViewer()
        {
            _command.ConsoleViewer();
        }

        // Выполнить скачивание
        public void DownLoadVideo()
        {
            _command.DownLoadVideo();
        }
    }
}
