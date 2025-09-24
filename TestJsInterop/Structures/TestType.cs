using Microsoft.JavaScript.NodeApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TestJsInterop.Structures
{
    [JSExport]
    public class TestType
    {
        public int Test { get; set; }
        public TestType Test2 { get; set; }

        public Vector2 Vector { get; set; }
    }
}
