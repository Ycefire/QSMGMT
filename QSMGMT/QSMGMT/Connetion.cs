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

        public Connetion(string url)
        {
            url = url + ":4747";
            ConnectToQlikSense(url);

        }

        public ILocation location
        {
            get { return _location; }
            set { _location = value; }
        }

        public void ConnectToQlikSense(string url)
        {
            try
            {
                var uri = new Uri(url);
                _location = Qlik.Engine.Location.FromUri(uri);
                X509Certificate2 x509 = new X509Certificate2(@"C:\\GITHUB\\QSMGMT\\QSMGMT\\QSMGMT\\QS Certificates\\CRED DEMO SERVER\\CREDON35\\client.pfx", "test");
                _location.IsVersionCheckActive = false;
                X509Certificate2Collection certificateCollection = new X509Certificate2Collection(x509);
                // Defining the location as a direct connection to Qlik Sense Server
                _location.AsDirectConnectionAsync("DEMO", "QSADMIN", certificateValidation: false, certificateCollection: certificateCollection);
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
