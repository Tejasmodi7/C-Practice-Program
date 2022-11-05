using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Test
{

    public partial class Insert : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-MCT3HFK;Initial Catalog=temp;Persist Security Info=True;User ID=sa;Password=shree");

        protected void Page_Load(object sender, EventArgs e)
        {
            
            cn.Open();
            Bind();
           //blank();

          
           

        }


        protected void btnsave_Click(object sender, EventArgs e)
        {

            if (txtno.Text != "" && txtname.Text != "" && txtaddress.Text != "")
            {
                string Ins;
                Ins = "insert into test values ('" + txtno.Text + "' ,'" + txtname.Text + "', '" + txtaddress.Text + "')";
                SqlCommand cmd = new SqlCommand(Ins, cn);
                cmd.ExecuteNonQuery();
                lblmsg.Text = "Data Save Successfully";
                Bind();
                blank();
            }
            else
            {
                lblmsg.Text = "Data Must Be There";
            }

        }

        public void Bind()
        {
            string s;
            s = "select * from test";
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(s, cn);
            adpt.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtno.Text = GridView1.SelectedRow.Cells[1].Text;
            txtname.Text = GridView1.SelectedRow.Cells[2].Text;
            txtaddress.Text = GridView1.SelectedRow.Cells[3].Text;
            txtno.Enabled = false;

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {


            string upd;
            upd = "update test set Name='" + txtname.Text + "',Address ='" + txtaddress.Text + "'where no='" + txtno.Text + "'";
            SqlCommand cmd = new SqlCommand(upd, cn);
            cmd.ExecuteNonQuery();
            lblmsg.Text = "Updated Data Successfully";
            Bind();
            blank();

        }



        protected void btndel_Click1(object sender, EventArgs e)
        {
            string Del;
            Del = "Delete from test where no ='" + txtno.Text + "'";
            SqlCommand cmd = new SqlCommand(Del, cn);
            cmd.ExecuteNonQuery();
            lblmsg.Text = "Deleted Data Successfully";
            Bind();
            blank();

        }
        public void blank()
        {
            txtno.Text = "";
            txtname.Text = "";
            txtaddress.Text = "";
        }


    }
}
