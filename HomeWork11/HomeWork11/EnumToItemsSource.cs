using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace HomeWork11
{
    public class EnumToItemsSource : MarkupExtension
    {
        public Type EnumType { get; set; }

        public EnumToItemsSource(Type type)
        {
            EnumType = type;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}
