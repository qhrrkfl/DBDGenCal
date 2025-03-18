using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;


namespace DataVMClass
{
    public class ToolboxFac
    {
        public ToolBox[] CreateToolboxes()
        {
            ToolBox[] toolBoxes = new ToolBox[]
            {
                     new ToolBox("없음", 0 , 0f),
                     new ToolBox("기본", 16, 0.5f),
                     new ToolBox("제작된", 32, 0.5f),
                     new ToolBox("기계공", 16, 0.75f),
                     new ToolBox("육중한", 32, 0.75f),
                     new ToolBox("기사의", 16, 1.0f),
            };

            return toolBoxes;
        }

        public ToolboxAddOn[] CrteateToolboxesAddones()
        {
            ToolboxAddOn[] toolboxAddOns = new ToolboxAddOn[]
            {
                new ToolboxAddOn("없음", "효과없음" , null),
                new ToolboxAddOn("a mundane rag","스피드 20%" , (ToolBox b ) =>{ b.CurrentRepairRate += 0.2f; }),
                new ToolboxAddOn("Scraps","차지 +8" , (ToolBox b ) =>{ b.Maxcharges += 8; }),
                new ToolboxAddOn("Socket Swivels","스피드 30%" , (ToolBox b ) =>{ b.CurrentRepairRate += 0.3f; }),
                new ToolboxAddOn("Wire Spool" ,"차지 +_12" , (ToolBox b ) =>{ b.Maxcharges += 12; } )
            };

            return toolboxAddOns;
        }
    }
}
