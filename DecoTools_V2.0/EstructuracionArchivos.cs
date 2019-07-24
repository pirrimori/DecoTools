using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DecoTools_V2._0
{
    public class EstructuracionArchivos
    {

        /// Crear un directorio vacio
        public static void CreateEmptyDirectory(string destPath)
        {
            if (!System.IO.Directory.Exists(destPath))
            {
                System.IO.Directory.CreateDirectory(destPath);
            }
        }

        /// Borrar un directorio y su contenido
        public static void DeleteFolder(string fullPath)
        {
            if (System.IO.Directory.Exists(fullPath))
            {
                System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(fullPath)
                {
                    Attributes = System.IO.FileAttributes.Normal
                };

                foreach (var info in directory.GetFileSystemInfos("*", System.IO.SearchOption.AllDirectories))
                {
                    System.IO.FileInfo fInfo = info as System.IO.FileInfo;
                    if (fInfo != null) info.Attributes = System.IO.FileAttributes.Normal;
                }
                System.Threading.Thread.Sleep(100);
                directory.Delete(true);
            }

        }

        /// Borrar un archivo
        public static void DeleteFile(string fullPath)
        {
            if (System.IO.File.Exists(fullPath))
            {
                System.IO.FileInfo info = new System.IO.FileInfo(fullPath);
                info.Attributes = System.IO.FileAttributes.Normal;
                System.IO.File.Delete(fullPath);
            }
        }

        /// Copiar archivo
        public static void CopyFile(string origPath, string destPath, bool overwrite)
        {
            try
            {
                if (System.IO.Path.GetExtension(destPath) == "")
                {
                    destPath = System.IO.Path.Combine(destPath, System.IO.Path.GetFileName(origPath));
                }
                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(destPath)))
                {
                    CreateEmptyDirectory(System.IO.Path.GetDirectoryName(destPath));
                }
                if (!System.IO.File.Exists(destPath))
                {
                    System.IO.File.Copy(origPath, destPath, true);
                }
                else
                {
                    if (overwrite == true)
                    {
                        DeleteFile(destPath);
                        System.IO.File.Copy(origPath, destPath, true);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// Copiar el contenido de un directorio
        private static void CopyDirectoryContent(string origPath, string destPath, bool overwrite)
        {
            if (System.IO.Directory.Exists(origPath))
            {
                foreach (string dirPath in System.IO.Directory.GetDirectories(origPath, "*", System.IO.SearchOption.AllDirectories))
                {
                    CreateEmptyDirectory(dirPath.Replace(origPath, destPath));
                }

                foreach (string newPath in System.IO.Directory.GetFiles(origPath, "*.*", System.IO.SearchOption.AllDirectories))
                {
                    CopyFile(newPath, newPath.Replace(origPath, destPath), overwrite);
                }
            }
        }

        /// Borra el contenido de un directorio
        public static void DeleteFolderContent(string fullPath)
        {
            DeleteFolder(fullPath);
            CreateEmptyDirectory(fullPath);
        }

        /// Copiar un directorio y su contenido
        public static void CopyDirectory(string origPath, string destPath, bool replace)
        {
            if (replace == true)
            {
                DeleteFolder(destPath);
                CreateEmptyDirectory(destPath);
                CopyDirectoryContent(origPath, destPath, true);
            }
            else
            {
                CopyDirectoryContent(origPath, destPath, true);
            }
        }

    }
}
