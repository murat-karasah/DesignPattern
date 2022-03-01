using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTone
{
   public class TableServer
    {
        //Uygulamada bir sınıfımızdan sadece bir nesne oluşturmak istiyorsak kullanılır. SingleTone sayesinde ikinci bir nesne oluşturulmaz.
        private static readonly TableServer _instance = new TableServer();
        private List<string> servers = new List<string>();
        private int nextServer = 0;
        /*public*/private TableServer()
        {
            servers.Add("Tim");
            servers.Add("Bob");
            servers.Add("John");
            servers.Add("Mary");
            servers.Add("Sue");
        }
        public static TableServer GetTableServer()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer += 1;
            if (nextServer>=servers.Count())
            {
                nextServer = 0;
            }
            return output;
        }
    }
}
