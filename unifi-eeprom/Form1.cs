using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unifi_eeprom
{
    public partial class Form1 : Form
    {
        byte[] eeprom;
        UInt16 EEPROMSize;

        String[][] models;

        public Form1()
        {
            models = new String[][] {
                new String[5] {"ffff","ffff","ffff","b102","PowerStation2 (18V)"},
                new String[5] {"ffff","ffff","ffff","b202","PowerStation2 (16D)"},
                new String[5] {"ffff","ffff","ffff","b302","PowerStation2 (EXT)"},
                new String[5] {"ffff","ffff","ffff","b105","PowerStation5 (22V)"},
                new String[5] {"ffff","ffff","ffff","b305","PowerStation5 (EXT)"},
                new String[5] {"ffff","ffff","ffff","c302","PicoStation2"},
                new String[5] {"ffff","ffff","ffff","c3a2","PicoStation2 HP"},
                new String[5] {"ffff","ffff","ffff","a105","WispStation5"},
                new String[5] {"ffff","ffff","ffff","a002","LiteStation2"},
                new String[5] {"ffff","ffff","ffff","a005","LiteStation5"},
                new String[5] {"ffff","ffff","ffff","c002","NanoStation2"},
                new String[5] {"ffff","ffff","ffff","c005","NanoStation5"},
                new String[5] {"ffff","ffff","ffff","c102","NanoStation Loco2"},
                new String[5] {"ffff","ffff","ffff","c105","NanoStation Loco5"},
                new String[5] {"ffff","ffff","ffff","c202","Bullet2"},
                new String[5] {"ffff","ffff","ffff","c205","Bullet5"},
                new String[5] {"168c","001b","0777","3002","XR2"},
                new String[5] {"168c","001b","7777","3002","XR2"},
                new String[5] {"168c","001b","0777","3b02","XR2.3"},
                new String[5] {"168c","001b","0777","3c02","XR2.6"},
                new String[5] {"168c","001b","0777","3b03","XR3-2.8"},
                new String[5] {"168c","001b","0777","3c03","XR3-3.6"},
                new String[5] {"168c","001b","0777","3003","XR3"},
                new String[5] {"168c","001b","0777","3004","XR4"},
                new String[5] {"168c","001b","0777","3005","XR5"},
                new String[5] {"168c","001b","7777","3005","XR5"},
                new String[5] {"168c","001b","0777","3007","XR7"},
                new String[5] {"168c","001b","0777","3009","XR9"},
                new String[5] {"168c","0013","168c","1042","SRC"},
                new String[5] {"168c","0013","0777","2041","SR2"},
                new String[5] {"168c","0013","0777","2004","SR4"},
                new String[5] {"168c","0013","7777","2004","SR4"},
                new String[5] {"168c","0013","0777","1004","SR4C"},
                new String[5] {"168c","0013","7777","1004","SR4C"},
                new String[5] {"168c","0013","168c","2042","SR5"},
                new String[5] {"168c","0013","7777","2009","SR9"},
                new String[5] {"168c","0027","168c","2082","SR71A"},
                new String[5] {"168c","0027","0777","4082","SR71"},
                new String[5] {"168c","0029","0777","4005","SR71-15"},
                new String[5] {"168c","002a","0777","e302","PicoStation M2"},
                new String[5] {"168c","002a","0777","e012","NanoStation M2"},
                new String[5] {"168c","002a","0777","e005","NanoStation M5"},

                new String[5] {"168c","0029","0777","e302","PicoStation M2 PCI-EXPRESS"},
                new String[5] {"168c","0029","0777","e012","NanoStation M2 PCI-EXPRESS"},
                new String[5] {"168c","0029","0777","e005","NanoStation M5 PCI-EXPRESS"},

                new String[5] {"168c","002a","0777","e202","Bullet M2"},
                new String[5] {"168c","002a","0777","e805","Bullet M5"},
                new String[5] {"168c","002a","0777","e345","WispStation M5"}
            };

            InitializeComponent();


            for (int i = 0; i < models.Length; i++)
            {
                cbxModel1.Items.Add(models[i][4]);
                cbxModel2.Items.Add(models[i][4]);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            


            if (result.ToString() == "OK")
            {
                lblFileName.Text = openFileDialog1.FileName;
                Stream stream = openFileDialog1.OpenFile();
                eeprom = new byte[0x10000];
                stream.Seek(0x7F0000, SeekOrigin.Begin);
                stream.Read(eeprom, 0, 0xFFFF);

                UInt16 CRC = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1202));
                tbCRC.Text = CRC.ToString("X4");

                
                
                UInt16 Vendor1 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1008));
                tbVendor1.Text = Vendor1.ToString("X4");

                UInt16 Vendor2 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x101A));
                tbVendor2.Text = Vendor2.ToString("X4");

                UInt16 Device1 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x100A));
                tbDevice1.Text = Device1.ToString("X4");

                UInt16 Device2 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x101C));
                tbDevice2.Text = Device2.ToString("X4");


                UInt16 SubVendor1 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1014));
                tbSubVendor1.Text = SubVendor1.ToString("X4");

                UInt16 SubVendor2 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1026));
                tbSubVendor2.Text = SubVendor2.ToString("X4");

                UInt16 SubDevice1 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1016));
                tbSubDevice1.Text = SubDevice1.ToString("X4");

                UInt16 SubDevice2 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1028));
                tbSubDevice2.Text = SubDevice2.ToString("X4");

                UInt16 Rev1 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x100E));
                tbRev1.Text = Rev1.ToString("X4");

                UInt16 Rev2 = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1020));
                tbRev2.Text = Rev2.ToString("X4");

                for (int i = 0; i < models.Length; i++)
                {
                    if (
                        (tbVendor1.Text.ToLower() == models[i][0]) &&
                        (tbDevice1.Text.ToLower() == models[i][1]) &&
                        (tbSubVendor1.Text.ToLower() == models[i][2]) &&
                        (tbSubDevice1.Text.ToLower() == models[i][3])
                        )
                    {
                        cbxModel1.SelectedIndex = i;
                        break;
                    }
                    
                }

                for (int i = 0; i < models.Length; i++)
                {
                    if (
                        (tbVendor2.Text.ToLower() == models[i][0]) &&
                        (tbDevice2.Text.ToLower() == models[i][1]) &&
                        (tbSubVendor2.Text.ToLower() == models[i][2]) &&
                        (tbSubDevice2.Text.ToLower() == models[i][3])
                        )
                    {
                        cbxModel2.SelectedIndex = i;
                        break;
                    }

                }


                EEPROMSize = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1200));
                tbSize.Text = EEPROMSize.ToString();

                UInt16 Country = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1212));
                tbCountry.Text = Country.ToString("X4");

                UInt16 Antenna = ReverseBytes(BitConverter.ToUInt16(eeprom, 0x1208));
                tbAntenna.Text = Antenna.ToString("X4");

                byte[] mac = new byte[6];
                byte[] mac2 = new byte[6];
                byte[] mac3 = new byte[6];

                



                Array.Copy(eeprom, 0, mac, 0, 6);
                Array.Copy(eeprom, 6, mac2, 0, 6);
                Array.Copy(eeprom, 0x120C, mac3, 0, 6);

                tbLAN1.Text = BytesToHex(mac);
                tbLAN2.Text = BytesToHex(mac2);
                tbWLAN.Text = BytesToHex(mac3);

                UInt32 conterlock = BitConverter.ToUInt32(eeprom, 0x10);
                if (conterlock.ToString("X4") == "FFFFFFFF")
                {
                    cbLock.Checked = false;
                    cbLock.Enabled = false;

                }
                else
                {
                    cbLock.Checked = true;
                    cbLock.Enabled = true;
                }

               

                    stream.Close();
            }
            else
            {
                lblFileName.Text = "Не задан";
            }

        }
        public byte[] Hex2Bytes(string input)
        {
            byte[] data = new byte[(int)Math.Ceiling((double)input.Length / 2)];

            var builder = new StringBuilder();
            for (int i = 0; i < input.Length; i += 2)
            { //throws an exception if not properly formatted
                string hexdec = input.Substring(i, 2);
                data[i / 2] = (byte)Int32.Parse(hexdec, NumberStyles.HexNumber);
            }
            return data;
        }

        public string BytesToHex(byte[] bytes)
        {
            string hex = "";
            foreach (char c in bytes)
            {
                int tmp = c;
                hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }

        public static UInt16 ReverseBytes(UInt16 value)
        {
            return (UInt16)((value & 0xFFU) << 8 | (value & 0xFF00U) >> 8);
        }

        private void btnCRC_Click(object sender, EventArgs e)
        {
            calcCRC();
        }

        private void calcCRC()
        {
            UInt16 crc_calc=0, data=0;
            int i;
            for (i = 0; i < EEPROMSize; i += 2)
            {
                if (2 == i) continue;
                data = BitConverter.ToUInt16(eeprom , 0x1200+i);
                
                crc_calc ^= data;
                //if (!(i & 0xFFC0)) printf(".");
            }

            crc_calc ^= 0xFFFF;

            tbNewCRC.Text = ReverseBytes(crc_calc).ToString("X4");
        }

 
        private void cbxModel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = (sender as ComboBox).SelectedIndex;
            tbVendor1.Text = models[i][0].ToUpper();
            tbDevice1.Text = models[i][1].ToUpper();
            tbSubVendor1.Text = models[i][2].ToUpper();
            tbSubDevice1.Text = models[i][3].ToUpper();
        }

        private void cbxModel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = (sender as ComboBox).SelectedIndex;
            tbVendor2.Text = models[i][0].ToUpper();
            tbDevice2.Text = models[i][1].ToUpper();
            tbSubVendor2.Text = models[i][2].ToUpper();
            tbSubDevice2.Text = models[i][3].ToUpper();
        }
    }
}
