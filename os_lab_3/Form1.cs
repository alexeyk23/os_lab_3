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
            HeapEntry32[] harr = tool.GetHeapList().ToArray();
            Cursor = Cursors.Default;
            foreach (HeapEntry32 item in harr)
            {
               liviewResult.Items.Add( item.dwFlags.ToString() + " " + item.dwBlockSize.ToString());
            }
        }      

       
    }
}
