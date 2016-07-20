
using ServiceI.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            WSHttpBinding WShb = new WSHttpBinding();//使用协议与服务端相同
            WShb.Security.Mode = SecurityMode.None; //安全级别
            EndpointAddress epo = new EndpointAddress("http://localhost/Service.svc");//指定WCF服务地址


            using (ChannelFactory<ICalculator> channelFactory = new ChannelFactory<ICalculator>(WShb, epo))
            {

                ICalculator proxy = channelFactory.CreateChannel();

                Console.WriteLine(proxy.Multiply(1, 2));
                Console.ReadKey();
            }

        }
    }
}
