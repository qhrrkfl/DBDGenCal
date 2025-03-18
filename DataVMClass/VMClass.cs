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
        public ToolBox(string Name, int Maxcharges, float rePairRate)
        {
            this.Name = Name;
            this.Maxcharges = Maxcharges;
            this.repairRate = rePairRate;
        }
        public string Name;
        
        public int Maxcharges;
        public int CurrentCharges;
        public float repairRate;
        public float CurrentRepairRate;

        public ToolboxAddOn addons1;
        public ToolboxAddOn addons2;
    }



    public class ToolboxAddOn : IToolBoxAddon
    {
        public ToolboxAddOn(string Name, string EffectDetail, Action<ToolBox> action)
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
   


   
}