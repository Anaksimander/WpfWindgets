using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfWindgets.CustomWidgets
{
    /// <summary>
    /// Виджет заметок.
    /// </summary>
    public partial class NoteWidget : UserControl, IWidget
    {


        /// <summary>
        /// Инициализарует экземпляр класса <see cref="NoteWidget"/>
        /// </summary>
        public NoteWidget()
        {
            InitializeComponent();
        }

        public double BackgroundOpacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
