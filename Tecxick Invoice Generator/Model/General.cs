using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecxick_Invoice_Generator.Model
{
    internal class General
    {
        /// <summary>
        /// Writes a Message to the Log File
        /// </summary>
        /// <param name="Message">Message That Needs to be written in the Log</param>
        internal static async Task Log(String Message)
        {
            try
            {
                // Get the Application Local Folder
                var AppFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                // Create the Log file and if it is already exixsts, open it for the operation
                var LogFile = await AppFolder.CreateFileAsync("Log.txt", Windows.Storage.CreationCollisionOption.OpenIfExists);
                // When the Write Request is called
                string Timestamp = "[" + DateTime.Now.ToString("G") + "] ";
                // Build the full Text and add a line breake
                string textToWrite = Timestamp + Message + "\n";
                // Write the Text to the Log File
                await Windows.Storage.FileIO.AppendTextAsync(LogFile, textToWrite);

                //Debug
                Debug.WriteLine(LogFile.Path);
            }
            catch (Exception ex)
            {
                //Debug
                Debug.WriteLine("Something Went Wrong! " + ex.Message);
                
            }
            
        }
    }
}
