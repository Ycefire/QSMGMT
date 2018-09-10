using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QSMGMT.Web_APIs
{
    class QS_Repository_API
    {
        private Connection _currentConn;
        private QS_Proxy_API _proxyAPI;
        private string _repositoryAPIPortAndAddress = ":4242/qrs/";

        #region Constructors

        public QS_Repository_API (Connection conn)
        {
            CurrentConn = conn;
            _proxyAPI = new QS_Proxy_API(conn);
        }

        #endregion Constructors


        #region GET/SET

        public Connection CurrentConn
        {
            get
            {
                return _currentConn;
            }

            set
            {
                _currentConn = value;
            }
        }

        internal QS_Proxy_API ProxyAPI
        {
            get
            {
                return _proxyAPI;
            }
        }

        #endregion GET/SET


        #region API Methods

        public string GetSwaggerJson ()
        {
            string ticket = _proxyAPI.TicketRequest();

            //Create URL to REST endpoint for tickets
            string url = Path.Combine(_currentConn.BaseUrl + _repositoryAPIPortAndAddress + "about/openapi/main");

            //Create the HTTP Request and add required headers and content in Xrfkey
            string Xrfkey = "0123456789xbcdef";
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url + "?xrfkey=" + Xrfkey);
            // Add the method to authentication the user
            Request.ClientCertificates.Add(_currentConn.Cert);
            Request.Method = "GET";
            Request.Accept = "application/json";
            Request.Headers.Add("X-Qlik-Xrfkey", Xrfkey);
            Request.Headers.Add("X-Qlik-User", "UserDirectory=INTERNAL; UserId=SA_ENGINE");


            // make the web request and return the content
            HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();
            Stream Stream = Response.GetResponseStream();
            string json = new StreamReader(Stream).ReadToEnd();


            
            //dynamic oo = JsonConvert.DeserializeObject(json);
            //Dictionary<string, Task> ret = new Dictionary<string, Task>();
            //foreach (var k in oo)
            //{
            //    Guid g = new Guid(k.id.ToString());
            //    string name = k.name.ToString();
            //    bool enabled = k.enabled.ToString().Equals("true");
            //    int status = System.Convert.ToInt32(k.operational.lastExecutionResult.status.ToString());

            //    ret.Add(name, new Task(g, name, enabled, status));
            //}

            return json;

        } 

        #endregion API Methods
    }
}
