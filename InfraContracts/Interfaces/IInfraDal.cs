﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace InfraContracts.Interfaces
{
    public interface IInfraDal
    {
        public OracleParameter GetParameter(string paramName, OracleDbType paramType
            , object paramValue);

        public DataSet ExecSpQuery(OracleCommand cmd);
    }
}
