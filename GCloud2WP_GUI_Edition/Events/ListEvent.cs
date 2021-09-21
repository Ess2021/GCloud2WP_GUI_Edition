using System;
using System.Collections.Generic;
using System.Text;

namespace GCloud2WP_GUI_Edition.Events {
    public partial class ListEvent {

        public static string[] ToList (string str) {

            return str.Replace("\r\n", "\n").Split(new[] { '\n', '\r' });
        }

        public static string WriteList (string[] list) {

            string output = "";
            for (int i = 0; i <= list.Length - 1; i++) {
                output += list[i] + "\n";
            }
            return output + list[list.Length - 1];
        }
    }
}
