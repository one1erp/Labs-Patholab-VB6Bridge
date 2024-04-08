using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ADODB;

namespace VB6Bridge
{
    [ProgId("VB6Bridge.RequestRemarksBridge")]

    public partial class RequestRemarksBridge : UserControl
    {
        public RequestRemarksBridge()
        {
            InitializeComponent();


        }

        public event Action StatusChanged;
        public void InitilaizeCtrl(Connection connection, string opratorID)
        {
            axRequestRemarkCtrl1.InitializeConnection(ref connection);
            axRequestRemarkCtrl1.GetOperatorID(ref opratorID);
            axRequestRemarkCtrl1.Visible = false;
            axRequestRemarkCtrl1.Font = this.Font;
            axRequestRemarkCtrl1.StatusChanged += axRequestRemarkCtrl1_StatusChanged;


        }

        void axRequestRemarkCtrl1_StatusChanged(object sender, AxRequestRemark.__RequestRemarkCtrl_StatusChangedEvent e)
        {
            if (StatusChanged != null) StatusChanged();
        }


        public void Reset()
        {
            if (axRequestRemarkCtrl1 != null) axRequestRemarkCtrl1.Visible = false;
        }

        public void sampleInput(string EXTERNAL_REFERENCE)
        {
            axRequestRemarkCtrl1.Visible = true;
            axRequestRemarkCtrl1.GetsdgName(ref EXTERNAL_REFERENCE);
            axRequestRemarkCtrl1.Refresh();
        }

        public string GetRequestStatus(string sdgName)
        {
            var st = axRequestRemarkCtrl1.GetRemarkStatus(ref sdgName);
            return st.ToString();
        }
        private void RequestRemarksBridge_Leave(object sender, EventArgs e)
        {
            //       if (axRequestRemarkCtrl1 != null) Marshal.ReleaseComObject(axRequestRemarkCtrl1);
        }
    }
}