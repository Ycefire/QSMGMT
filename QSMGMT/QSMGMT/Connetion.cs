using Qlik.Engine;
using Qlik.Engine.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QSMGMT
{
    public class Connetion
    {

        private ILocation _location = null;

        public Connetion(string url, String pfx, String pfxPass, String userId, String domain)
        {
            url = url + ":4747";
            ConnectToQlikSense(url,pfx, pfxPass,userId,domain);

        }

        public ILocation location
        {
            get { return _location; }
            set { _location = value; }
        }

        public void ConnectToQlikSense(string url, String pfx, String pfxPass,String userId,String domain)
        {
            try
            {
                var uri = new Uri(url);
                _location = Qlik.Engine.Location.FromUri(uri);
                X509Certificate2 x509 = new X509Certificate2(pfx,pfxPass);
                _location.IsVersionCheckActive = false;
                X509Certificate2Collection certificateCollection = new X509Certificate2Collection(x509);
                _location.AsDirectConnectionAsync(domain,userId, certificateValidation: false, certificateCollection: certificateCollection);
            }
            catch (CommunicationErrorException cex)
            {
                Console.WriteLine("Can not connect to Qlik Sense instance, check that Qlik Sense is running." + Environment.NewLine + cex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error." + Environment.NewLine + ex.Message);
            }

        }



    }
}
