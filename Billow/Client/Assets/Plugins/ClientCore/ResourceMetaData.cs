﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClientCore
{
    internal class ResourceMetaData
    {
        public string RelativePath { get; set; }
        public string MD5 { get; set; }
        public List<string> Dependencies { get; set; }
    }
}
