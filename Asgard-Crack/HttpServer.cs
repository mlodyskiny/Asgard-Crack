using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

//
//  Yes, I know that doing shit like that (2 diff servers) is dumb, but the user will only use them for few seconds
//

namespace HttpServer
{
    public class Server1
    {
        public static int Port = 80;

        private static HttpListener _listener;

        public static void Start()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://*:" + Port.ToString() + "/api/v1/user/");
            _listener.Start();
            Receive();
        }

        public static void Stop()
        {
            _listener.Stop();
        }

        private static void Receive()
        {
            _listener.BeginGetContext(new AsyncCallback(ListenerCallback), _listener);
        }
        private static void ProcessRequest(HttpListenerContext context)
        {
            // Get the data from the HTTP stream
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();

            string content = "{'message': 'success', 'account': {'username': 'cracked by parkie#3604', 'tokenAccessToken': 'fuckpython', 'banned': 'false', 'expired': 'false', 'expirationDate': '2077-01-01', 'daysLeft': 69420, 'preset': 'null'}}";
            string download = "{'download':'https://cdn.discordapp.com/attachments/804178032280600647/986163950079053874/A-R.exe','version':'R1.1.0'}";

            byte[] b = Encoding.UTF8.GetBytes(content);

            
            context.Response.StatusCode = 200;
            context.Response.KeepAlive = false;
            context.Response.ContentLength64 = b.Length;

            var output = context.Response.OutputStream;
            output.Write(b, 0, b.Length);
            context.Response.Close();
        }
        private static void ListenerCallback(IAsyncResult result)
        {

            if (_listener.IsListening)
            {
                var context = _listener.EndGetContext(result);
                var request = context.Request;

                ProcessRequest(context);

                Receive();
            }
        }
    }

    public class Server2
    {
        public static int Port = 80;

        private static HttpListener _listener;

        public static void Start()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://*:" + Port.ToString() + "/api/v1/application/");
            _listener.Start();
            Receive();
        }

        public static void Stop()
        {
            _listener.Stop();
        }

        private static void Receive()
        {
            _listener.BeginGetContext(new AsyncCallback(ListenerCallback), _listener);
        }
        private static void ProcessRequest(HttpListenerContext context)
        {
            // Get the data from the HTTP stream
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();

            string download = "{'download':'https://cdn.discordapp.com/attachments/804178032280600647/986163950079053874/A-R.exe','version':'R1.1.0'}";

            byte[] b = Encoding.UTF8.GetBytes(download);


            context.Response.StatusCode = 200;
            context.Response.KeepAlive = false;
            context.Response.ContentLength64 = b.Length;

            var output = context.Response.OutputStream;
            output.Write(b, 0, b.Length);
            context.Response.Close();
        }
        private static void ListenerCallback(IAsyncResult result)
        {

            if (_listener.IsListening)
            {
                var context = _listener.EndGetContext(result);
                var request = context.Request;

                ProcessRequest(context);

                Receive();
            }
        }
    }
}
