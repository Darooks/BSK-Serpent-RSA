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
        public int key_length;
        public int? box_lenght;
        public String mode;
        public int subbox_lenght;
        public String password;

        public EncodingProperties()
        {
            path = "";
            key_length = 128;
            box_lenght = null;
            mode = "";
            password = "asd";
        }

        ~EncodingProperties() { }
    }
}
