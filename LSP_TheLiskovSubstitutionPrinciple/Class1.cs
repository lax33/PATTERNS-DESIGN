using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP_TheLiskovSubstitutionPrinciple
{
    public class Class1 : Interface2
    {
        private int field;

        public Class1(int poi)
        {
            field = poi;
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public void Rewq()
        {

        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}