using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Evensel.EvenselToolkit
{
    public partial class SearchWindow : Form
    {
        public ISearchManager SearchManager { get; set; }
        public SearchWindow(ISearchManager searchManager)
        {
            InitializeComponent();
            this.btnFind.Click += new EventHandler(btnFind_Click);
            this.Load += new EventHandler(SearchWindow_Load);

            this.SearchManager = searchManager;

        }

        void SearchWindow_Load(object sender, EventArgs e)
        {
            LoadKeys();
        }

        private void LoadKeys()
        {
            var keys = SearchManager.GetKeys();
            cmbSearchBy.DataSource = keys;

        }

        void btnFind_Click(object sender, EventArgs e)
        {
            var list = SearchManager.Find(cmbSearchBy.SelectedText, txtFind.Text);
            DataBind(list);
            
        }

        public void DataBind(object databindObj)
        {
            this.dataGridView1.DataSource = databindObj; 
        }

        private void btnFind_Click_1(object sender, EventArgs e)
        {

        }


    }
}
