using Qlik.Engine;
using Qlik.Engine.Communication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace QSMGMT
{
    public class Connection
    {
        private string _pfxBasePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private ILocation _location = null;
        private string _url, _baseUrl, _pfx, _pfxPass, _userId, _domain, _name;


        #region CONSTRUCTORS

        //Empty Constructor
        public Connection()
        {
            
        }


        public Connection(string url, string pfx, string pfxPass, string userId, string domain, string name)
        {
            Url = url;
            Pfx = pfx;
            PfxPass = pfxPass;
            UserId = userId;
            Domain = domain;
            Name = name;

            //ConnectToQlikSense(url,pfx, pfxPass,userId,domain);

        }

        #endregion CONSTRUCTORS

        #region GET/SET

        public string Domain
        {
            get
            {
                return _domain;
            }

            set
            {
                _domain = value;
            }
        }

        public string BaseUrl
        {
            get
            {
                return _baseUrl;
            }
        }

        public ILocation Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Pfx
        {
            get
            {
                return _pfx;
            }

            set
            {
                _pfx = value;
            }
        }

        public string PfxPass
        {
            get
            {
                return _pfxPass;
            }

            set
            {
                _pfxPass = value;
            }
        }

        public string Url
        {
            get
            {
                return _url;
            }

            set
            {
                _baseUrl = value;
                _url = value + ":4747";
            }
        }

        public string UserId
        {
            get
            {
                return _userId;
            }

            set
            {
                _userId = value;
            }
        }

        #endregion GET/SET

        public void ConnectToQlikSense()
        {
            ConnectToQlikSense(Url, Pfx, PfxPass, UserId, Domain);
        }

        public void ConnectToQlikSense(string url, string pfx, string pfxPass, string userId, string domain)
        {
            try
            {
                var uri = new Uri(url);
                _location = Qlik.Engine.Location.FromUri(uri);
                X509Certificate2 x509 = new X509Certificate2(Path.Combine(_pfxBasePath + pfx),pfxPass);
                _location.IsVersionCheckActive = false;
                X509Certificate2Collection certificateCollection = new X509Certificate2Collection(x509);
                _location.AsDirectConnectionAsync(domain,userId, certificateValidation: false, certificateCollection: certificateCollection);
            }
            catch (CommunicationErrorException cex)
            {
                Debug.WriteLine("Can not connect to Qlik Sense instance, check that Qlik Sense is running." + Environment.NewLine + cex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("General error. " + ex.Message);
            }

        }



    }
}
