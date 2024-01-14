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

        /// <summary>
        /// Compress 버튼 클릭 시 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Compress_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            // 사용자가 파일을 선택
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int L1, L2;
                var bytes = System.IO.File.ReadAllBytes(ofd.FileName); // 선택한 파일을 바이트 배열로 읽어옴

                L1 = bytes.Length; // 원본 파일 크기
                L2 = bytes.Length; // 압축 후 파일 크기

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Zip File|*.zip"; // 파일 형식 .zip

                // 사용자가 파일을 저장할 위치
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, bytes); // 선택한 위치에 파일을 저장
                    report.Text = string.Format("Report: Input File is {0} Bytes and Compressed file is {1} bytes", L1, L2);
                }
            }
        }

        /// <summary>
        /// Decompress 버튼 클릭 시 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decompress_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Zip File|*.zip"; // 파일 형식 .zip

            // 사용자가 파일을 선택
            if (opf.ShowDialog() == DialogResult.OK)
            {
                int L1, L2;
                var bytes = System.IO.File.ReadAllBytes(opf.FileName); // 선택한 파일을 바이트 배열로 읽어옴

                L1 = bytes.Length; // 원본 파일 크기
                L2 = bytes.Length; // 해제 후 파일 크기 (현재는 압축 해제 기능이 없어서 동일)

                SaveFileDialog sfd = new SaveFileDialog();
                // 사용자가 파일을 저장할 위치
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllBytes(sfd.FileName, bytes); // 선택한 위치에 파일을 저장
                    report.Text = string.Format("Report: Input File is {0} Bytes and Decompressed file is {1} bytes", L1, L2);
                }
            }
        }
    }
}
