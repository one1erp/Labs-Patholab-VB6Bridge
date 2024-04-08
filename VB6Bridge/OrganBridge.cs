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
using AxOrgan;
using Organ;
using stdole;
using Font = System.Drawing.Font;

namespace VB6Bridge
{
    [ProgId("VB6Bridge.OrganBridge")]
    public partial class OrganBridge : UserControl
    {
        public OrganBridge()
        {
            InitializeComponent();
           

        }
        public event Action<OrganRes> OrganSelected;

        public void setSample(long sample_id)
        {
            try
            {
                //9278300

                var s = sample_id.ToString();
                axOrganCtrl1.set_SampleId(ref s);
                axOrganCtrl1.Initialize();


            }
            catch (Exception ex)
            {

                //    throw;
            }
        }
        public void RefreshInitialize()
        {

            axOrganCtrl1.Initialize();

        }
        public void InitilaizeCtrl(Connection connection, string opratorName, double sid)
        {

            axOrganCtrl1.set_Connection(ref connection);
            axOrganCtrl1.set_OperatorName(ref opratorName);
            axOrganCtrl1.set_SessionId(ref sid);
            Font font = Font;
            axOrganCtrl1.set_Font(ref font);
            axOrganCtrl1.Visible = true;

        }
        private void axOrganCtrl2_ClickEvent(object sender, EventArgs e)
        {
            OrganRes orgRes = new OrganRes(axOrganCtrl1);
            if (OrganSelected != null)

                OrganSelected(orgRes);



        }

        private void OrganBridge_Leave(object sender, EventArgs e)
        {
           
        }

        private void axOrganCtrl1_Leave(object sender, EventArgs e)
        {
            axOrganCtrl1 = null;
        }

   
    }
    public class OrganRes
    {
        private AxOrganCtrl axOrganCtrl2;


        public OrganRes(AxOrganCtrl axOrganCtrl2)
        {
            // TODO: Complete member initialization
            this.axOrganCtrl2 = axOrganCtrl2;
        }


        public string Organ { get { return axOrganCtrl2.Organ; } }//"חלל הבטן"	 



        public string OrganCode { get { return axOrganCtrl2.OrganCode; } }//"T0124"	
        public string ProcedureCode { get { return axOrganCtrl2.ProcedureCode; } }//"20"	
        public string ProcedureName { get { return axOrganCtrl2.ProcedureName; } }//"Excision"	
        public string Remark { get { return axOrganCtrl2.Remark; } }//"888"
        public string Side { get { return axOrganCtrl2.Side; } }//"N/A"	
        public string SnomedT { get { return axOrganCtrl2.SnomedT; } }//"y4500"
        public string status { get { return axOrganCtrl2.status; } }//"C+"
        public string Topography { get { return axOrganCtrl2.Topography; } }//"N/A 888"	
        public string TopographyCode { get { return axOrganCtrl2.TopographyCode; } }//"LAB003"	
        public string strProcedure
        {
            get
            {
                if (string.IsNullOrEmpty(axOrganCtrl2.ProcedureCode))
                {
                    return axOrganCtrl2.ProcedureCode;
                }
                else
                {
                    return axOrganCtrl2.ProcedureCode + " - " + axOrganCtrl2.ProcedureName;
                }





            }
        }
        public string strSide
        {
            get
            {
                switch (axOrganCtrl2.Side)
                {
                    case "ימין":
                        return "R";

                    case "שמאל":
                        return "L";

                    default:
                        return "";

                }
            }
        }





    }

}
