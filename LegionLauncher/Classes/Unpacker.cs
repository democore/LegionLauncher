using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.IO;
using SevenZip;

namespace LegionLauncher
{
    public class Unpacker
    {
        public Action<Addon, int, long, long> progressCallback;
        public Action<Addon> doneCallback;
        public Addon addon;

        public void unpackFile(String path, Action<Addon, int, long, long> progressCallback, Action<Addon> doneCallback, Addon addon)
        {
            this.progressCallback = progressCallback;
            this.doneCallback = doneCallback;
            this.addon = addon;

            SevenZipExtractor.SetLibraryPath(AppDomain.CurrentDomain.BaseDirectory + "7z.dll");

            ReadOnlyCollection<string> readOnlyArchiveFilenames;
            ReadOnlyCollection<string> readOnlyVolumeFilenames;
            String rarFile = path + "\\" + addon.realFileName;
            try
            {
                using (SevenZipExtractor extr = new SevenZipExtractor(rarFile))
                {
                    readOnlyArchiveFilenames = extr.ArchiveFileNames;
                    readOnlyVolumeFilenames = extr.VolumeFileNames;

                    extr.Extracting += extr_Extracting;
                    extr.FileExtractionStarted += extr_FileExtractionStarted;
                    extr.FileExists += extr_FileExists;
                    extr.ExtractionFinished += extr_ExtractionFinished;

                    extr.ExtractArchive(Path.GetFullPath(path));
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void extr_FileExists(object sender, FileOverwriteEventArgs e)
        {
            
        }
        private void extr_FileExtractionStarted(object sender, FileInfoEventArgs e)
        {

        }
        private void extr_Extracting(object sender, ProgressEventArgs e)
        {
            progressCallback(addon, e.PercentDone, -1, -1);
        }
        private void extr_ExtractionFinished(object sender, EventArgs e)
        {
            doneCallback(addon);
        }
    }
}
