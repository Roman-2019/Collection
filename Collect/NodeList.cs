﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collect
{
    public class Node
    {
        public Node(Notebook element)////, Node nextElement = null)
        {
            Element = element;
            //NextElement = nextElement;
        }

        public Notebook Element { get; set; }
        public Node NextElement { get; set; }
    }
}
