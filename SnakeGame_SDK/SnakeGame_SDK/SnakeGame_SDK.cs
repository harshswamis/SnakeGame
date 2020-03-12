using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Snake;
using System.Windows.Forms;

namespace SnakeGame_SDK
{
    public class SnakeGame_SDK : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public SnakeGame_SDK()
        {
            
        }

        protected override void OnClick()
        {
            
            Window new1 = new Window();
            new1.ShowDialog();
            
            ArcMap.Application.CurrentTool = null;
        }
        protected override void OnUpdate()
        {
            Enabled = ArcMap.Application != null;
        }
    }

}
