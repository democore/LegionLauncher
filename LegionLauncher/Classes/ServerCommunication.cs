using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.ComponentModel;

namespace LegionLauncher
{
    /// <summary>
    /// used to communicate with server
    /// </summary>
    public class ServerCommunication
    {
        Action<List<Addon>> downloadableAddonsFinishedCallback = null;
        Action<Addon, int, long, long> downloadAdvanced = null;
        Action<Addon> downloadFinished = null;
        Action<List<Server>> downloadedModsetsCallback;

        String addonsJsonPath = "ftp://ModLoaderUser@81.169.221.10/addons.json";
        String modsetsJsonPath = "ftp://ModLoaderUser@81.169.221.10/Modsets.json";
        String downloadPath = "";

        #region download list of downloadable addons
        public void getDownloadableAddons(Action<List<Addon>> callback)
        {
            downloadableAddonsFinishedCallback = callback;
            using (WebClient wc = new WebClient())
            {
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(getDownloadableAddons_DownloadStringCompleted);
                wc.DownloadStringAsync(new System.Uri(addonsJsonPath));
            }
        }

        void getDownloadableAddons_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                downloadableAddonsFinishedCallback(Helper.createListFromJSON(e.Result));
            }
        }
        #endregion

        #region download addon from server
        public void download(List<Addon> addons, Action<Addon, int, long, long> singleProgressCallback, Action<Addon> singleDoneCallback, String downloadPath)
        {
            this.downloadPath = downloadPath;
            downloadAdvanced = singleProgressCallback;
            downloadFinished = singleDoneCallback;
            
            foreach (Addon addon in addons)
            {
                if (addon.Link != "")
                {
                    addon.downloadedPath = downloadPath;

                    BackgroundWorker worker = new BackgroundWorker();
                    worker.DoWork += new DoWorkEventHandler(worker_DoWork);
                    worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
                    worker.RunWorkerAsync(addon);
                }
                else
                {
                    downloadFinished(addon);
                }
            }
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            object[] arr = e.Result as object[];
            Addon addon = arr[0] as Addon;
            long size = (long)arr[1];
            using (WebClient wc = new WebClient())
            {
                wc.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(downloadAddon_DownloadFileCompleted);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadAddon_DownloadProgressChanged);
                wc.DownloadFileAsync(new Uri(addon.link), downloadPath + "\\" + addon.realFileName, new object[] { addon, size });
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Addon addon = (e.Argument as Addon);
            FtpWebRequest f = WebRequest.Create(addon.link) as FtpWebRequest;
            f.Method = WebRequestMethods.Ftp.GetFileSize;
            FtpWebResponse fr = f.GetResponse() as FtpWebResponse;
            long length = fr.ContentLength;
            fr.Close();
            e.Result = new object[]{addon, length};
        }

        void downloadAddon_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            object[] arr = e.UserState as object[];
            Addon addon = arr[0] as Addon;
            Unpacker unpacker = new Unpacker();
            unpacker.unpackFile(addon.downloadedPath, downloadAdvanced, downloadFinished, addon);
        }

        void downloadAddon_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            object[] arr = e.UserState as object[];
            downloadAdvanced(arr[0] as Addon, (int)(((double)e.BytesReceived / (double)(long)arr[1]) * 100), (long)arr[1], e.BytesReceived);
        }
        #endregion

        #region download list of Modsets and Servers
        public void getModsets(Action<List<Server>> downloadedModsetsCallback)
        {
            this.downloadedModsetsCallback = downloadedModsetsCallback;
            using (WebClient wc = new WebClient())
            {
                wc.DownloadStringCompleted += new DownloadStringCompletedEventHandler(getModset_DownloadStringCompleted);
                wc.DownloadStringAsync(new System.Uri(modsetsJsonPath));
            }
        }
        void getModset_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                downloadedModsetsCallback(Helper.createserversFromModsetsJSON(e.Result));
            }
        }
        #endregion
    }
}
