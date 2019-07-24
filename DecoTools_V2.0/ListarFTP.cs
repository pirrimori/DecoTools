using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace DecoTools_V2._0
{
    public class ListarFTP
    {
        FormPrincipal not = new FormPrincipal();

        public string[] GetFileList(string ip,string user,string pass)
            {
            FormFtp ftp = new FormFtp();

                string[] downloadFiles;
                StringBuilder result = new StringBuilder();
                WebResponse response = null;
                StreamReader reader = null;
                try
                {
                    FtpWebRequest reqFTP;
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ip + "/"));
                    reqFTP.UseBinary = true;
                    reqFTP.Credentials = new NetworkCredential(user, pass);
                    reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                    reqFTP.Proxy = null;
                    reqFTP.KeepAlive = false;
                    reqFTP.UsePassive = false;
                    response = reqFTP.GetResponse();
                    reader = new StreamReader(response.GetResponseStream());
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        result.Append(line);
                        result.Append("\n");
                        line = reader.ReadLine();
                    }
                    // to remove the trailing '\n'
                    result.Remove(result.ToString().LastIndexOf('\n'), 1);
                    return result.ToString().Split('\n');
                }
                catch (Exception ex)
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    if (response != null)
                    {
                        response.Close();
                    }
                    downloadFiles = null;
                    return downloadFiles;
                }
            }

            public void Download(string file,string ip,string ftpDir,string user,string pass)
            {

                string localDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Temp";

            try
                {
                    string uri = "ftp://" + ip + "/" + ftpDir + "/" + file;
                    Uri serverUri = new Uri(uri);
                    if (serverUri.Scheme != Uri.UriSchemeFtp)
                    {
                        return;
                    }
                    FtpWebRequest reqFTP;
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ip + "/" + ftpDir + "/" + file));
                    reqFTP.Credentials = new NetworkCredential(user, pass);
                    reqFTP.KeepAlive = false;
                    reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                    reqFTP.UseBinary = true;
                    reqFTP.Proxy = null;
                    reqFTP.UsePassive = false;
                    FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    FileStream writeStream = new FileStream(localDir + "\\" + file, FileMode.Create);
                    int Length = 2048;
                    Byte[] buffer = new Byte[Length];
                    int bytesRead = responseStream.Read(buffer, 0, Length);
                    while (bytesRead > 0)
                    {
                        writeStream.Write(buffer, 0, bytesRead);
                        bytesRead = responseStream.Read(buffer, 0, Length);
                    }
                    writeStream.Close();
                    response.Close();
                }
                catch (WebException wEx)
                {
                not.PopupNotificacion(Properties.Resources.error, "Error: " + wEx.Message.ToString(), "Error");
            }
                catch (Exception ex)
                {
                not.PopupNotificacion(Properties.Resources.error, "Error: " + ex.Message.ToString(), "Error");
                
                }
            }



    }
}
