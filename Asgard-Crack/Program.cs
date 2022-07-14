using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net;

using HttpServer;

namespace Asgard_Crack
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Title = "asgard crack - made by parkie#3604";
            Console.WindowWidth = 180;
            Console.WindowHeight = 40;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\n\n");
            //             ....................................................................................................................................................................................
            Console.Write("                                                                                     ##                                                      /        \n");
            Console.Write("                                                                                     ##                                                    #/         \n");
            Console.Write("                                                                                     ##                                                    ##         \n");
            Console.Write("                                                                                     ##                                                    ##         \n");
            Console.Write("                                                                                     ##                                                    ##         \n");
            Console.Write("                              /###      /###      /###      /###   ###  /###     ### ##              /###   ###  /###     /###     /###    ##  /##    \n");
            Console.Write("                             / ###  /  / #### /  /  ###  / / ###  / ###/ #### / #########           / ###  / ###/ #### / / ###  / / ###  / ## / ###   \n");
            Console.Write("                            /   ###/  ##  ###/  /    ###/ /   ###/   ##   ###/ ##   ####           /   ###/   ##   ###/ /   ###/ /   ###/  ##/   /    \n");
            Console.Write("                           ##    ##  ####      ##     ## ##    ##    ##        ##    ##           ##          ##       ##    ## ##         ##   /     \n");
            Console.Write("                           ##    ##    ###     ##     ## ##    ##    ##        ##    ##           ##          ##       ##    ## ##         ##  /      \n");
            Console.Write("                           ##    ##      ###   ##     ## ##    ##    ##        ##    ##           ##          ##       ##    ## ##         ## ##      \n");
            Console.Write("                           ##    ##        ### ##     ## ##    ##    ##        ##    ##           ##          ##       ##    ## ##         ######     \n");
            Console.Write("                           ##    /#   /###  ## ##     ## ##    /#    ##        ##    /#           ###     /   ##       ##    /# ###     /  ##  ###    \n");
            Console.Write("                            ####/ ## / #### /   ########  ####/ ##   ###        ####/              ######/    ###       ####/ ## ######/   ##   ### / \n");
            Console.Write("                             ###   ##   ###/      ### ###  ###   ##   ###        ###                #####      ###       ###   ## #####     ##   ##/  \n");
            Console.Write("                                                       ###                                        \n");
            Console.Write("                                                 ####   ###                                       \n");
            Console.Write("                                               /######  /#                                        \n");
            Console.Write("                                              /     ###/                                          \n\n\n\n\n\n");



            Console.Write("                                                                            [+] made by parkie#3604\n\n");
            Console.Write("                                                                            [+] github.com/0ez\n\n"); Thread.Sleep(500);
            // 127.0.0.1 a086e0efbad65f0bb.awsglobalaccelerator.com
            if (!File.ReadAllText("C:\\Windows\\System32\\drivers\\etc\\hosts").Contains("127.0.0.1 a086e0efbad65f0bb.awsglobalaccelerator.com"))
            {
                using (FileStream fs = new FileStream("C:\\Windows\\System32\\drivers\\etc\\hosts", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    StreamWriter write = new StreamWriter(fs);
                    write.BaseStream.Seek(0, SeekOrigin.End);
                    write.WriteLine(Environment.NewLine);
                    write.WriteLine("127.0.0.1 a086e0efbad65f0bb.awsglobalaccelerator.com");
                    write.Flush();
                    write.Close();
                    fs.Close();
                }
            }
            //File.Delete("C:\\Windows\\System32\\drivers\\etc\\hosts");
            //WebClient webClient = new WebClient();
            //webClient.DownloadFile("https://cdn.discordapp.com/attachments/724153110808887340/996905777577087056/hosts", "C:\\Windows\\System32\\drivers\\etc\\hosts");

            Server1.Start();
            Server2.Start();

            Console.Write("                                                                            [+] bypass running!\n\n");
            Console.Write("                                                                            [+] run a-r.exe\n\n");

            Console.ReadKey();
        }
    }
}
