﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Reflection;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using System;

namespace DataAccess
{
    public class FunctionsSql
    {
        public SqlConnection GetConnectionMsSQL(string Name)
        {
            try
            {
                SqlConnection cn = new SqlConnection(this.GetConnection(Name));

                return cn;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public MySqlConnection GetConnectionMySql(string Name)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(this.GetConnection(Name));

                return cn;
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        private string GetConnection(string Name)
        {

            //string connection = "Data Source=SAEDRMEX01DB60,1437;Initial Catalog=TCRM_TicketCarTotal; Integrated Security=True;";


            string connection = "Data Source=" + ConfigurationManager.AppSettings["DataSource"] +
                                ";Initial Catalog=" + ConfigurationManager.AppSettings["InitialCatalog"] +
                                ";User Id=" + ConfigurationManager.AppSettings["UserId"] +
                                ";Password=" + ConfigurationManager.AppSettings["Password"];

            return connection;
            //return new AppConfig().ConnectionString(Name);
        }
    }
}
