using System;
using System.Threading;

namespace Eventos
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //1 - Definir um delegate (contrato: determina a assinatura do método que será chamado no subscriber)
        //2 - Definir um event baseado no delegate
        //3 - Raise ou publish o event

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler OnVideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            VideoEncoded(video);
        }

        protected virtual void VideoEncoded(Video video)
        {
            if (OnVideoEncoded != null)
            {
                OnVideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
