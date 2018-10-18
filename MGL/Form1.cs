using EasyModbus;
using ModbusTCP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MGL
{
    public partial class Form1 : Form
    {
        //ModbusClient modbusClient;
        ArrayList DataList;
        byte[] data;
        string unit,year,month,day,hr,mins,secs,value;
        private ModbusTCP.Master MBmaster;
        Int32 addr,count;
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void bttn_ReadXML_Click(object sender, EventArgs e)
        {
            ConnectToServer();
            string DateTime;
            count = 0;
            //string URLString = "http://+"+txt_IPAddress.Text+"+/datagate/api/accountapi.ashx?username="+txt_UserName.Text+"&password="+txt_Password.Text+"&software=DataGate2Admin&format=XML&beginDate=10/10/2018&endDate=15/10/2018";
            string URLString = "http://103.11.117.219/Datagate/api/MessagingAPI.ashx?format=XML&username=admin&password=Admin@123&software=DataGate2Admin&number=919726419628&beginDate=10/10/18&endDate=11/10/18";
            //string URLString = "http://122.179.137.69/datagate/api/MessagingAPI.ashx?format=XML&username=pcmc&password=pcmc&software=DataGate2Admin&number=917447797235&beginDate=10/10/2018&endDate=15/10/2018";
            var httpRequest = (HttpWebRequest)WebRequest.Create(URLString);

            //geting the response from the request url
            var response = (HttpWebResponse)httpRequest.GetResponse();

            //create a stream to hold the contents of the response (in this case it is the contents of the XML file
            var receiveStream = response.GetResponseStream();

            //creating XML document
            var mySourceDoc = new XmlDocument();
            //load the file from the stream
            mySourceDoc.Load(receiveStream);
            //close the stream
            receiveStream.Close();

            if (rd_WaterLogger.Checked == true)
            {
                XmlNodeList rankList = mySourceDoc.SelectNodes("/messages/message/message");
                foreach (XmlNode myRankNode in rankList)
                {
                    //if (myRankNode.Attributes["ch"].Value.ToString() == "1") // Physics can be any other variable
                    //{
                    //    DateTime = myRankNode.InnerText;
                    //}

                    for (int i = 0; i < myRankNode.ChildNodes.Count; i++)
                    {
                        DataList = new ArrayList();
                        if (myRankNode.ChildNodes[i].Name == "pt")
                        {
                            Int32 addr = 0;
                            if (count != 0) { addr = count * 10; } else { count = 0; addr = count; }
                            DateTime = myRankNode.ChildNodes[i].InnerText;
                            string chk = DateTime[0].ToString();
                            if (chk == "1")
                            {
                                string text;
                                unit = "1";
                                year = DateTime.Substring(16, 4);
                                month = DateTime.Substring(21, 2);
                                day = DateTime.Substring(24, 2);
                                hr = DateTime.Substring(27, 2);
                                mins = DateTime.Substring(30, 2);
                                secs = DateTime.Substring(33, 2);
                                if (DateTime.Length == 35)
                                { text = DateTime.Substring(35, 1); }
                                else
                                { text = DateTime.Substring(35, DateTime.Length - 35); }
                                decimal dec = Convert.ToDecimal(text) * 100;
                                dec = Math.Round(dec, 2);
                                value = (Convert.ToInt32(dec)).ToString();
                                DataList.Add(unit);
                                DataList.Add(year);
                                DataList.Add(month); DataList.Add(day);
                                DataList.Add(hr); DataList.Add(mins);
                                DataList.Add(secs); DataList.Add(value);
                            }
                            else if (chk == "2")
                            {
                                string text;
                                unit = "2";
                                year = DateTime.Substring(10, 4);
                                month = DateTime.Substring(15, 2);
                                day = DateTime.Substring(18, 2);
                                hr = DateTime.Substring(21, 2);
                                mins = DateTime.Substring(24, 2);
                                secs = DateTime.Substring(27, 2);
                                if (DateTime.Length == 29)
                                { text = DateTime.Substring(29, 1); }
                                else
                                { text = DateTime.Substring(29, DateTime.Length - 29); }

                                decimal dec = Convert.ToDecimal(text) * 100;
                                dec = Math.Round(dec, 2);
                                value = (Convert.ToInt32(dec)).ToString();
                                DataList.Add(unit);
                                DataList.Add(year);
                                DataList.Add(month); DataList.Add(day);
                                DataList.Add(hr); DataList.Add(mins);
                                DataList.Add(secs); DataList.Add(value);
                            }

                            ushort ID = 8;
                            byte unitt = Convert.ToByte(0);
                            ushort StartAddress = ReadStartAdr(addr);

                            data = GetData(Convert.ToByte(DataList.Count));
                            MBmaster.WriteMultipleRegister(ID, unitt, StartAddress, data);
                            count++;
                        }
                    }
                }
            }
            else if (rd_GasLogger.Checked == true)
            {
                XmlNodeList rankList = mySourceDoc.SelectNodes("/messages/message/message");
                foreach (XmlNode myRankNode in rankList)
                {
                    for (int i = 0; i < myRankNode.ChildNodes.Count; i++)
                    {
                        DataList = new ArrayList();
                        if (myRankNode.ChildNodes[i].Name == "pt")
                        {
                            addr = 0;
                            if (count != 0) { addr = count * 10; } else { count = 0; addr = count; }
                            DateTime = myRankNode.ChildNodes[i].InnerText;
                            string chk = DateTime[0].ToString();
                            if (chk == "1")
                            {
                                string text;
                                unit = "1";
                                year = DateTime.Substring(29, 4);
                                month = DateTime.Substring(34, 2);
                                day = DateTime.Substring(37, 2);
                                hr = DateTime.Substring(40, 2);
                                mins = DateTime.Substring(43, 2);
                                secs = DateTime.Substring(46, 2);
                                if (DateTime.Length == 48)
                                { text = DateTime.Substring(48, 1); }
                                else
                                { text = DateTime.Substring(48, DateTime.Length - 48); }
                                decimal dec = Convert.ToDecimal(text) * 100;
                                dec = Math.Round(dec, 2);
                                value = (Convert.ToInt32(dec)).ToString();
                                DataList.Add(unit);
                                DataList.Add(year);
                                DataList.Add(month); DataList.Add(day);
                                DataList.Add(hr); DataList.Add(mins);
                                DataList.Add(secs); DataList.Add(value);
                                transmit();
                            }
                            else if (chk == "2")
                            {
                                string text;
                                unit = "2";
                                year = DateTime.Substring(29, 4);
                                month = DateTime.Substring(34, 2);
                                day = DateTime.Substring(37, 2);
                                hr = DateTime.Substring(40, 2);
                                mins = DateTime.Substring(43, 2);
                                secs = DateTime.Substring(46, 2);
                                if (DateTime.Length == 48)
                                { text = DateTime.Substring(48, 1); }
                                else
                                { text = DateTime.Substring(48, DateTime.Length - 48); }
                                decimal dec = Convert.ToDecimal(text) * 100;
                                dec = Math.Round(dec, 2);
                                value = (Convert.ToInt32(dec)).ToString();
                                DataList.Add(unit);
                                DataList.Add(year);
                                DataList.Add(month); DataList.Add(day);
                                DataList.Add(hr); DataList.Add(mins);
                                DataList.Add(secs); DataList.Add(value);
                                transmit();
                            }
                            else if (chk == "3")
                            {
                                string text;
                                unit = "3";
                                year = DateTime.Substring(28, 4);
                                month = DateTime.Substring(33, 2);
                                day = DateTime.Substring(36, 2);
                                hr = DateTime.Substring(39, 2);
                                mins = DateTime.Substring(42, 2);
                                secs = DateTime.Substring(45, 2);
                                if (DateTime.Length == 47)
                                { text = DateTime.Substring(47, 1); }
                                else
                                { text = DateTime.Substring(47, DateTime.Length - 47); }
                                decimal dec = Convert.ToDecimal(text) * 100;
                                dec = Math.Round(dec, 2);
                                value = (Convert.ToInt32(dec)).ToString();
                                DataList.Add(unit);
                                DataList.Add(year);
                                DataList.Add(month); DataList.Add(day);
                                DataList.Add(hr); DataList.Add(mins);
                                DataList.Add(secs); DataList.Add(value);
                                transmit();
                            }
                            else if (chk == "4")
                            {
                                string text;
                                unit = "4";
                                year = DateTime.Substring(21, 4);
                                month = DateTime.Substring(26, 2);
                                day = DateTime.Substring(29, 2);
                                hr = DateTime.Substring(32, 2);
                                mins = DateTime.Substring(35, 2);
                                secs = DateTime.Substring(38, 2);
                                if (DateTime.Length == 40)
                                { text = DateTime.Substring(40, 1); }
                                else
                                { text = DateTime.Substring(40, DateTime.Length - 40); }
                                decimal dec = Convert.ToDecimal(text) * 100;
                                dec = Math.Round(dec, 2);
                                value = (Convert.ToInt32(dec)).ToString();
                                DataList.Add(unit);
                                DataList.Add(year);
                                DataList.Add(month); DataList.Add(day);
                                DataList.Add(hr); DataList.Add(mins);
                                DataList.Add(secs); DataList.Add(value);
                                transmit();
                            }
                            
                        }
                    }
                }
            }
            
        }

        private void transmit()
        {
            ushort ID = 8;
            byte unitt = Convert.ToByte(0);
            ushort StartAddress = ReadStartAdr(addr);

            data = GetData(Convert.ToByte(DataList.Count));
            MBmaster.WriteMultipleRegister(ID, unitt, StartAddress, data);
            count++;
        }

        private void ConnectToServer()
        {
            try
            {
                // Create new modbus master and add event functions
                MBmaster = new Master(txt_IPAddress.Text, 502, true);
                MBmaster.OnResponseData += new ModbusTCP.Master.ResponseData(MBmaster_OnResponseData);
                MBmaster.OnException += new ModbusTCP.Master.ExceptionData(MBmaster_OnException);
                // Show additional fields, enable watchdog
                
                grpData.Visible = true;
            }
            catch (SystemException error)
            {
                MessageBox.Show(error.Message);
            }
            
        }

        private void MBmaster_OnException(ushort id, byte unit, byte function, byte exception)
        {
            string exc = "Modbus says error: ";
            switch (exception)
            {
                case Master.excIllegalFunction: exc += "Illegal function!"; break;
                case Master.excIllegalDataAdr: exc += "Illegal data adress!"; break;
                case Master.excIllegalDataVal: exc += "Illegal data value!"; break;
                case Master.excSlaveDeviceFailure: exc += "Slave device failure!"; break;
                case Master.excAck: exc += "Acknoledge!"; break;
                case Master.excGatePathUnavailable: exc += "Gateway path unavailbale!"; break;
                case Master.excExceptionTimeout: exc += "Slave timed out!"; break;
                case Master.excExceptionConnectionLost: exc += "Connection is lost!"; break;
                case Master.excExceptionNotConnected: exc += "Not connected!"; break;
            }
            grpData.Text = exc;
            //MessageBox.Show(exc, "Modbus slave exception");
        }

        private void MBmaster_OnResponseData(ushort id, byte unit, byte function, byte[] data)
        {
            // ------------------------------------------------------------------
            // Seperate calling threads
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Master.ResponseData(MBmaster_OnResponseData), new object[] { id, unit, function, data });
                return;
            }

            // ------------------------------------------------------------------------
            // Identify requested data
            
                    grpData.Text = "Write multiple register";
                    
        }

        private ushort ReadStartAdr(int count)
        {
            txtStartAdress.Text = Convert.ToString(count);
            if (txtStartAdress.Text.IndexOf("0x", 0, txtStartAdress.Text.Length) == 0)
            {
                string str = txtStartAdress.Text.Replace("0x", "");
                ushort hex = Convert.ToUInt16(str, 16);
                return hex;
            }
            else
            {
                return Convert.ToUInt16(txtStartAdress.Text);
            }
        }

        private byte[] GetData(int num)
        {
            bool[] bits = new bool[num];
            byte[] data = new Byte[num];
            int[] word = new int[num];
            
            // ------------------------------------------------------------------------
            // Convert data from text boxes
            //foreach (string datafet in DataList)
            //{           
            //        int x = Convert.ToInt16(datafet);
                    
            //        if (radWord.Checked)
            //        {
            //            if ((x <= data.GetUpperBound(0)) && (datafet != ""))
            //            {
            //                try { word[x] = Convert.ToInt16(datafet); }
            //                catch (SystemException) { word[x] = Convert.ToUInt16(datafet); };
            //            }
            //            else break;
            //        }
            //}

            for(int i=0;i<DataList.Count;i++)
            {
                int x = Convert.ToInt16(i);

                if (radWord.Checked)
                {
                    if ((x <= data.GetUpperBound(0)) && (DataList[i].ToString() != ""))
                    {
                        try { word[x] = Convert.ToInt16(DataList[i]); }
                        catch (SystemException) { word[x] = Convert.ToUInt16(DataList[i]); };
                    }
                    else break;
                }
            }
            
            if (radWord.Checked)
            {
                data = new Byte[num * 2];
                for (int x = 0; x < num; x++)
                {
                    byte[] dat = BitConverter.GetBytes((short)IPAddress.HostToNetworkOrder((short)word[x]));
                    data[x * 2] = dat[0];
                    data[x * 2 + 1] = dat[1];
                }
            }
            return data;
            
        }
    }
}
