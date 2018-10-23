using EasyModbus;
using EasyModbusServerSimulator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MGL
{
    public partial class Server : Form
    {
        ArrayList DataList;
        byte[] data;
        string unit, year, month, day, hr, mins, secs, value, today, yest;
        string Yr1, month1, day1, hr1, mins1, OUT1, OUT2, IN1, TEMP;
        string Process = "";

        private void rd_AutoProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_AutoProcess.Checked == true) { dp_HrsList.Visible = true; lbl_Hrs.Visible = true; Process = "A"; }
            else if (rd_AutoProcess.Checked == false) { dp_HrsList.Visible = false; lbl_Hrs.Visible = false; Process = "M"; }
        }

        private void Server_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default["CHK1"].ToString() == "Y") { txt_SN1.Text = Properties.Settings.Default["Dev1"].ToString(); txt_SIM1.Text = Properties.Settings.Default["SIM1"].ToString(); chk_device1.CheckState = CheckState.Checked; }
            if (Properties.Settings.Default["CHK2"].ToString() == "Y") { txt_SN2.Text = Properties.Settings.Default["Dev2"].ToString(); txt_SIM2.Text = Properties.Settings.Default["SIM2"].ToString(); chk_device2.CheckState = CheckState.Checked; }
            if (Properties.Settings.Default["CHK3"].ToString() == "Y") { txt_SN3.Text = Properties.Settings.Default["Dev3"].ToString(); txt_SIM3.Text = Properties.Settings.Default["SIM3"].ToString(); chk_device3.CheckState = CheckState.Checked; }
            dt = DateTime.Today;

            dt2 = DateTime.Today.AddDays(-1);
            today = dt.ToString("dd/M/yy", CultureInfo.InvariantCulture);
            yest = dt2.ToString("dd/M/yy", CultureInfo.InvariantCulture);
            lbl_FromDt.Text = yest;
            lbl_ToDt.Text = today;
        }

        private void txt_SaveDevices_Click(object sender, EventArgs e)
        {
            if (chk_device1.CheckState == CheckState.Checked) { Properties.Settings.Default["Dev1"] = txt_SN1.Text; Properties.Settings.Default["CHK1"] = "Y";  Properties.Settings.Default["SIM1"] = txt_SIM1.Text; Properties.Settings.Default.Save(); } else { Properties.Settings.Default["Dev1"] = ""; Properties.Settings.Default["CHK1"] = "N"; Properties.Settings.Default["SIM1"] = ""; Properties.Settings.Default.Save(); }
            if (chk_device2.CheckState == CheckState.Checked) { Properties.Settings.Default["CHK2"] = "Y"; Properties.Settings.Default["Dev2"] = txt_SN2.Text; Properties.Settings.Default["SIM2"] = txt_SIM2.Text; Properties.Settings.Default.Save(); } else { Properties.Settings.Default["Dev2"] = ""; Properties.Settings.Default["CHK2"] = "N"; Properties.Settings.Default["SIM2"] = ""; Properties.Settings.Default.Save(); }
            if (chk_device3.CheckState == CheckState.Checked) { Properties.Settings.Default["CHK3"] = "Y"; Properties.Settings.Default["Dev3"] = txt_SN3.Text; Properties.Settings.Default["SIM3"] = txt_SIM1.Text; Properties.Settings.Default.Save(); } else { Properties.Settings.Default["Dev3"] = ""; Properties.Settings.Default["CHK3"] = "N"; Properties.Settings.Default["SIM3"] = ""; Properties.Settings.Default.Save(); }
        }


        //private ModbusTCP.Master MBmaster;
        Int32 addr, count;
        DateTime dt, dt2;
        Settings settings = new Settings();
        ModbusServer easyModbusTCPServer;
        //ModbusClient easyModbusTCPClient;

        public Server()
        {
            InitializeComponent();
            easyModbusTCPServer = new EasyModbus.ModbusServer();
            
        }

        private void bttn_Fetch_Click(object sender, EventArgs e)
        {
            if (chk_device1.CheckState == CheckState.Checked)
            {
                easyModbusTCPServer.UnitIdentifier = Convert.ToByte(txt_SN1.Text);
                lbl_DeviceID.Text = txt_SN1.Text;
                lbl_MobileNo.Text = txt_SIM1.Text;
                
                FetchDetails();
                easyModbusTCPServer.StopListening();
                Thread.Sleep(1000);
            }
            if(chk_device2.CheckState==CheckState.Checked)
            {
                easyModbusTCPServer.UnitIdentifier = Convert.ToByte(txt_SN2.Text);
                lbl_DeviceID.Text = txt_SN2.Text;
                lbl_MobileNo.Text = txt_SIM2.Text;
                
                FetchDetails();
                easyModbusTCPServer.StopListening();
                Thread.Sleep(1000);
            }
            if (chk_device3.CheckState == CheckState.Checked)
            {
                lbl_DeviceID.Text = txt_SN3.Text;
                lbl_MobileNo.Text = txt_SIM3.Text;
                easyModbusTCPServer.UnitIdentifier = Convert.ToByte(txt_SN3.Text);
                
                FetchDetails();
                easyModbusTCPServer.StopListening();
                Thread.Sleep(1000);
            }

        }

        private void FetchDetails()
        {
            easyModbusTCPServer.Listen();
            string DateTimefetch;
            count = 0;

            string URLString = "http://" + txt_IPAddress.Text + "/datagate/api/MessagingAPI.ashx?format=XML&username=" + txt_UserName.Text + "&password=" + txt_Password.Text + "&software=DataGate2Admin&number=" + lbl_MobileNo.Text + "&beginDate=" + yest + "&endDate=" + today + "";
            //string URLString = "http://103.11.117.219/Datagate/api/MessagingAPI.ashx?format=XML&username=admin&password=Admin@123&software=DataGate2Admin&number=919726419628&beginDate=17/10/18&endDate=18/10/18";
            //string URLString = "http://103.11.117.219/Datagate/api/MessagingAPI.ashx?format=XML&username=admin&password=Admin@123&software=DataGate2Admin&number=919726419628&beginDate="+yest+"&endDate="+today;
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

            XmlNodeList rankList = mySourceDoc.SelectNodes("/messages/message/message");
            if (rd_GasLogger.Checked == true) { GasLogger(rankList); }
            else if (rd_WaterLogger.Checked == true) { WaterLogger(rankList); }
        }

        private void WaterLogger(XmlNodeList rankList)
        {
            string DateTimefetch;
            foreach (XmlNode myRankNode in rankList)
            {
                for (int i = 0; i < myRankNode.ChildNodes.Count; i++)
                {
                    DataList = new ArrayList();
                    if (myRankNode.ChildNodes[i].Name == "pt")
                    {
                        Int32 addr = 0;
                        if (count != 0) { addr = count * 10; } else { count = 0; addr = count; }
                        DateTimefetch = myRankNode.ChildNodes[i].InnerText;
                        string chk = DateTimefetch[0].ToString();
                        if (chk == "1")
                        {
                            string text;
                            unit = "1";
                            year = DateTimefetch.Substring(16, 4);
                            month = DateTimefetch.Substring(21, 2);
                            day = DateTimefetch.Substring(24, 2);
                            hr = DateTimefetch.Substring(27, 2);
                            mins = DateTimefetch.Substring(30, 2);
                            secs = DateTimefetch.Substring(33, 2);
                            if (DateTimefetch.Length == 35)
                            { text = DateTimefetch.Substring(35, 1); }
                            else
                            { text = DateTimefetch.Substring(35, DateTimefetch.Length - 35); }
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
                            year = DateTimefetch.Substring(10, 4);
                            month = DateTimefetch.Substring(15, 2);
                            day = DateTimefetch.Substring(18, 2);
                            hr = DateTimefetch.Substring(21, 2);
                            mins = DateTimefetch.Substring(24, 2);
                            secs = DateTimefetch.Substring(27, 2);
                            if (DateTimefetch.Length == 29)
                            { text = DateTimefetch.Substring(29, 1); }
                            else
                            { text = DateTimefetch.Substring(29, DateTimefetch.Length - 29); }

                            decimal dec = Convert.ToDecimal(text) * 100;
                            dec = Math.Round(dec, 2);
                            value = (Convert.ToInt32(dec)).ToString();
                            DataList.Add(unit);
                            DataList.Add(year);
                            DataList.Add(month); DataList.Add(day);
                            DataList.Add(hr); DataList.Add(mins);
                            DataList.Add(secs); DataList.Add(value);
                        }

                        Yr1 = year; month1 = month; day1 = day;
                        hr1 = hr; mins1 = mins; 
                    }
                }
            }
        }

        private void GasLogger(XmlNodeList rankList)
        {
            string DateTimefetch;
            foreach (XmlNode myRankNode in rankList)
            {
                int CC = 0;
                for (int i = 0; i < myRankNode.ChildNodes.Count; i++)
                {
                    DataList = new ArrayList();
                    if (myRankNode.ChildNodes[i].Name == "pt")
                    {
                        addr = 0;
                        
                        //grpData.Text = "Writing to " + addr + " register";
                        //if (count != 0) { addr = count * 10; } else { count = 0; addr = count; }
                        DateTimefetch = myRankNode.ChildNodes[i].InnerText;
                        string chk = DateTimefetch[0].ToString();
                        if (chk == "1")
                        {
                            string text;
                            unit = "1";
                            year = DateTimefetch.Substring(29, 4);
                            month = DateTimefetch.Substring(34, 2);
                            day = DateTimefetch.Substring(37, 2);
                            hr = DateTimefetch.Substring(40, 2);
                            mins = DateTimefetch.Substring(43, 2);
                            secs = DateTimefetch.Substring(46, 2);
                            if (DateTimefetch.Length == 49)
                            { text = DateTimefetch.Substring(48, 1); }
                            else
                            { text = DateTimefetch.Substring(48, DateTimefetch.Length - 48); }
                            if(text.Length>4)
                            text = text.Substring(0, 4);
                            decimal dec = Convert.ToDecimal(text) * 100;
                            dec = Math.Round(dec, 2);
                            value = System.Math.Abs((Convert.ToInt32(dec))).ToString();
                            DataList.Add(unit);
                            DataList.Add(year);
                            DataList.Add(month); DataList.Add(day);
                            DataList.Add(hr); DataList.Add(mins);
                            DataList.Add(secs); DataList.Add(value);
                            string C1 = DateTimefetch.Substring(29, 10);
                            DateTime tod = Convert.ToDateTime(C1);
                            string C2 = tod.ToString("dd/M/yy", CultureInfo.InvariantCulture);
                            Yr1 = year; month1 = month; day1 = day;
                            hr1 = hr; mins1 = mins;
                            OUT1 = value;
                            CC++;
                        }
                        else if (chk == "2")
                        {
                            string text;
                            unit = "2";
                            year = DateTimefetch.Substring(29, 4);
                            month = DateTimefetch.Substring(34, 2);
                            day = DateTimefetch.Substring(37, 2);
                            hr = DateTimefetch.Substring(40, 2);
                            mins = DateTimefetch.Substring(43, 2);
                            secs = DateTimefetch.Substring(46, 2);
                            if (DateTimefetch.Length == 49)
                            { text = DateTimefetch.Substring(48, 1); }
                            else
                            { text = DateTimefetch.Substring(48, DateTimefetch.Length - 48); }
                            if (text.Length > 4)
                                text = text.Substring(0, 4);
                            decimal dec = Convert.ToDecimal(text) * 100;
                            dec = Math.Round(dec, 2);
                            value = System.Math.Abs((Convert.ToInt32(dec))).ToString();
                            DataList.Add(unit);
                            DataList.Add(year);
                            DataList.Add(month); DataList.Add(day);
                            DataList.Add(hr); DataList.Add(mins);
                            DataList.Add(secs); DataList.Add(value);
                            string C1 = DateTimefetch.Substring(29, 10);
                            DateTime tod = Convert.ToDateTime(C1);
                            string C2 = tod.ToString("dd/M/yy", CultureInfo.InvariantCulture);
                            Yr1 = year; month1 = month; day1 = day;
                            hr1 = hr; mins1 = mins;
                            OUT2 = value;
                            CC++;
                        }
                        else if (chk == "3")
                        {
                            string text;
                            unit = "3";
                            year = DateTimefetch.Substring(28, 4);
                            month = DateTimefetch.Substring(33, 2);
                            day = DateTimefetch.Substring(36, 2);
                            hr = DateTimefetch.Substring(39, 2);
                            mins = DateTimefetch.Substring(42, 2);
                            secs = DateTimefetch.Substring(45, 2);
                            if (DateTimefetch.Length == 48)
                            { text = DateTimefetch.Substring(47, 1); }
                            else
                            { text = DateTimefetch.Substring(47, DateTimefetch.Length - 48); }
                            if (text.Length > 4)
                                text = text.Substring(0, 4);
                            decimal dec = Convert.ToDecimal(text) * 100;
                            dec = Math.Round(dec, 2);
                            value = System.Math.Abs((Convert.ToInt32(dec))).ToString();
                            DataList.Add(unit);
                            DataList.Add(year);
                            DataList.Add(month); DataList.Add(day);
                            DataList.Add(hr); DataList.Add(mins);
                            DataList.Add(secs); DataList.Add(value);
                            string C1 = DateTimefetch.Substring(28, 10);
                            DateTime tod = Convert.ToDateTime(C1);
                            string C2 = tod.ToString("dd/M/yy", CultureInfo.InvariantCulture);
                            IN1 = value;
                            CC++;
                        }
                        else if (chk == "4")
                        {
                            string text;
                            unit = "4";
                            year = DateTimefetch.Substring(21, 4);
                            month = DateTimefetch.Substring(26, 2);
                            day = DateTimefetch.Substring(29, 2);
                            hr = DateTimefetch.Substring(32, 2);
                            mins = DateTimefetch.Substring(35, 2);
                            secs = DateTimefetch.Substring(38, 2);
                            if (DateTimefetch.Length == 40)
                            { text = DateTimefetch.Substring(40, 1); }
                            else
                            { text = DateTimefetch.Substring(40, DateTimefetch.Length - 40); }
                            if (text.Length > 4)
                                text = text.Substring(0, 4);
                            decimal dec = Convert.ToDecimal(text) * 100;
                            dec = Math.Round(dec, 2);
                            value = System.Math.Abs((Convert.ToInt32(dec))).ToString();
                            DataList.Add(unit);
                            DataList.Add(year);
                            DataList.Add(month); DataList.Add(day);
                            DataList.Add(hr); DataList.Add(mins);
                            DataList.Add(secs); DataList.Add(value);
                            string C1 = DateTimefetch.Substring(21, 10);
                            DateTime tod = Convert.ToDateTime(C1);
                            string C2 = tod.ToString("dd/M/yy", CultureInfo.InvariantCulture);
                            TEMP = value;
                            CC++;
                        }
                        if (CC == 4) { transmit(); }
                    }

                }
            }
        }

        private void transmit()
        {
            grpData.Visible = true;
            if (count != 0) { addr = count * 10; } else { count = 0; addr = count; }
            easyModbusTCPServer.holdingRegisters[1] = Int16.Parse(Yr1);
            easyModbusTCPServer.holdingRegisters[2] = Int16.Parse(month1);
            easyModbusTCPServer.holdingRegisters[3] = Int16.Parse(day1);
            easyModbusTCPServer.holdingRegisters[4] = Int16.Parse(hr1);
            easyModbusTCPServer.holdingRegisters[5] = Int16.Parse(mins1);
            easyModbusTCPServer.holdingRegisters[6] = Int16.Parse(IN1);
            easyModbusTCPServer.holdingRegisters[7] = Int16.Parse(OUT1);
            easyModbusTCPServer.holdingRegisters[8] = Int16.Parse(OUT2);
            easyModbusTCPServer.holdingRegisters[9] = Int16.Parse(TEMP);
            //easyModbusTCPServer.StopListening();
            //grpData.Text = "Writing to " + addr + "register";
            //ushort ID = 8;
            //byte unitt = Convert.ToByte(0);
            //ushort StartAddress = ReadStartAdr(addr);

            //data = GetData(Convert.ToByte(DataList.Count));
            //MBmaster.WriteMultipleRegister(ID, unitt, StartAddress, data);
            //count++;

            Thread.Sleep(500);
        }
    }
}
