using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace os_lab_3
{
    public partial class Form1 : Form
    {       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            ToolHelp32 tool = new ToolHelp32();
            Cursor = Cursors.WaitCursor;
          //  HeapEntry32[] harr = tool.GetHeapList().ToArray();           
           List<uint> li = tool.getParentProcessID();
           Cursor = Cursors.Default;
           StringBuilder sb = new StringBuilder();
           foreach (uint item in li)
           {
               foreach (ProcessEntry32 proc in tool.GetProcessList())
               {
                   if (proc.th32ProcessID == item)
                   { 
                       sb.Append(proc.ToString());
                       sb.Append("------------------"+Environment.NewLine);
                   }
               }
           }
           txbxRes.Text = sb.ToString();
        }

        private void txbxRes_TextChanged(object sender, EventArgs e)
        {

        }      

       
    }
}
