using Starcounter;

namespace Simple {
    partial class Simple : Json {
        void Handle(Input.Reverse action) {
            char[] arr = Text.ToCharArray();
            System.Array.Reverse(arr);
            Text = new string(arr);
        }
    }
}
