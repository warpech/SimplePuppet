using System;
using Starcounter;

namespace Simple {
    class Program {
        static void Main() {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/simple", () => {
                var json = new Simple();
                json.Session = new Session(SessionOptions.PatchVersioning);
                return json;
            });

            Handle.GET("/simple/raw", () => {
                var json = new Raw();
                return json;
            });
        }
    }
}