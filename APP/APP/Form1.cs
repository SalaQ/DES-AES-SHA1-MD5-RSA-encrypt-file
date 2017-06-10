using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace APP
{
    public partial class Form1 : Form
    {
        string ReceiveRsaKey;
        string SendRsaKey;
        public Form1()
        {
            InitializeComponent();
        }

        private void EncChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                EncFile.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] Key;
            byte[] EncryptedKey;
            ReceiveRsaKey = rsa.ToXmlString(true);
            BRsaKey.Text = ReceiveRsaKey;
            rsa.FromXmlString(ReceiveRsaKey);
            Key = Convert.FromBase64String(EncKey.Text);
            EncryptedKey = rsa.Encrypt(Key, false);
            EncRsaKey.Text = Convert.ToBase64String(EncryptedKey);
        }

        private void EncKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void Encrpt_Click(object sender, EventArgs e)
        {
            if(EncAlg.Text == "DES")
            {
                byte[] key = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    key[i] = (byte)EncKey.Text[i];
                }
                string inName = EncFile.Text;
                string outName = string.Concat(EncFile.Text, ".des");

                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                DES des = new DESCryptoServiceProvider();
                CryptoStream encStream = new CryptoStream(fout, des.CreateEncryptor(key, key), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    encStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }

                encStream.Close();
                fout.Close();
                fin.Close();

                MessageBox.Show("DES加密完成");
            }
            else if(EncAlg.Text == "AES")
            {
                byte[] key = new byte[16];
                for (int i = 0; i < 16; i++)
                {
                    key[i] = (byte)EncKey.Text[i];
                }
                string inName = EncFile.Text;
                string outName = string.Concat(EncFile.Text, ".aes");

                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                AesManaged aes = new AesManaged();
                CryptoStream encStream = new CryptoStream(fout, aes.CreateEncryptor(key, key), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    encStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }

                encStream.Close();
                fout.Close();
                fin.Close();

                MessageBox.Show("AES加密完成");
            }
            else
            {
                MessageBox.Show("请选择加密算法");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RsaDecKey_Click(object sender, EventArgs e)
        {
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] Key;
            byte[] EncryptedKey;
            rsa.FromXmlString(ReceiveRsaKey);
            DecRsaKey.Text = EncRsaKey.Text;
            EncryptedKey = Convert.FromBase64String(DecRsaKey.Text);
            Key = rsa.Decrypt(EncryptedKey, false);
            DecKey.Text = Convert.ToBase64String(Key);
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if(DecAlg.Text == "DES")
            {
                byte[] key = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    key[i] = (byte)DecKey.Text[i];
                }
                string inName = DecFile.Text;
                string outName = DecFile.Text.Remove(DecFile.Text.Length - 3);

                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                DES des = new DESCryptoServiceProvider();
                CryptoStream decStream = new CryptoStream(fout, des.CreateDecryptor(key, key), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    decStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }

                decStream.Close();
                fout.Close();
                fin.Close();

                MessageBox.Show("DES解密完成");
            }
            else if(DecAlg.Text == "AES")
            {
                byte[] key = new byte[16];
                for (int i = 0; i < 16; i++)
                {
                    key[i] = (byte)DecKey.Text[i];
                }
                string inName = DecFile.Text;
                string outName = DecFile.Text.Remove(DecFile.Text.Length - 3);

                //Create the file streams to handle the input and output files.
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                FileStream fout = new FileStream(outName, FileMode.OpenOrCreate, FileAccess.Write);
                fout.SetLength(0);

                //Create variables to help with read and write.
                byte[] bin = new byte[100]; //This is intermediate storage for the encryption.
                long rdlen = 0;              //This is the total number of bytes written.
                long totlen = fin.Length;    //This is the total length of the input file.
                int len;                     //This is the number of bytes to be written at a time.

                AesManaged aes = new AesManaged();
                CryptoStream decStream = new CryptoStream(fout, aes.CreateDecryptor(key, key), CryptoStreamMode.Write);

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    decStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }

                decStream.Close();
                fout.Close();
                fin.Close();

                MessageBox.Show("AES解密完成");
            }
            else
            {
                MessageBox.Show("请选择解密算法");
            }
        }

        private void DecChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DecFile.Text = openFileDialog1.FileName;
            }
        }

        private void CalEncHash_Click(object sender, EventArgs e)
        {
            if(HashAlg.Text == "SHA1")
            {
                string inName = EncFile.Text;
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                byte[] HashData;
                byte[] CypherText;
                SHA1 sha = new SHA1CryptoServiceProvider();
                HashData = sha.ComputeHash(fin);
                fin.Close();
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                SendRsaKey = rsa.ToXmlString(true);
                ARsaKey.Text = SendRsaKey;
                rsa.FromXmlString(SendRsaKey);
                CypherText = rsa.Encrypt(HashData, false);
                EncHash.Text = Convert.ToBase64String(HashData);
                EncRsaHash.Text = Convert.ToBase64String(CypherText);
                if(EncAlg.Text == "DES")
                {
                    DES des = new DESCryptoServiceProvider();
                    byte[] key = new byte[8];
                    for (int i = 0; i < 8; i++)
                    {
                        key[i] = (byte)EncKey.Text[i];
                    }
                    byte[] inputByteArray = Convert.FromBase64String(EncRsaHash.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, key), CryptoStreamMode.Write))
                    {
                        cs.Write(inputByteArray, 0, inputByteArray.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                    }
                    EncAlgHash.Text = Convert.ToBase64String(ms.ToArray());
                }
                else if(EncAlg.Text == "AES")
                {
                    AesManaged aes = new AesManaged();
                    byte[] key = new byte[16];
                    for (int i = 0; i < 16; i++)
                    {
                        key[i] = (byte)EncKey.Text[i];
                    }
                    byte[] inputByteArray = Convert.FromBase64String(EncRsaHash.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(key, key), CryptoStreamMode.Write))
                    {
                        cs.Write(inputByteArray, 0, inputByteArray.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                    }
                    EncAlgHash.Text = Convert.ToBase64String(ms.ToArray());
                }
                else
                {
                    MessageBox.Show("请选择加密算法");
                }
            }
            if(HashAlg.Text == "MD5")
            {
                string inName = EncFile.Text;
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                byte[] HashData;
                byte[] CypherText;
                MD5 md5 = new MD5CryptoServiceProvider();
                HashData = md5.ComputeHash(fin);
                fin.Close();
                System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                SendRsaKey = rsa.ToXmlString(true);
                ARsaKey.Text = SendRsaKey;
                rsa.FromXmlString(SendRsaKey);
                CypherText = rsa.Encrypt(HashData, false);
                EncHash.Text = Convert.ToBase64String(HashData);
                EncRsaHash.Text = Convert.ToBase64String(CypherText);
                if (EncAlg.Text == "DES")
                {
                    DES des = new DESCryptoServiceProvider();
                    byte[] key = new byte[8];
                    for (int i = 0; i < 8; i++)
                    {
                        key[i] = (byte)EncKey.Text[i];
                    }
                    byte[] inputByteArray = Convert.FromBase64String(EncRsaHash.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, key), CryptoStreamMode.Write))
                    {
                        cs.Write(inputByteArray, 0, inputByteArray.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                    }
                    EncAlgHash.Text = Convert.ToBase64String(ms.ToArray());
                }
                else if (EncAlg.Text == "AES")
                {
                    AesManaged aes = new AesManaged();
                    byte[] key = new byte[16];
                    for (int i = 0; i < 16; i++)
                    {
                        key[i] = (byte)EncKey.Text[i];
                    }
                    byte[] inputByteArray = Convert.FromBase64String(EncRsaHash.Text);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(key, key), CryptoStreamMode.Write))
                    {
                        cs.Write(inputByteArray, 0, inputByteArray.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                    }
                    EncAlgHash.Text = Convert.ToBase64String(ms.ToArray());
                }
                else
                {
                    MessageBox.Show("请选择加密算法");
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void CalDecHash_Click(object sender, EventArgs e)
        {
            if(DecAlg.Text == "DES")
            {
                DecAlgHash.Text = EncAlgHash.Text;
                DES des = new DESCryptoServiceProvider();
                byte[] key = new byte[8];
                for (int i = 0; i < 8; i++)
                {
                    key[i] = (byte)DecKey.Text[i];
                }
                byte[] inputByteArray = Convert.FromBase64String(DecAlgHash.Text);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, key), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                DecRsaHash.Text = Convert.ToBase64String(ms.ToArray());
            }
            else if(DecAlg.Text == "AES")
            {
                DecAlgHash.Text = EncAlgHash.Text;
                AesManaged aes = new AesManaged();
                byte[] key = new byte[16];
                for (int i = 0; i < 16; i++)
                {
                    key[i] = (byte)DecKey.Text[i];
                }
                byte[] inputByteArray = Convert.FromBase64String(DecAlgHash.Text);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(key, key), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                DecRsaHash.Text = Convert.ToBase64String(ms.ToArray());
            }
            else
            {
                MessageBox.Show("请选择解密算法");
            }

            byte[] PlainTextBArray;
            byte[] DypherTextBArray;
            System.Security.Cryptography.RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(SendRsaKey);
            PlainTextBArray = Convert.FromBase64String(DecRsaHash.Text);
            DypherTextBArray = rsa.Decrypt(PlainTextBArray, false);
            DecHash.Text = Convert.ToBase64String(DypherTextBArray);
        }

        private void DecChooseFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DecFile2.Text = openFileDialog1.FileName;
            }
        }

        private void CalHash_Click(object sender, EventArgs e)
        {
            if (DecHashAlg.Text == "SHA1")
            {
                string inName = DecFile2.Text;
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                byte[] HashData;
                SHA1 sha = new SHA1CryptoServiceProvider();
                HashData = sha.ComputeHash(fin);
                fin.Close();
                EncHash2.Text = Convert.ToBase64String(HashData);
            }
            else if(DecHashAlg.Text == "MD5")
            {
                string inName = DecFile2.Text;
                FileStream fin = new FileStream(inName, FileMode.Open, FileAccess.Read);
                byte[] HashData;
                MD5 md5 = new MD5CryptoServiceProvider();
                HashData = md5.ComputeHash(fin);
                fin.Close();
                EncHash2.Text = Convert.ToBase64String(HashData);
            }
            else
            {
                MessageBox.Show("请选择哈希算法");
            }
        }

        private void CompareHash_Click(object sender, EventArgs e)
        {
            if(EncHash2.Text == DecHash.Text)
            {
                MessageBox.Show("哈希值相同，文件未被修改！");
            }
            else if (EncHash2.Text != DecHash.Text)
            {
                MessageBox.Show("哈希值不同，文件已被修改！");
            }
        }
    }
}
