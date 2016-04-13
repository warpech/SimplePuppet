using System;
using Starcounter;

namespace Simple {
    class Program {
        static void Main() {
            Application.Current.Use(new HtmlFromJsonProvider());

            Handle.GET("/simple", () => {
                var json = new Simple();
                return json;
            });

            Handle.GET("/simple/raw", () => {
                var json = new Raw();
                return json;
            });
        }
    }
}