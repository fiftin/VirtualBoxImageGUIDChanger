using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VirtualBoxImageGUIDChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string GuidBytesToString(byte[] bytes)
        {
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                string str = bytes[i].ToString("X2");
                strBuilder.Append(str);
            }
            return strBuilder.ToString();
        }

        private string GetGuidString(string filename)
        {
            byte[] bytes = new byte[16];
            using (FileStream stream = File.OpenRead(filename))
            {
                long newPos = stream.Seek(392, SeekOrigin.Begin);
                int bytesRead = stream.Read(bytes, 0, 16);
            }
            return GuidBytesToString(bytes);
        }

        private byte[] GetGuidBytes(string guid)
        {
            byte[] bytes = new byte[16];
            for (int i = 0; i < guid.Length; i += 2)
            {
                char c1 = guid[i];
                char c2 = guid[i + 1];
                string str = string.Format("{0}{1}", c1, c2);
                bytes[i / 2] = byte.Parse(str, System.Globalization.NumberStyles.HexNumber);
            }
            return bytes;
        }

        private void ChangeGuid(string filename, string guid)
        {
            FileStream stream = File.OpenWrite(filename);
            long newPos = stream.Seek(392, SeekOrigin.Begin);
            byte[] bytes = GetGuidBytes(guid);
            stream.Write(bytes, 0, bytes.Length);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            switch (openFileDialog1.ShowDialog())
            {
                case DialogResult.OK:
                    txtFileName.Text = openFileDialog1.FileName;
                    txtOldGuid.Text = GetGuidString(txtFileName.Text);
                    break;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangeGuid(txtFileName.Text, txtNewGuid.Text);
            txtOldGuid.Text = txtNewGuid.Text;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Guid guid = Guid.NewGuid();
            byte[] bytes = guid.ToByteArray();
            txtNewGuid.Text = GuidBytesToString(bytes);
        }
    }
}
