using System;
using System.Collections.Generic;

namespace ToolBox
{
    public class Command
    {
        public string Query { get; set; }
        public bool IsStoredProcedure { get; set; }
        public Dictionary<string, object> Parameters { get; set; }

        public Command(string query, bool isStoredProcedure = false)
        {
            Query = query;
            IsStoredProcedure = isStoredProcedure;
            Parameters = new Dictionary<string, object>();
        }

        public void AddParameter(string parameterName, object value)
        {
            Parameters.Add(parameterName, value ?? DBNull.Value);
        }
    }
}