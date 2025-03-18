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
using DataVMClass.Player;

namespace WpfControlLibrary1
{
    /// <summary>
    /// SurvivorStatusWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SurvivorStatusWindow : UserControl
    {
        public SurvivorStatusWindow()
        {
            InitializeComponent();
        }

        public void SetSelectedPlayer(PlayerVM VM)
        {
            this.DataContext = VM;
        }


    }
}
