using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VMClass
{
    public class ComboVM
    {

    }

     public class ToolBox
    {
        public string Name;
        public int charges;
        public float rePairRate;
        public ToolboxAddOn[] addons = new ToolboxAddOn[2];
    }

    

    public class ToolboxAddOn : IToolBoxAddon
    {
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

}