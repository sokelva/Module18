namespace YoutubeExplodeConverter
{
    /// <summary>
    /// Клиентский код
    /// </summary>
    class Program
    {
        public static string VideoUrl = "https://www.youtube.com/watch?v=1La4QzGeaaQ";
        public static string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)+"\\"+"newVideo.mp4";
        

        static void Main()
        {

            // создадим отправителя
            var sender = new Sender();

            // создадим получателя
            var receiver = new Receiver();

            //1 команда
            // создадим команду
            var commandOne = new CommandOne(receiver);

            // инициализация команды commandOne
            sender.SetCommand(commandOne);

            //  выполнение commandOne
            sender.ConsoleViewer(VideoUrl);

            //2 команда
            // создадим команду commandOne2
            var commandOne2 = new CommandOne(receiver);

            // инициализация команды commandOne2
            sender.SetCommand(commandOne2);

            //  выполнение
            sender.DownLoadVideo(VideoUrl,FilePath);
        }
    }
 }