using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_SpecFlowProject1.Petshop
{
    public partial class readme: Component
    {    
        public readme()
        {
            InitializeComponent();
        }

        public readme(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
