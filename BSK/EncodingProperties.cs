using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSK
{
    class EncodingProperties
    {        
        public String path;
        public int? key_length;
        public int? box_lenght;
        public String mode;
        public int? subbox_lenght;
        public String password;

        public EncodingProperties()
        {
            path = "";
            key_length = null;
            box_lenght = null;
            mode = "";
            subbox_lenght = null;
            password = "";
        }
    }
}
