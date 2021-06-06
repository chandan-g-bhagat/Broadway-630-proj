using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Broadway.DesktopApp.Data
{
    public class DatabaseContext //base class
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public SqlConnection con { get; set; }

        public DataTable Table { get; set; }
        public DataRow Row { get; set; }
        public string Query { get; set; }

        public DatabaseContext()
        {
            con = new SqlConnection(connectionString);
        }

        //select query
        public virtual void GetAll()
        {
            try
            {
                var adapt = new SqlDataAdapter(this.Query, this.con);
                var dataset = new DataSet();

                adapt.Fill(dataset);
                this.Table = dataset.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Create()
        {
            ExecutenonQuery();
        }

        public virtual void Update()
        {
            ExecutenonQuery();
        }

        public virtual void Delete()
        {
            ExecutenonQuery();
        }
        
        private void ExecutenonQuery()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(this.Query, this.con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class Student_Model : DatabaseContext
    {
        public int Id { get; set; }
       public string Name { get; set; }


        public override void GetAll()
        {
            this.Query = "select * from Student"; 
            base.GetAll();
        }

        public override void Create()
        {
            this.Query = $"Insert into student (Student) values ('{this.Name}')";
            base.Create();
        }

        public override void Update()
        {
            this.Query = $"update Student set Student='{this.Name}' where id='{this.Id}'";

            base.Update();
        }

        public override void Delete()
        {
            this.Query = $"Delete from Student where id='{this.Id}'";
            base.Delete();
        }
    }

    public class Parent_Model :DatabaseContext
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public override void GetAll()
        {
            this.Query = "Select * from Parent";
            base.GetAll();
        }


        public override void Create()
        {
            this.Query = $"insert into Parent (Name, Type) values ('{this.Name}','{this.Type}')";
            base.Create();
        }
    }

    public class Menu_Model : DatabaseContext
    {
        public override void GetAll()
        {
            this.Query = "Select * from Menu";
            base.GetAll();
        }
    }

    public static class StoredProcedureCalls
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static DataSet CreateMenu(string MenuName, int? Id)
        {
            DataSet ds = null;
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                var query = "SP_Menu_create";
                SqlCommand cmd = new SqlCommand(query, con);
                
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("name_param", SqlDbType.NVarChar).Value = MenuName;
                cmd.Parameters.Add("id_param", SqlDbType.Int).Value = Id;

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapt.Fill(ds);

                //con.Open();
                //cmd.ExecuteNonQuery();
                //con.Close();


            }
            catch (Exception ex)
            {

                throw ex;
            }

            return ds;
        }
    }
}
