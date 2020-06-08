using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace XCopyGuiProject
{
    static class Program
    {

        private const string arg_source = "/source:";
        private const string arg_destination = "/destination:";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string sourceFolder = null;
            string destinationFolder = null;
            try
            {
                foreach(string argo in Environment.GetCommandLineArgs()) {
                    string arg = argo.Trim();
                    if (arg.StartsWith(arg_source))
                        sourceFolder = arg.Substring(arg_source.Length);
                    else if(arg.StartsWith(arg_destination))
                        destinationFolder = arg.Substring(arg_destination.Length);
                }
            }
            catch (Exception)
            { 
            }

            if (sourceFolder == null) {
                Thread thread = new Thread(() => {
                    try
                    {
                        StringCollection ll = Clipboard.GetFileDropList();
                        if (ll.Count == 1 && new DirectoryInfo(ll[0]).Exists)
                            sourceFolder = ll[0];
                    }
                    catch (Exception)
                    {
                    }
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(sourceFolder, destinationFolder));
        }
    }
}
