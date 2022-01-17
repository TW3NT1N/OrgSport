using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turAg
{
    public class update
    {
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = DBTurAg.mdb";
        
        public void Update(ref DataGridView dataGridView1, string CmdText)
        {
            OleDbConnection myConnection;
            myConnection = new OleDbConnection(ConnString);
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(CmdText, myConnection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "название");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            myConnection.Close();
        }
        public void Update1(ref DataGridView dataGridView2, string CmdText)
        {
            OleDbConnection myConnection;
            myConnection = new OleDbConnection(ConnString);
            myConnection.Open();
            OleDbCommand command = new OleDbCommand(CmdText, myConnection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "название");
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            myConnection.Close();
        }
    }
}
