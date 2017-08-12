using System;

namespace Eventos
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: sending an message... " + args.Video.Title);
        }
    }
}
