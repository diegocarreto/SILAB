using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class TxtHandler
    {
        public static bool Write(string Path, string Content)
        {
            try
            {
                if (System.IO.File.Exists(Path))
                    System.IO.File.Delete(Path);

                using (var fileStream = System.IO.File.Create(Path))
                {
                    var text = new UTF8Encoding(true).GetBytes(Content);

                    fileStream.Write(text, 0, text.Length);
                    fileStream.Flush();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string Read(string Path)
        {
            var content = string.Empty;
           
            using (var fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    content = streamReader.ReadToEnd();
                }
            }

            return content;
        }
    }
}
