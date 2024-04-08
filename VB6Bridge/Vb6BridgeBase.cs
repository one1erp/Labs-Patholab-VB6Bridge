using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VB6Bridge
{
    class Vb6BridgeBase
    {
        protected ADODB.Connection con;
        protected readonly string _connectionString;
        protected readonly double _sessionId;
        public Vb6BridgeBase(string _connectionString, double sessionId)
        {
            this._connectionString = _connectionString;
            this._sessionId = sessionId;
        }
        public Vb6BridgeBase(ADODB.Connection con, double sessionId)
        {
            this.con = con;
            //TODO:Check if connection is closed throw exception
            this._sessionId = sessionId;
        }
    }
}
