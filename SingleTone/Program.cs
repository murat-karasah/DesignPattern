using System;

namespace SingleTone
{
    class Program
    {
        static TableServer host1List = TableServer.GetTableServer();/* = new TableServer();*/
        static TableServer host2List = TableServer.GetTableServer(); /*= new TableServer();*/

        static void Main(string[] args)
        {
            TableServer ts = TableServer.GetTableServer() ; /*= new TableServer();*/
            for (int i = 0; i < 5; i++)
            {
                //Console.WriteLine("The next server is : "+ts.GetNextServer());
                hostListNextServer();
                host2ListNextServer();
            }
            

            Console.ReadLine();
        }

        private static void hostListNextServer()
        {
            Console.WriteLine("The next server is : "+ host1List.GetNextServer());
        }

        private static void host2ListNextServer()
        {
            Console.WriteLine("The next server is : " + host2List.GetNextServer());
        }

    }
}
