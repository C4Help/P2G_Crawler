using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                // If the returned results are empty, insert invalid row in the grid view
                if (Results == null) AddInvalidRaw(dr);
                else AddValidRow(dr, Results);

            }
        }

        private void AddValidRow(DataGridViewRow dr, Dictionary<string, string> results)
        {
            DataGridViewRow dgvr = new DataGridViewRow();
            dgvr.CreateCells(gridViewResults);
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.LightGreen;
            style.ForeColor = Color.Black;
            dgvr.Cells[2].Style = style;

            switch (cs.CrawlItemType)
            {
                case "Social Media":
                    dgvr.SetValues(new object[] { dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["facebook"], results["linkedin"], results["twitter"], results["youtube"] });
                    break;
                case "Facebook":
                    dgvr.SetValues(new object[] { dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["facebook"] });

                    break;
                case "Twitter":
                    dgvr.SetValues(new object[] { dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["twitter"] });

                    break;
                case "YouTube":
                    dgvr.SetValues(new object[] { dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["youtube"] });

                    break;
                case "Linkedin":
                    dgvr.SetValues(new object[] { dr.Cells[1].Value, dr.Cells[2].Value, "Valid", results["linkedin"] });

                    break;

            }
            gridViewResults.Rows.Add(dgvr);
        }
        private void AddInvalidRaw(DataGridViewRow dr)
        {
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Red;
            style.ForeColor = Color.Black;

            DataGridViewRow dgvr = new DataGridViewRow();
            dgvr.CreateCells(gridViewResults);
            dgvr.SetValues(new object[] { dr.Cells[1].Value, dr.Cells[2].Value, "Invalid" });
            dgvr.Cells[2].Style = style;
            gridViewResults.Rows.Add(dgvr);
        }
        private void InitResultGridView()
        {
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

            gridViewResults.Columns.Clear();

            switch (cs.CrawlItemType)
            {

                case "Social Media":

                    FacebookColumn.HeaderText = "Facebook Link";
                    YouTubeColumn.HeaderText = "YouTube Link";
                    TwitterColumn.HeaderText = "Twitter Link";
                    LinkedinColumn.HeaderText = "Linkedin Link";
                    gridViewResults.Columns.AddRange(new DataGridViewTextBoxColumn[] { RegNumColumn, WebSiteColumn, ValidColumn, FacebookColumn, LinkedinColumn, TwitterColumn, YouTubeColumn });
                    Application.DoEvents();
                    break;
                case "Facebook":
                    FacebookColumn.HeaderText = "Facebook Link";
                    gridViewResults.Columns.AddRange(new DataGridViewTextBoxColumn[] { RegNumColumn, WebSiteColumn, ValidColumn, FacebookColumn });
                    Application.DoEvents();
                    break;
                case "Twitter":
                    TwitterColumn.HeaderText = "Twitter Link";
                    gridViewResults.Columns.AddRange(new DataGridViewTextBoxColumn[] { RegNumColumn, WebSiteColumn, ValidColumn, TwitterColumn });
                    Application.DoEvents();
                    break;
                case "YouTube":
                    YouTubeColumn.HeaderText = "YouTube Link";
                    gridViewResults.Columns.AddRange(new DataGridViewTextBoxColumn[] { RegNumColumn, WebSiteColumn, ValidColumn, YouTubeColumn });
                    Application.DoEvents();
                    break;
                case "Linkedin":
                    LinkedinColumn.HeaderText = "Linkedin Link";
                    gridViewResults.Columns.AddRange(new DataGridViewTextBoxColumn[] { RegNumColumn, WebSiteColumn, ValidColumn, LinkedinColumn });
                    Application.DoEvents();
                    break;
            }
        }
        private void comBoxCrawlWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs.CrawlItemType = comBoxCrawlWhat.SelectedItem.ToString();
        }
    }
}
