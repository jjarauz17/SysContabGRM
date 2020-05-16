using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Connectivity
{
    public class LoadFileFtp
    {

        public bool FtpUp(string filename, DataTable _dt)
        {

            FileInfo objFile = new FileInfo(filename);
            //FtpWebRequest objFTPRequest;

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + _dt.Rows[0]["ftpServerIP"].ToString() + "/Zoho/" + objFile.Name);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(_dt.Rows[0]["ftpUserName"].ToString(),
                _dt.Rows[0]["ftpPassword"].ToString());

            request.UseBinary = false;
            request.UsePassive = true;

            try

            {
                // Copy the contents of the file to the request stream.
                byte[] fileContents;
                using (StreamReader sourceStream = new StreamReader(filename))
                {
                    fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
                }

                request.ContentLength = fileContents.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(fileContents, 0, fileContents.Length);
                }

                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    Console.WriteLine($"Upload File Complete, status {response.StatusDescription}");
                }

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


            //// Create FtpWebRequest object 
            //objFTPRequest = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + _dt.Rows[0]["ftpServerIP"].ToString() + "/Zoho/" + objFile.Name));

            //// Set Credintials
            //objFTPRequest.Credentials = 
            //    new NetworkCredential(_dt.Rows[0]["ftpUserName"].ToString(), _dt.Rows[0]["ftpPassword"].ToString());

            //// By default KeepAlive is true, where the control connection is 
            //// not closed after a command is executed.
            //objFTPRequest.KeepAlive = false;

            //// Set the data transfer type.
            //objFTPRequest.UseBinary = true;

            //// Set content length
            //objFTPRequest.ContentLength = objFile.Length;

            //// Set request method
            //objFTPRequest.Method = WebRequestMethods.Ftp.UploadFile;

            //// Set buffer size
            //int intBufferLength = 16 * 1024;
            //byte[] objBuffer = new byte[intBufferLength];

            //// Opens a file to read
            //FileStream objFileStream = objFile.OpenRead();

            //try

            //{
            //    // Get Stream of the file
            //    Stream objStream = objFTPRequest.GetRequestStream();
            //    int len = 0;

            //    while ((len = objFileStream.Read(objBuffer, 0, intBufferLength)) != 0)
            //    {
            //        // Write file Content 
            //        objStream.Write(objBuffer, 0, len);
            //    }

            //    objStream.Close();
            //    objFileStream.Close();

            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}


        }

        public List<string> GetFileList(string Directory,
            DataTable _dt)

        {
            List<string> Files = new List<string>();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(_dt.Rows[0]["ftpServerIP"].ToString() + Directory));
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            //request.Credentials = new NetworkCredential(ServerInfo.Username, ServerInfo.Username); // Is this correct?
            request.Credentials = new NetworkCredential(_dt.Rows[0]["ftpUserName"].ToString(),
                _dt.Rows[0]["ftpPassword"].ToString()); // Or may be this one?

            request.UseBinary = false;
            request.UsePassive = true;
            request.EnableSsl = false;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string CurrentLine = reader.ReadLine();
            while (!string.IsNullOrEmpty(CurrentLine))
            {
                Files.Add(CurrentLine);
                CurrentLine = reader.ReadLine();
            }
            reader.Close();
            response.Close();
            return Files;
        }

        public void UploadFTP(string FilePath, string RemotePath, string Login, string Password)

        {

            using (FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read))

            {

                string url = Path.Combine(RemotePath, Path.GetFileName(FilePath));
                // Creo el objeto ftp
                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(url);
                // Fijo las credenciales, usuario y contraseña

                //ftp.Credentials = new NetworkCredential(
                //    $"@{Login.Normalize()}", $"@{Password.Normalize()}", "facturaelectronica.equipsa.net");

                var v = Login.Normalize();


                ftp.Credentials = new NetworkCredential(Login, Password);
                //ftp.Credentials = new NetworkCredential($"@{Login.Normalize()}", $"@{Password.Normalize()}");

                ftp.UseDefaultCredentials = true;
                ftp.EnableSsl = false;
                ftp.UsePassive = true;

                // Le digo que no mantenga la conexión activa al terminar.
                ftp.KeepAlive = false;
                // Indicamos que la operación es subir un archivo...
                ftp.Method = WebRequestMethods.Ftp.UploadFile;
                // â€¦ en modo binario â€¦ (podria ser como ASCII)
                ftp.UseBinary = false;
                // Indicamos la longitud total de lo que vamos a enviar.
                ftp.ContentLength = fs.Length;
                // Desactivo cualquier posible proxy http.
                // Ojo pues de saltar este paso podría usar 
                // un proxy configurado en iexplorer
                ftp.Proxy = null;
                // Pongo el stream al inicio
                fs.Position = 0;
                // Configuro el buffer a 2 KBytes
                int buffLength = 2048;
                byte[] buff = new byte[buffLength];
                int contentLen;
                // obtener el stream del socket sobre el que se va a escribir.
                using (Stream strm = ftp.GetRequestStream())
                {
                    // Leer del buffer 2kb cada vez
                    contentLen = fs.Read(buff, 0, buffLength);
                    // mientras haya datos en el buffer â€¦.
                    while (contentLen != 0)
                    {
                        // escribir en el stream de conexión
                        //el contenido del stream del fichero
                        strm.Write(buff, 0, contentLen);
                        contentLen = fs.Read(buff, 0, buffLength);
                    }
                }
            }
        }

    }
}
