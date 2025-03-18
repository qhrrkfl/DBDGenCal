using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataVMClass.Player
{
    /// <summary>
    /// Model과 View를 분리해야 할 이유가 없으므로 합치겠음.
    /// </summary>
    public class PlayerVM : INotifyPropertyChanged
    {
        public PlayerVM() { }
        private ToolBox mToolbox;
        public void SetToolbox(ToolBox b)
        {
            mToolbox = b;
            
           refreshToolboxData();
        }

        public void refreshToolboxData()
        {
            OnPropertyChanged("TOOLBOXNAME");
            OnPropertyChanged("TOOLBOXCHARGE");
            OnPropertyChanged("TOOLBOXSPEED");
        }


        public string mPlayerName;
        public string NAME
        {
            get { return mPlayerName; }
            set
            {
                mPlayerName = value;
                OnPropertyChanged("NAME");
            }
        }
        public string TOOLBOXNAME
        {
            get { return mToolbox.Name; }
        }

        public int TOOLBOXCHARGE
        {
            get { return mToolbox.Maxcharges; }
        }

        public float TOOLBOXSPEED
        {
            get { return mToolbox.CurrentRepairRate; }
        }

        public string ADDON1NAME
        { 
            get { return mToolbox.addons1.name; } 
        }
        public string ADDON1DETAIL
        {
            get { return mToolbox.addons1.EffectDetail; }
        }
        
        public string ADDON2NAME
        {
            get { return mToolbox.addons2.name; }
        }
        public string ADDON2DETAIL
        {
            get { return mToolbox.addons2.EffectDetail; }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
