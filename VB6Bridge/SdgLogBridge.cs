using System;
using Patholab_Common;
using SdgLog;

namespace VB6Bridge
{

    public class SdgLogBridge
    {



   
        public SdgLogBridge(ADODB.Connection con, double sessionId)
        {

            this.con = con;        
            this._sessionId = sessionId;
            
        }

        public SdgLogBridge(string _connectionString, double sessionId)
        {
            // TODO: Complete member initialization
            this._connectionString = _connectionString;
            this.sessionId = sessionId;
        }


        private CreateLog cl;
        private ADODB.Connection con;
        private ADODB.Recordset rs;
        private readonly string _connectionString;
        private readonly double _sessionId;
        private double sessionId;
        public void CreateConnection()
        {
            if (con == null)
            {
                con = new ADODB.Connection();
                con.ConnectionString = _connectionString;
                con.Open();
            }

            rs = new ADODB.Recordset();
            cl = new CreateLog();
            cl.con = con;
            cl.session = (int)_sessionId;


        }

        /// <summary>
        /// Get sdg id  
        /// </summary>
        /// <param name="tableName">Table Name of Entity</param>
        /// <param name="entityId">Entity Id</param>
        public string GetSdgId(string tableName, string entityId)
        {

            try
            {


                ADODB.Recordset sdgIdRs;
                tableName = tableName.ToUpper();
                String sql = "";
                switch (tableName)
                {
                    case "SAMPLE":
                        sql = "SELECT SDG_ID FROM  lims_sys.Sample where sample_id='" + entityId + "'";
                        break;
                    case "ALIQUOT":
                        sql = " SELECT Sample.SDG_ID FROM  lims_sys.Sample where lims_sys. sample.sample_id in(SELECT  lims_sys.aliquot.sample_id FROM  lims_sys.aliquot where  lims_sys.aliquot.aliquot_id='" + entityId + "')";
                        break;
                    case "TEST":
                        sql = "SELECT SDG_ID FROM  lims_sys.Sample where lims_sys.Sample.sample_id in(SELECT lims_sys.aliquot.sample_id FROM  lims_sys.aliquot where aliquot_id in (SELECT lims_sys.test.aliquot_id FROM  lims_sys.test where lims_sys.test.test_id ='" + entityId + "))'";
                        break;
                    default:
                        sql = "";
                        break;
                }
                if (sql != null)
                {
                    sdgIdRs = new ADODB.Recordset();

                    sdgIdRs.Open(sql, _connectionString, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic, -1);

                    if (sdgIdRs.BOF)
                    {

                        var id = rs.Fields["SDG_ID"].Value.ToString();
                        return id;
                    }
                    sdgIdRs.Close();

                }
            }
            catch (Exception e)
            {
                Logger.WriteLogFile(e);
                return null;
            }
            return null;

        }

        public void InsertLog(int sdgId, string AppCode, string description)
        {

            cl.InsertLog(sdgId, AppCode, description);
        }


        public void CloseConnection()
        {

            if (rs != null) rs.Close();
            if (con != null) con.Close();
        }
    }
}