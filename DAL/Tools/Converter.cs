using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DAL.Tools
{
    public static class Converter
    {
        public static User Convert(IDataReader reader)
        {
            return new User
            {
                Id = (int)reader["Id"],

            };
        }
    }
}
