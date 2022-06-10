using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Sample 01: Inlucde required Namespace
using System.Data.SqlClient;

namespace DataRelationExample
{
    public partial class frmDataRelation : Form
    {
        //Sample 02: Declare a DataSet
        private DataSet dsDataRelEx = null;
        private string PubsCon =
            DataRelationExample.Properties.Settings.Default.PubsCon;

        public frmDataRelation()
        {
            InitializeComponent();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            //Sample 03: Create the Dataset
            if (dsDataRelEx == null)
                dsDataRelEx = new DataSet();
            else
                return;

            //Sample 04: Fill Store List DataGrid
            string SqlStr = 
            @"Select stor_id, Stor_Name,
            Stor_Address,City from stores";
            SqlDataAdapter sqlDa = new SqlDataAdapter(
                SqlStr, PubsCon);
            sqlDa.Fill(dsDataRelEx, "Stores");
            sqlDa.Dispose();

            //Sample 05: Fill Sales List DataGrid
            SqlStr =
            @"Select Ord_num, T.title, Qty, 
            stor_id, T.title_id
            from Sales S Inner Join titles T 
            On S.title_id = T.title_id";
            sqlDa = new SqlDataAdapter(
                SqlStr, PubsCon);
            sqlDa.Fill(dsDataRelEx, "Sales");
            sqlDa.Dispose();

            //Sample 06: Fill Authors DataGrid
            SqlStr =
            @"Select T.title_id, T.title,   
            au_lname + ' ' + au_fname 
            as Author, phone, address, 
            city	 
            from Titles T 
            Inner Join titleauthor TA
            On T.title_id = TA.title_id
            Inner Join authors A
            On TA.au_id = A.au_id";
            sqlDa = new SqlDataAdapter(
                SqlStr, PubsCon);
            sqlDa.Fill(dsDataRelEx, "Authors");
            sqlDa.Dispose();

            //Sample 07: Create DataRelation
            //7.1 Stores and Sales
            DataRelation StoreSale = new DataRelation(
                "StoreSales",
                dsDataRelEx.Tables["Stores"].Columns["stor_id"],
                dsDataRelEx.Tables["Sales"].Columns["stor_id"],
                false);
            //7.2 Sales and Authors
            DataRelation StoreSaleTitleAuth = new DataRelation(
                "TitleAuthors",
                dsDataRelEx.Tables["Sales"].Columns["title_id"],
                dsDataRelEx.Tables["Authors"].Columns["title_id"],
                false);
            //7.3 Add These Relationship to DataSet
            dsDataRelEx.Relations.Add(StoreSale);
            dsDataRelEx.Relations.Add(StoreSaleTitleAuth);
            
            //8.0 Now DataSet Tables exists with Relation
            //    Bind the DataSet With Relation. Use DataMember
            //8.1 Bind DataGridView - Stores
            dgStoreList.DataSource = dsDataRelEx;
            dgStoreList.DataMember = "Stores"; //DataTable Name

            //8.2 Bind DataGridView - Sales
            dgStoreSales.DataSource = dsDataRelEx;
            dgStoreSales.DataMember = "Stores.StoreSales";

            //8.3 Bind DataGridView - Authors
            dgTitleAuth.DataSource = dsDataRelEx;
            dgTitleAuth.DataMember = "Stores.StoreSales.TitleAuthors";
        }

        //Sample 00: Exit the application on Close button click
        private void cmdClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}