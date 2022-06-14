

namespace Albert
{
    /// <summary>
    /// Record stores a File Path and Directory location 
    /// </summary>
    public record FileRecord
    {
        public FileRecord(string _file)
        {
            Info = new FileInfo(_file);

            Name = Info.Name;
            FullName = Info.FullName;
            DirectoryName = Info.DirectoryName;

            
        }

        public FileInfo Info { get; init; }

        public string Name { get; init; }
        public string FullName { get; init; }
        public string? DirectoryName { get; init; }

    }
}
