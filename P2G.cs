using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2G_Crawler
{
    public partial class mainForm : Form
    {
        CrawlingSettings cs = null;
        bool isPaused = false;
        int count = 0;
        public mainForm()
        {
            InitializeComponent();
            cs = new CrawlingSettings();
        }
        // Crawling Settings


        private void btnBrowseInputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "input.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblLoadedfile.Text = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(openFileDialog1.FileName);

                string line = sr.ReadLine();

                while (line != null)
                {
                    string[] parts = line.Split(',');

                    gridViewInputFile.Rows.Add(parts);

                    line = sr.ReadLine();
                }

                progressBar.Maximum = gridViewInputFile.Rows.Count;
            }
        }


        private void RuntoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitResultGridView();


            foreach (DataGridViewRow dr in gridViewInputFile.Rows)
            {
                // if there is no reg num or url
                if (dr.Cells[1].Value == null || dr.Cells[2].Value == null) continue;

                // Get tje RegNum and Url for that charity
                string RegNum = dr.Cells[1].Value.ToString();
                string Url = dr.Cells[2].Value.ToString();

                // get a list of string, regnum, url and data strings
                Dictionary<string, string> Results = CrawlingManager.Crawl(RegNum, Url, cs);
                count++;
                // If the returned results are empty, insert invalid row in the grid view
                if (Results == null) AddInvalidRow(dr);
                else AddValidRow(dr, Results);

                
                progressBar.Value++;

            }
        }

        private void AddValidRow(DataGridViewRow dr, Dictionary<string, string> results)
        {
            if (results.Count == 0) return;

            // Prepare the new row
            DataGridViewRow dgvr = new DataGridViewRow();
            dgvr.CreateCells(gridViewResults);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Black;
            dgvr.Cells[3].Style = style;

            // Based on the Crawling Settings, add the new data to the result grid view
            switch (cs.CrawlItemType)
            {
                case "Social Media":
                    dgvr.SetValues(new object[] {count, dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["facebook"], results["linkedin"], results["twitter"], results["youtube"] });
                    SaveToDB(count, dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["facebook"], results["linkedin"], results["twitter"], results["youtube"]);
                    break;
                case "Contact Info":
                    dgvr.SetValues(new object[] {count, dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["email"], results["phone"], results["fax"] });

                    break;

            }
            gridViewResults.Rows.Add(dgvr);
        }

        private void SaveToDB(int count, object p1, object p2, string p3, string p4, string p5, string p6, string p7)
        {
            SqlConnection conn = new SqlConnection(Settings.ConnectionString);

        }
        private void AddInvalidRow(DataGridViewRow dr)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            style.ForeColor = Color.Black;

            DataGridViewRow dgvr = new DataGridViewRow();
            dgvr.CreateCells(gridViewResults);
            dgvr.SetValues(new object[] {count, dr.Cells[1].Value, dr.Cells[2].Value, "Invalid" });
            dgvr.Cells[3].Style = style;
            gridViewResults.Rows.Add(dgvr);
        }
        private void InitResultGridView()
        {
            DataGridViewTextBoxColumn RowColumn = new DataGridViewTextBoxColumn();
            RowColumn.HeaderText = "Row Number";
            DataGridViewTextBoxColumn RegNumColumn = new DataGridViewTextBoxColumn();
            RegNumColumn.HeaderText = "Registration Number";
            DataGridViewTextBoxColumn WebSiteColumn = new DataGridViewTextBoxColumn();
            WebSiteColumn.HeaderText = "Website";
            DataGridViewTextBoxColumn ValidColumn = new DataGridViewTextBoxColumn();
            ValidColumn.HeaderText = "IsValid";
            DataGridViewTextBoxColumn FacebookColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn YouTubeColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn TwitterColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn LinkedinColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn EmailColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn PhoneColumn = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn FaxColumn = new DataGridViewTextBoxColumn();

            gridViewResults.Columns.Clear();

            switch (cs.CrawlItemType)
            {

                case "Social Media":

                    FacebookColumn.HeaderText = "Facebook Link";
                    YouTubeColumn.HeaderText = "YouTube Link";
                    TwitterColumn.HeaderText = "Twitter Link";
                    LinkedinColumn.HeaderText = "Linkedin Link";
                    gridViewResults.Columns.AddRange(new DataGridViewTextBoxColumn[] { RowColumn,RegNumColumn, WebSiteColumn, ValidColumn, FacebookColumn, LinkedinColumn, TwitterColumn, YouTubeColumn });
                    Application.DoEvents();
                    break;
                case "Contact Info":

                    EmailColumn.HeaderText = "Email";
                   PhoneColumn.HeaderText = "Phone";
                   FaxColumn.HeaderText = "Fax";
                   gridViewResults.Columns.AddRange(new DataGridViewTextBoxColumn[] { RowColumn,RegNumColumn, WebSiteColumn, ValidColumn, EmailColumn, PhoneColumn, FaxColumn });
                    Application.DoEvents();
                    break;
            }
        }
        private void comBoxCrawlWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs.CrawlItemType = comBoxCrawlWhat.SelectedItem.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ExportsaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (gridViewResults.Columns.Count == 0)
                {
                    MessageBox.Show("No Data To Save");
                    return;
                } 
                if (gridViewResults.Rows.Count == 0)
                {
                    MessageBox.Show("No Data To Save");
                    return;
                }

                StringBuilder sb = new StringBuilder();
                foreach (DataGridViewRow r in gridViewResults.Rows)
                {
                    for (int i = 0; i < gridViewResults.Columns.Count;i++ )
                        sb.Append(r.Cells[i].Value + ",");

                    sb.Append(Console.Out.NewLine);

                    
                }

                StreamWriter sw = new StreamWriter(ExportsaveFileDialog.FileName+".csv");
                sw.WriteLine(sb.ToString());
                sw.Close();
                MessageBox.Show("The file " + ExportsaveFileDialog.FileName + " is saved");
            }
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPaused = true;
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataBaseForm dbf = new DataBaseForm();
            dbf.ShowDialog();
        }

     
        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseForm dbf = new DataBaseForm();
                if (dbf.ShowDialog() == DialogResult.Cancel)
                {
                    for (int i = 0; i < Settings.InputData.Count; i++)
                    {
                        string[] parts = new string[] { i.ToString(),Settings.InputData.Keys.ElementAt(i), Settings.InputData.Values.ElementAt(i) };

                        gridViewInputFile.Rows.Add(parts);
                    }

                    progressBar.Maximum = gridViewInputFile.Rows.Count;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
