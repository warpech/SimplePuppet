using System;
using Starcounter;

namespace Simple {
    class Program {
        static void Main() {
                Handle.GET("/simple", () => {
                    Session session = Session.Current;

                    if (session != null && session.Data != null)
                        return session.Data;

                    if (session == null) {
                        session = new Session(SessionOptions.PatchVersioning);
                    }

                    var page = new Simple();
                    page.Session = session;
                    return page;
                });
        }
    }
}