using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using QSMGMT;

namespace QSMGMT.Web_APIs
{
    class QS_Proxy_API
    {
        private Connection _currentConn;
        private string _proxyAPIPortAndAddress = ":4243/qps/";

        #region constructors

         public QS_Proxy_API(Connection conn)
        {
            SetConnection(conn);
        }

        #endregion constructors

        #region GET/SET

        public Connection CurrentConn
        {
            get
            {
                return _currentConn;
            }

            set
            {
                SetConnection(value);
            }
        }

        #endregion GET/SET


        private void DisableCertificateSecurity()
        {
            ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate,
                  X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        }

        private void SetConnection (Connection conn)
        {
            _currentConn = conn;


        }


        public string TicketRequest()
        {
            DisableCertificateSecurity();

            //Create URL to REST endpoint for tickets
            string url = Path.Combine(_currentConn.BaseUrl + _proxyAPIPortAndAddress + "ticket");

            //Create the HTTP Request and add required headers and content in Xrfkey
            string Xrfkey = "0123456789abxdef";
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url + "?xrfkey=" + Xrfkey);
            // Add the method to authentication the user
            Request.ClientCertificates.Add(_currentConn.Cert);
            Request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
            Request.Method = "POST";
            Request.Accept = "application/json";
            Request.Headers.Add("X-Qlik-Xrfkey", Xrfkey);
            Request.Headers.Add("X-Qlik-User", "UserDirectory=INTERNAL; UserId=SA_ENGINE");

            string Body = "{ 'UserId':'" + _currentConn.UserId + "','UserDirectory':'" + _currentConn.Domain + "','Attributes': []}";
            byte[] BodyBytes = Encoding.UTF8.GetBytes(Body);

            if (!string.IsNullOrEmpty(Body))
            {
                //Request.ContentType = "application/x-www-form-urlencoded";
                Request.ContentType = "application/json";
                Request.ContentLength = BodyBytes.Length;
                Stream RequestStream = Request.GetRequestStream();
                RequestStream.Write(BodyBytes, 0, BodyBytes.Length);
                RequestStream.Close();
            }

            // make the web request and return the content
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            Stream Stream = Response.GetResponseStream();
            return Stream != null ? new StreamReader(Stream).ReadToEnd() : string.Empty;
        }



    }
}
