using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfWindgets.CustomWidgets
{
    /// <summary>
    /// Интерфес виджетов.
    /// </summary>
    internal interface IWidget
    {
        /// <summary>
        /// Прозрачность панели.
        /// </summary>
        public double BackgroundOpacity { get; set; }
    }
}
