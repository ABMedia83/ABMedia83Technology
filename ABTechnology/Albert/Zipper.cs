

namespace Albert;

public delegate void ZipFileEventHandler(FileStream stream, ZipArchive zip);
/// <summary>
/// Module is designed to deal with ZIp Files 
/// </summary>
public static class Zipper
{

    public static void CreateZipFile(string _fileName, ZipFileEventHandler _method )
    {
        using (var stream = new FileStream(_fileName, FileMode.Create))
        {
            using (ZipArchive zip = new ZipArchive(stream, ZipArchiveMode.Create))
            {
                //Invoke the EventHandler 
                _method.Invoke(stream, zip);
                
            }
            stream.Flush();
        }

     
    }

    public static void ReadZipFile(string _fileName, ZipFileEventHandler _method)
    {
        using (var stream = new FileStream(_fileName, FileMode.Create))
        {
            using (ZipArchive zip = new ZipArchive(stream, ZipArchiveMode.Read))
            {
                //Invoke the EventHandler 
                _method.Invoke(stream, zip);
                 

            }
            stream.Flush();
        }
    }

}
