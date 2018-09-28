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
        internal enum UpdateType
        {
            PUT,
            GET,
            DELETE,
            POST
        }

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

        public string GetBasicAPICall(string endpoint, UpdateType type, string httpBody = "")
        {
            DisableCertificateSecurity();

            //Create URL to REST endpoint for tickets
            string url = Path.Combine(_currentConn.BaseUrl + _repositoryAPIPortAndAddress + endpoint);

            //Create the HTTP Request and add required headers and content in Xrfkey
            string Xrfkey = "0123456789xbcdef";
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create(url + "?xrfkey=" + Xrfkey);
            // Add the method to authentication the user
            Request.ClientCertificates.Add(_currentConn.Cert);
            Request.Method = type.ToString();
            Request.Accept = "application/json";
            Request.Headers.Add("X-Qlik-Xrfkey", Xrfkey);
            Request.Headers.Add("X-Qlik-User", "UserDirectory=INTERNAL; UserId=SA_ENGINE");



            if (!string.IsNullOrEmpty(httpBody))
            {
                ASCIIEncoding encoder = new ASCIIEncoding();
                byte[] data = encoder.GetBytes(httpBody);
                encoder = null;

                Request.ContentType = "application/json";
                Request.Expect = "application/json";
                Request.ContentLength = data.Length;

                Request.GetRequestStream().Write(data, 0, data.Length);

            }

            // make the web request and return the content
            HttpWebResponse Response = Response = (HttpWebResponse)Request.GetResponse();

            Stream Stream = Response.GetResponseStream();
            string json = new StreamReader(Stream).ReadToEnd();

            var jsonObj = JsonConvert.DeserializeObject(json);
            return JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
        }


        #region API Deletes

        public string DeleteSecurityRule(SystemRule rule)
        {
            string systemRuleJson = JsonConvert.SerializeObject(rule);

            string resultJson = GetBasicAPICall(@"systemrule\" + rule.id, UpdateType.DELETE, systemRuleJson);

            return resultJson;
        }

        #endregion API Deletes

        #region API Updates


        public SystemRule UpdateSingleSecurityRule(SystemRule rule)
        {
            string systemRuleJson = JsonConvert.SerializeObject(rule);

            string resultJson = GetBasicAPICall(@"systemrule\" + rule.id, UpdateType.PUT, systemRuleJson);

            return JsonConvert.DeserializeObject<SystemRule>(resultJson);
        }

        #endregion API Updates

        #region API Gets

        public string GetSwaggerJSON()
        {
            return GetBasicAPICall("about/openapi/main", UpdateType.GET);
        }

        public string GetEnumsJSON()
        {
            return GetBasicAPICall("about/api/enums", UpdateType.GET);
        }


        public string GetSecurityRulesJSON()
        {
            return GetBasicAPICall("systemrule/full", UpdateType.GET);
        }

        public string GetReloadTasksJSON()
        {
            return GetBasicAPICall("reloadtask/full", UpdateType.GET);
        }

        public string GetStreamsJSON()
        {
            return GetBasicAPICall("stream/full", UpdateType.GET);
        }

        public string GetAppsJSON()
        {
            return GetBasicAPICall("app/full", UpdateType.GET);
        }

        public string GetUsersJSON()
        {
            return GetBasicAPICall("user/full", UpdateType.GET);
        }

        public string GetCompositeEventsJSON()
        {
            return GetBasicAPICall("compositeevent/full", UpdateType.GET);
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
