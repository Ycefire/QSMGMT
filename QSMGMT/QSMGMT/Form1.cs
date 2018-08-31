using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using Qlik.Engine;
using Qlik.Engine.Communication;
using System.IO;

namespace QSMGMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        internal static byte[] ReadFile(string fileName)
        {
            FileStream f = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int size = (int)f.Length;
            byte[] data = new byte[size];
            size = f.Read(data, 0, size);
            f.Close();
            return data;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ILocation location = null;
            try
            {
                var uri = new Uri("https://qliksense.credon.eu:4747");
                location = Qlik.Engine.Location.FromUri(uri);
                X509Certificate2 x509 = new X509Certificate2(@"C:\\GITHUB\\QSMGMT\\QSMGMT\\QSMGMT\\QS Certificates\\CRED DEMO SERVER\\CREDON35\\client.pfx","test");
                location.IsVersionCheckActive = false;
                X509Certificate2Collection certificateCollection = new X509Certificate2Collection(x509);
                // Defining the location as a direct connection to Qlik Sense Server
                location.AsDirectConnectionAsync("DEMO", "QSADMIN", certificateValidation: false, certificateCollection: certificateCollection); 
            }
            catch (CommunicationErrorException cex)
            {
                Console.WriteLine("Can not connect to Qlik Sense instance, check that Qlik Sense is running." + Environment.NewLine + cex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General error." + Environment.NewLine + ex.Message);
            }

            //  String[] test = new String[] { "test"}; 

            List<String> test = new List<String>();

            foreach (IAppIdentifier appIdentifier in location.GetAppIdentifiers())
            {
                Console.WriteLine(appIdentifier.AppName);
                test.Add(appIdentifier.AppName);
            }

            listBox1.DataSource = test;
        }
    }
}
