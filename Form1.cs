using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compression_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int L1, L2;
                var bytes = System.IO.File.ReadAllBytes(ofd.FileName);

                L1 = bytes.Length;
                L2 = bytes.Length;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Zip File|*.zip";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, bytes);
                    report.Text = string.Format("Report: Input File is {0} Bytes and Compressed file is {1} bytes", L1, L2);

                }

            }
        }

        private void Decompress_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Zip File|*.zip";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                int L1, L2;
                var bytes = System.IO.File.ReadAllBytes(opf.FileName);

                L1 = bytes.Length;
                L2 = bytes.Length;

                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, bytes);
                    report.Text = string.Format("Report: Input File is {0} Bytes and Decompressed file is {1} bytes", L1, L2);
                }
            }
        }

    }
}
