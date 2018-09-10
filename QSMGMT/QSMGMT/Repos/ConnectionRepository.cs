using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSMGMT.Repos
{
    class ConnectionRepository
    {
        private List<Connection> _connectionList;
        private string connectionPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\Connections", "Connections.txt");


        public ConnectionRepository ()
        {
            
        }

        public List<Connection> ConnectionList
        {
            get
            {
                LoadConnections();
                return _connectionList;
            }

            set
            {
                _connectionList = value;
            }
        }


        public Connection GetConnectionByName (string name)
        {
            try
            {
                Connection conn = _connectionList.First(connect => connect.Name.Equals(name));
                return conn;
            }
            catch (Exception)
            {
                return null;
            }
           
        }


        private void LoadConnections()
        {
            _connectionList = new List<Connection>();

            try
            {
                StreamReader read = new StreamReader(connectionPath);
                using (read)
                {
                    while (!read.EndOfStream)
                    {
                        
                        string[] connections = read.ReadLine().Split('|');
                        Connection conn = new Connection(connections[0], connections[1], connections[2], connections[3], connections[4], connections[5]);
                        _connectionList.Add(conn);
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                throw new Exception("No existing connections found.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("General error.", ex);
            }
        }

        private void SaveConnection(Connection conn)
        {
            try
            {
                StreamWriter write = new StreamWriter(connectionPath, true);
                using (write)
                {
                    write.WriteLine(    conn.BaseUrl
                                        + "|"
                                        + conn.Pfx
                                        + "|"
                                        + conn.PfxPass
                                        + "|"
                                        + conn.UserId
                                        + "|"
                                        + conn.Domain
                                        + "|"
                                        + conn.Name
                    );

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void AddConnection(Connection conn)
        {
            Connection testExists = GetConnectionByName(conn.Name);

            if (testExists != null)
            {
                throw new Exception("Connection already exists!");
            }
            else
            {
                SaveConnection(conn);
                _connectionList.Add(conn);
            }
        }
    }
}
