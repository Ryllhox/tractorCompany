using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace tractorCompany.Utilities
{
    internal class UniqueButton : RadioButton
    {
        static UniqueButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(UniqueButton), new FrameworkPropertyMetadata(typeof(UniqueButton)));
        }
    }
}
