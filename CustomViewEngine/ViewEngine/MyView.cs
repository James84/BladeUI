using System.IO;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace CustomViewEngine.UI.ViewEngine
{
    public class MyView : IView
    {
        private string _viewPhysicalPath;

        public MyView(string viewPhysicalPath)
        {
            _viewPhysicalPath = viewPhysicalPath;
        }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            var rawContents = File.ReadAllText(_viewPhysicalPath);

            var parsedContents = Parse(rawContents, viewContext.ViewData);

            writer.Write(parsedContents);
        }

        public string Parse(string contents, ViewDataDictionary viewData)
        {
            return Regex.Replace(contents, "\\{(.+)\\}", m => GetMatch(m, viewData));
        }

        public virtual string GetMatch(Match match, ViewDataDictionary viewData)
        {
            if (match.Success)
            {
                var key = match.Result("$1");

                if (viewData.ContainsKey(key))
                {
                    return viewData[key].ToString();
                }
            }
            return string.Empty;
        }
    }
}