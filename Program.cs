using System;
using Starcounter;

namespace Simple {
    class Program {
        static void Main() {
            var htmlFromJson = new MyProvider();
            htmlFromJson.ProvisionImplicitStandalonePages = true;
            Application.Current.Use(htmlFromJson);

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