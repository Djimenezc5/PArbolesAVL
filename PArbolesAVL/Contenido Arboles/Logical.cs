﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PArbolesAVL.Contenido_Arboles
{
    class Logical
    {
        Boolean v;
        public Logical(Boolean f)
        {
            v = f;
        }
        public void setLogical(Boolean f)
        {
            v = f;
        }
        public Boolean booleanValue()
        {
            return v;
        }
    }
}
