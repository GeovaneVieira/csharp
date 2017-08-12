using System;

namespace Eventos
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService: sending an e-mail... " + args.Video.Title);
        }
    }
}
