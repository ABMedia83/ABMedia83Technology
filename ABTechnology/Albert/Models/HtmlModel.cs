/*
 <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
</body>
</html>
 * */

namespace Albert.Models
{
    /// <summary>
    /// Class is designed to generate an Html Model 
    /// </summary>
    public class HtmlModel: Item
    {
        string? head, title, body, footer;

        public HtmlModel()
        {
            //Do Nothing 
        }
        /// <summary>
        /// Constructor creates and entire Page 
        /// </summary>
        /// <param name="_title"></param>
        /// <param name="_head"></param>
        /// <param name="_body"></param>
        /// <param name="_footer"></param>
        public HtmlModel (string _title,string _head,string _body,string _footer)
        {
            Head = _head;
            Title = _title;
            Body = _body;
            Footer = _footer;  
        }

        public string? Head
        {
            get => head;
            set { head = value; OnPropertyChanged("Head"); }
        }

        public string? Title
        {
            get => title;
            set { title = value; OnPropertyChanged("Title"); }
        }
        public string? Body
        {
            get => body;
            set { body = value; OnPropertyChanged("Body"); }
        }

        public string? Footer
        {
            get => footer;
            set { footer = value; OnPropertyChanged("Footer"); }
        }
        /// <summary>
        /// ToString Generates a Html Document 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string? rv = "<DOCTYPE html>\n";
            rv += "<html lang=\"en\">\n";
            rv += "<head>\n";
            rv += "<meta charset=\"UTF-8\" >\n";
            rv += " <meta http-equiv\"X - UA - Compatible\" content=\"IE = edge\">\n";
            rv += " <meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\">\n";
            rv += $"<title>{Title}<title>\n";
            rv += $"{Head}\n";
            rv += "</head>\n";
            rv += "<body>\n\n";
            rv += $"{Body}\n\n";
            rv += $"{Footer}\n\n";
            rv += "</body>\n";
            return rv;
        }
    }


}
