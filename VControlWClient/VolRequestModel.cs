using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VControlWClient
{
    class VolRequestModel
    {
        private int req;
        private int increment;

        public int Req
        {
            get
            {
                return req;
            }

            set
            {
                req = value;
            }
        }

        public int Increment
        {
            get
            {
                return increment;
            }

            set
            {
                increment = value;
            }
        }
    }
}
