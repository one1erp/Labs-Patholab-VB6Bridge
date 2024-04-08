using System.Diagnostics;
using System.Windows.Forms;
using MacabiShared;

namespace VB6Bridge
{

    public class FindPhysicianBridge
    {
        public string SupplierID { get; set; }
        public string ID { get; set; }
        public string DESCRIPTION { get; set; }



        public FindPhysicianBridge(string _connectionString, double sessionId)
        {
            this._connectionString = _connectionString;
            this._sessionId = sessionId;
        }

        public FindPhysicianBridge(ADODB.Connection con, int sessionId)
        {

            this.con = con;
            //TODO:Check if connection is closed throw exception
            this._sessionId = sessionId;

        }

        private ADODB.Connection con;
        private ADODB.Recordset rs;
        private readonly string _connectionString;
        private readonly double _sessionId;

        public void CreateConnection()
        {
            if (con == null||con.State==0)
            {
                con = new ADODB.Connection();
                con.ConnectionString = _connectionString;
                con.Open();
            }
            rs = new ADODB.Recordset();
             fd = new FindPhysicianDlg();
            fd.Con = con;
        }

        private FindPhysicianDlg fd;

        public void OpenForm()
        {

        //    Debugger.Launch();
            fd.ShowDlg();
            this.SupplierID = fd.SupplierID;
            this.ID = fd.ID;
            this.DESCRIPTION = fd.DESCRIPTION;


        }


        public void CloseConnection()
        {

            if (rs != null) rs.Close();
            if (con != null) con.Close();
        }
    }



}