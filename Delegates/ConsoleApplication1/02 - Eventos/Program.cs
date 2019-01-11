using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();      //Publisher
            var mailService = new MailService();        //Subscriber
            var messageService = new MessageService();  //Subscriber

            videoEncoder.OnVideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.OnVideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.ReadLine();
        }
    }
}
