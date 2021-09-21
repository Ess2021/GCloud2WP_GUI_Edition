using System;
using System.Collections.Generic;
using System.Text;

namespace GCloud2WP_GUI_Edition.Events {
    public partial class Convert {

        public static string Html (string url) {

            string output = ("<figure class=\"wp-block-image size-large is-style-default\"><img src = \"THISISTHEURL\" alt=\"\" class=\"wp-image-57\"/></figure>");

            try {
                url = url.Replace("file/d/", "uc?export=view&id=");
                url = url.Replace("/view?usp=sharing", "") + "#Converted_by_GCloud2WP";
                output = output.Replace("THISISTHEURL", url);
                return output;
            } catch {
                return "Something went wrong!";
            }

        }

        public static string Url (string url) {

            string output = ("THISISTHEURL");

            try {
                url = url.Replace("file/d/", "uc?export=view&id=");
                url = url.Replace("/view?usp=sharing", "") + "#Converted_by_GCloud2WP";
                output = output.Replace("THISISTHEURL", url);
                return output;
            } catch {
                return "Something went wrong!";
            }

        }
    }
}
