using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using QSMGMT.QS_Classes;

namespace QSMGMT.Web_APIs
{
    class QS_Repository_API
    {
        private Connection _currentConn;
        //private QS_Proxy_API _proxyAPI;
        private string _repositoryAPIPortAndAddress = ":4242/qrs/";

        #region Constructors

        public QS_Repository_API(Connection conn)
        {
            CurrentConn = conn;
            
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

        //internal QS_Proxy_API ProxyAPI
        //{
        //    get
        //    {
        //        return _proxyAPI;
        //    }
        //}

        #endregion GET/SET

        private void DisableCertificateSecurity()
        {
            ServicePointManager.ServerCertificateValidationCallback =
            delegate (object s, X509Certificate certificate,
                  X509Chain chain, SslPolicyErrors sslPolicyErrors)
            { return true; };
        }

        #region API Methods

        #region API Updates



        #endregion API Updates

        #region API Gets

        public string GetBasicAPICall(string endpoint)
        {
            DisableCertificateSecurity();

            //Create URL to REST endpoint for tickets
            string url = Path.Combine(_currentConn.BaseUrl + _repositoryAPIPortAndAddress + endpoint);

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

            var jsonObj = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
        }

        public string GetSwaggerJSON()
        {
            return GetBasicAPICall("about/openapi/main");
        }

        public string GetEnumsJSON()
        {
            return GetBasicAPICall("about/api/enums");
        }

        public string GetSecurityRulesJSON()
        {
            return GetBasicAPICall("systemrule/full");
        }

        public string GetReloadTasksJSON()
        {
            return GetBasicAPICall("reloadtask/full");
        }

        public string GetStreamsJSON()
        {
            return GetBasicAPICall("stream/full");
        }

        public string GetAppsJSON()
        {
            return GetBasicAPICall("app/full");
        }

        public string GetUsersJSON()
        {
            return GetBasicAPICall("user/full");
        }

        public string GetCompositeEventsJSON()
        {
            return GetBasicAPICall("compositeevent/full");
        }
        

        public ObservableCollection<SystemRule> GetSecurityRules()
        {
            string systemRulesJSON = GetSecurityRulesJSON();
            ObservableCollection<SystemRule> systemRules = new ObservableCollection<SystemRule>(JsonConvert.DeserializeObject<IEnumerable<SystemRule>>(systemRulesJSON));

            return systemRules;
        }


        public ObservableCollection<ReloadTask> GetReloadTasks()
        {
            string reloadTasksJSON = GetReloadTasksJSON();
            ObservableCollection<ReloadTask> reloadTasks = new ObservableCollection<ReloadTask>(JsonConvert.DeserializeObject<IEnumerable<ReloadTask>>(reloadTasksJSON));

            return reloadTasks;
        }

        public ObservableCollection<QsStream> GetStreams()
        {
            string streamsJSON = GetStreamsJSON();
            ObservableCollection<QsStream> streams = new ObservableCollection<QsStream>(JsonConvert.DeserializeObject<IEnumerable<QsStream>>(streamsJSON));

            return streams;
        }

        public ObservableCollection<App> GetApps()
        {
            string appsJSON = GetAppsJSON();
            ObservableCollection<App> apps = new ObservableCollection<App>(JsonConvert.DeserializeObject<IEnumerable<App>>(appsJSON));

            return apps;
        }

        public ObservableCollection<User> GetUsers()
        {
            string usersJSON = GetUsersJSON();
            ObservableCollection<User> users = new ObservableCollection<User>(JsonConvert.DeserializeObject<IEnumerable<User>>(usersJSON));

            return users;
        }

        public ObservableCollection<CompositeEvent> GetCompositeEvents()
        {
            string compositeEventsJSON = GetCompositeEventsJSON();
            ObservableCollection<CompositeEvent> compositeEvents = new ObservableCollection<CompositeEvent>(JsonConvert.DeserializeObject<IEnumerable<CompositeEvent>>(compositeEventsJSON));

            return compositeEvents;
        }

        #endregion API Gets

        #endregion API Methods
    }
}
