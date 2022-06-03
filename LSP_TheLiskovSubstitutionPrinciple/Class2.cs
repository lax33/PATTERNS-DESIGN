using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP_TheLiskovSubstitutionPrinciple
{
    public class Class2 : Interface1
    {
        private int field;

        public int Property
        {
            get => default;
            set
            {
            }
        }

        public void Method()
        {
            throw new System.NotImplementedException();
        }
    }
}