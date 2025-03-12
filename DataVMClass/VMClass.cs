using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DataVMClass
{
    

    public class ToolBox
    {
        public ToolBox( string Name , int charges , float rePairRate) 
        {
            this.Name = Name;
            this.charges = charges;
            this.repairRate = rePairRate;
        }
        public string Name;
        public int charges;
        public float repairRate;
        ToolboxAddOn[] addons = new ToolboxAddOn[2];
    }



    public class ToolboxAddOn : IToolBoxAddon
    {
        public ToolboxAddOn(string Name , string EffectDetail , Action<ToolBox> action)
        {

        }
        public string name;
        public string EffectDetail;
        public Action<ToolBox> mApply;

        public void applyAddon(ToolBox target)
        {
            mApply.Invoke(target);
        }
    }

    public interface IToolBoxAddon
    {
        void applyAddon(ToolBox target);
    }
    public class Player
    {
        public ToolBox Item;
    }


    public class PlayerVM : INotifyPropertyChanged
    {
        public PlayerVM() { }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}