using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.DesktopApp.Data
{
    

    public class BaseModel
    {
        protected string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        protected SqlConnection sqlCon { get; set; }
        
        protected DataTable _table { get; set; }
        public DataTable Table { get { return _table; } }

        protected string Query { get; set; }

        protected DataSet _dataSet { get; set; } = new DataSet();
        public DataSet DataSet { get { return _dataSet; } }
        public BaseModel()
        {
            sqlCon = new SqlConnection(connectionString);
        }

        protected void ExecuteQuery()
        {
            try
            {
                SqlDataAdapter adapt = new SqlDataAdapter(this.Query, this.sqlCon);
             
                adapt.Fill(_dataSet);

                _table = _dataSet.Tables[0];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void Insert()
        {
            try
            {
                var cmd = new SqlCommand(this.Query, this.sqlCon);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       
        public virtual void GetAll()
        {

        }

    }

    public class StudentModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override void GetAll()
        {
            this.Query = "Select Id, Student from Student";
            base.ExecuteQuery();

        }

        public override void Insert()
        {
            this.Query = "Insert into student (Student) values ('" + this.Name + "')";
            base.Insert();
        }
    }

    public class ParentModel : BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }

        public override void GetAll()
        {
            this.Query = "Select Id, Name, Type from Parent";
            base.ExecuteQuery();

        }
        public override void Insert()
        {
            this.Query = "Insert into Parent (Name, Type) values ('" + this.Name + "','"+this.Type+"')";
            base.Insert();
        }
    }


    public class MenuModel : BaseModel
    {
        public override void GetAll()
        {
            this.Query = "Select * from Menu";
            base.ExecuteQuery();
        }
    }
    
}
