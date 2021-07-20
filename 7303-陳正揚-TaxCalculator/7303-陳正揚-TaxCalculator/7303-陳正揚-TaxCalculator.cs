using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7303_陳正揚_TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.radioButton1.Checked = true;
            this.Init();
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }





        private void comboBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox_Type.Text == "機車")
            {
                this.comboBox_CC.Items.Clear();

                this.comboBox_CC.Items.Add("150以下/12HP以下(12.2PS以下)");
                this.comboBox_CC.Items.Add("151-25012.1-20HP(12.3-20.3PS)");
                this.comboBox_CC.Items.Add("251-500/20.1以上(20.4PS以上)");
                this.comboBox_CC.Items.Add("501-600");
                this.comboBox_CC.Items.Add("601-1200");
                this.comboBox_CC.Items.Add("1201-1800");
                this.comboBox_CC.Items.Add("1801或以上");
            }
            else if (this.comboBox_Type.Text == "貨車")
            {
                this.comboBox_CC.Items.Clear();

                this.comboBox_CC.Items.Add("500以下");
                this.comboBox_CC.Items.Add("501-600");
                this.comboBox_CC.Items.Add("601-1200");
                this.comboBox_CC.Items.Add("1201-1800");
                this.comboBox_CC.Items.Add("1801-2400");
                this.comboBox_CC.Items.Add("2401-3000/138HP以下(140,1PS以下)");
                this.comboBox_CC.Items.Add("3001-3600");
                this.comboBox_CC.Items.Add("3601-4200/138.1-200HP(140.2-230.0PS)");
                this.comboBox_CC.Items.Add("4201-4800");
                this.comboBox_CC.Items.Add("4801-5400/200.1-247HP(203.1-250..7PS)");
                this.comboBox_CC.Items.Add("5401-6000");
                this.comboBox_CC.Items.Add("6001-6600/247.1-286HP(250.8-290.3PS)");
                this.comboBox_CC.Items.Add("6601-7200");
                this.comboBox_CC.Items.Add("7201-7800/286.1-336HP(290.4-341.0PS)");
                this.comboBox_CC.Items.Add("7801-8400");
                this.comboBox_CC.Items.Add("8401-9000/336.1-361HP(341.1-366.4PS)");
                this.comboBox_CC.Items.Add("9001-9600");
                this.comboBox_CC.Items.Add("9601-10200/361.1HP以上(366.5PS以上)");
                this.comboBox_CC.Items.Add("10201以上");
            }
            else if (this.comboBox_Type.Text == "大客車")
            {
                this.comboBox_CC.Items.Clear();

                this.comboBox_CC.Items.Add("600以下");
                this.comboBox_CC.Items.Add("601-1200");
                this.comboBox_CC.Items.Add("1201-1800");
                this.comboBox_CC.Items.Add("1801-2400");
                this.comboBox_CC.Items.Add("2401-3000/138HP以下(140,1PS以下)");
                this.comboBox_CC.Items.Add("3001-3600");
                this.comboBox_CC.Items.Add("3601-4200/138.1-200HP(140.2-230.0PS)");
                this.comboBox_CC.Items.Add("4201-4800");
                this.comboBox_CC.Items.Add("4801-5400/200.1-247HP(203.1-250..7PS)");
                this.comboBox_CC.Items.Add("5401-6000");
                this.comboBox_CC.Items.Add("6001-6600/247.1-286HP(250.8-290.3PS)");
                this.comboBox_CC.Items.Add("6601-7200");
                this.comboBox_CC.Items.Add("7201-7800/286.1-336HP(290.4-341.0PS)");
                this.comboBox_CC.Items.Add("7801-8400");
                this.comboBox_CC.Items.Add("8401-9000/336.1-361HP(341.1-366.4PS)");
                this.comboBox_CC.Items.Add("9001-9600");
                this.comboBox_CC.Items.Add("9601-10200/361.1HP以上(366.5PS以上)");
                this.comboBox_CC.Items.Add("10201以上");
            }
            else if (this.comboBox_Type.Text == "自用小客車")
            {
                this.comboBox_CC.Items.Clear();

                this.comboBox_CC.Items.Add("500以下/38HP以下(38.6PS以下)");
                this.comboBox_CC.Items.Add("501-600/38.1-56HP(38.7-56.8PS)");
                this.comboBox_CC.Items.Add("601-1200/56.1-83HP(56.9-84.2PS)");
                this.comboBox_CC.Items.Add("1201-1800/83.1-182HP(184.8-265.9PS)");
                this.comboBox_CC.Items.Add("1801-2400/182.1-262HP(184.8-265.9PS)");
                this.comboBox_CC.Items.Add("2401-3000/262.1-322HP(266-326.8HP)");
                this.comboBox_CC.Items.Add("3001-4200/322.1-414HP(326.9-420.2PS)");
                this.comboBox_CC.Items.Add("4201-5400/414.1-469HP(420.3-476.0PS)");
                this.comboBox_CC.Items.Add("5401-6600/469.1-509HP(476.1-516.6PS)");
                this.comboBox_CC.Items.Add("6601-7800/509.1HP以上(516.7ps以上)");
                this.comboBox_CC.Items.Add("7801以上");
            }
            else if (this.comboBox_Type.Text == "營業用小客車")
            {
                this.comboBox_CC.Items.Clear();

                this.comboBox_CC.Items.Add("500以下/38HP以下(38.6PS以下)");
                this.comboBox_CC.Items.Add("501-600/38.1-56HP(38.7-56.8PS)");
                this.comboBox_CC.Items.Add("601-1200/56.1-83HP(56.9-84.2PS)");
                this.comboBox_CC.Items.Add("1201-1800/83.1-182HP(184.8-265.9PS)");
                this.comboBox_CC.Items.Add("1801-2400/182.1-262HP(184.8-265.9PS)");
                this.comboBox_CC.Items.Add("2401-3000/262.1-322HP(266-326.8HP)");
                this.comboBox_CC.Items.Add("3001-4200/322.1-414HP(326.9-420.2PS)");
                this.comboBox_CC.Items.Add("4201-5400/414.1-469HP(420.3-476.0PS)");
                this.comboBox_CC.Items.Add("5401-6600/469.1-509HP(476.1-516.6PS)");
                this.comboBox_CC.Items.Add("6601-7800/509.1HP以上(516.7ps以上)");
                this.comboBox_CC.Items.Add("7801以上");
            }
            this.comboBox_CC.SelectedIndex = 0;

        }

        private void OutputList_1()
        {
            if (radioButton1.Checked)
            {
                if (this.comboBox_Type.Text == "機車")
                    if (this.comboBox_CC.Text == "150以下/12HP以下(12.2PS以下)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 150以下 / 12HP以下(12.2PS以下)"
                            + Environment.NewLine + "用途: 機車" + Environment.NewLine + "計算公式: 0 * 365 / 365 = 0元" + Environment.NewLine + "應納稅額: 共 0 元";
                    }
                    else if (this.comboBox_CC.Text == "151-25012.1-20HP(12.3-20.3PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 151-250 / 12.1-20HP(12.3-20.3PS)" + Environment.NewLine + "用途: 機車"
                            + Environment.NewLine + "計算公式: 800 * 365 / 365 = 800元" + Environment.NewLine + "應納稅額: 共 800 元";
                    }
                    else if (this.comboBox_CC.Text == "251-500/20.1以上(20.4PS以上)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 251-500 / 20.1HP以上(20.4PS以上)" + Environment.NewLine + "用途: 機車"
                            + Environment.NewLine + "計算公式: 1620 * 365 / 365 = 1620元" + Environment.NewLine + "應納稅額: 共 1620 元";
                    }
                    else if (this.comboBox_CC.Text == "501-600")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 501-600"
                            + Environment.NewLine + "用途: 機車" + Environment.NewLine + "計算公式: 2160 * 365 / 365 = 2160元" + Environment.NewLine + "應納稅額: 共 2160 元";
                    }
                    else if (this.comboBox_CC.Text == "601-1200")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 601-1200"
                            + Environment.NewLine + "用途: 機車" + Environment.NewLine + "計算公式: 4320 * 365 / 365 = 4320元" + Environment.NewLine + "應納稅額: 共 4320 元";
                    }
                    else if (this.comboBox_CC.Text == "1201-1800")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1201-1800"
                            + Environment.NewLine + "用途: 機車" + Environment.NewLine + "計算公式: 7120 * 365 / 365 = 7120元" + Environment.NewLine + "應納稅額: 共 7120 元";
                    }
                    else if (this.comboBox_CC.Text == "1801或以上")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1801或以上"
                            + Environment.NewLine + "用途: 機車" + Environment.NewLine + "計算公式: 11230 * 365 / 365 = 11230元" + Environment.NewLine + "應納稅額: 共 11230 元";
                    }

                if (this.comboBox_Type.Text == "貨車")
                    if (this.comboBox_CC.Text == "500以下")
                    {
                        this.OutputList.Text = "使用期間: 110 - 01 - 01 ~110 - 12 - 31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 500以下"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 900 * 365 / 365 = 900元" + Environment.NewLine + "應納稅額: 共 900 元";
                    }
                    else if (this.comboBox_CC.Text == "501-600")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 501-600"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 1080 * 365 / 365 = 1080元" + Environment.NewLine + "應納稅額: 共 1080 元";
                    }
                    else if (this.comboBox_CC.Text == "601-1200")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 601-1200"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 1800 * 365 / 365 = 1800元" + Environment.NewLine + "應納稅額: 共 1800 元";
                    }
                    else if (this.comboBox_CC.Text == "1201-1800")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1201-1800"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 2700 * 365 / 365 = 2700元" + Environment.NewLine + "應納稅額: 共 2700 元";
                    }
                    else if (this.comboBox_CC.Text == "1801-2400")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1801-2400"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 3600 * 365 / 365 = 3600元" + Environment.NewLine + "應納稅額: 共 3600 元";
                    }
                    else if (this.comboBox_CC.Text == "2401-3000/138HP以下(140,1PS以下)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 2401-3000 / 138HP以下(140.1PS以下)"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 4500 * 365 / 365 = 4500元" + Environment.NewLine + "應納稅額: 共 4500 元";
                    }
                    else if (this.comboBox_CC.Text == "3001-3600")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 3001-3600"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 5400 * 365 / 365 = 5400元" + Environment.NewLine + "應納稅額: 共 5400 元";
                    }
                    else if (this.comboBox_CC.Text == "3601-4200/138.1-200HP(140.2-230.0PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 3601-4200 / 138.1-200HP(140.2-203.0PS)"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 6300 * 365 / 365 = 6300元" + Environment.NewLine + "應納稅額: 共 6300 元";
                    }
                    else if (this.comboBox_CC.Text == "4201-4800")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 4201-4800"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 7200 * 365 / 365 = 7200元" + Environment.NewLine + "應納稅額: 共 7200 元";
                    }
                    else if (this.comboBox_CC.Text == "4801-5400/200.1-247HP(203.1-250..7PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 4801-5400 / 200.1-247HP(203.1-250.7PS)"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 8100 * 365 / 365 = 8100元" + Environment.NewLine + "應納稅額: 共 8100 元";
                    }
                    else if (this.comboBox_CC.Text == "5401-6000")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 5401-6000"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 9000 * 365 / 365 = 9000元" + Environment.NewLine + "應納稅額: 共 9000 元";
                    }
                    else if (this.comboBox_CC.Text == "6001-6600/247.1-286HP(250.8-290.3PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 6001-6600 / 247.1-286HP(250.8-290.3PS)"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 9900 * 365 / 365 = 9900元" + Environment.NewLine + "應納稅額: 共 9900 元";
                    }
                    else if (this.comboBox_CC.Text == "6601-7200")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 6601-7200"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 10800 * 365 / 365 = 10800元" + Environment.NewLine + "應納稅額: 共 10800 元";
                    }
                    else if (this.comboBox_CC.Text == "7201-7800/286.1-336HP(290.4-341.0PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 7201-7800 / 286.1-336HP(290.4-341.0PS)"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 11700 * 365 / 365 = 11700元" + Environment.NewLine + "應納稅額: 共 11700 元";
                    }
                    else if (this.comboBox_CC.Text == "7801-8400")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 7801-8400"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 12600 * 365 / 365 = 12600元" + Environment.NewLine + "應納稅額: 共 12600 元";
                    }
                    else if (this.comboBox_CC.Text == "8401-9000/336.1-361HP(341.1-366.4PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 8401-9000 / 336.1-361HP(341.1-366.4PS)"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 13500 * 365 / 365 = 13500元" + Environment.NewLine + "應納稅額: 共 13500 元";
                    }
                    else if (this.comboBox_CC.Text == "9001-9600")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 9001-9600"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 14400 * 365 / 365 = 14400元" + Environment.NewLine + "應納稅額: 共 14400 元";
                    }
                    else if (this.comboBox_CC.Text == "9601-10200/361.1HP以上(366.5PS以上)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 9601-10200 / 361.1HP以上(366.5PS以上)"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 15300 * 365 / 365 = 15300元" + Environment.NewLine + "應納稅額: 共 15300 元";
                    }
                    else if (this.comboBox_CC.Text == "10201以上")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 10201以上"
                            + Environment.NewLine + "用途: 貨車" + Environment.NewLine + "計算公式: 16200 * 365 / 365 = 16200元" + Environment.NewLine + "應納稅額: 共 16200 元";
                    }

                if (this.comboBox_Type.Text == "大客車")
                    if (this.comboBox_CC.Text == "600以下")
                    {
                        this.OutputList.Text = "使用期間: 110 - 01 - 01 ~110 - 12 - 31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 600以下"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 900 * 365 / 365 = 900元" + Environment.NewLine + "應納稅額: 共 1080 元";
                    }
                    else if (this.comboBox_CC.Text == "601-1200")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 601-1200"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 1800 * 365 / 365 = 1800元" + Environment.NewLine + "應納稅額: 共 1800 元";
                    }
                    else if (this.comboBox_CC.Text == "1201-1800")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1201-1800"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 2700 * 365 / 365 = 2700元" + Environment.NewLine + "應納稅額: 共 2700 元";
                    }
                    else if (this.comboBox_CC.Text == "1801-2400")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1801-2400"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 3600 * 365 / 365 = 3600元" + Environment.NewLine + "應納稅額: 共 3600 元";
                    }
                    else if (this.comboBox_CC.Text == "2401-3000/138HP以下(140,1PS以下)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 2401-3000 / 138HP以下(140.1PS以下)"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 4500 * 365 / 365 = 4500元" + Environment.NewLine + "應納稅額: 共 4500 元";
                    }
                    else if (this.comboBox_CC.Text == "3001-3600")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 3001-3600"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 5400 * 365 / 365 = 5400元" + Environment.NewLine + "應納稅額: 共 5400 元";
                    }
                    else if (this.comboBox_CC.Text == "3601-4200/138.1-200HP(140.2-230.0PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 3601-4200 / 138.1-200HP(140.2-203.0PS)"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 6300 * 365 / 365 = 6300元" + Environment.NewLine + "應納稅額: 共 6300 元";
                    }
                    else if (this.comboBox_CC.Text == "4201-4800")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 4201-4800"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 7200 * 365 / 365 = 7200元" + Environment.NewLine + "應納稅額: 共 7200 元";
                    }
                    else if (this.comboBox_CC.Text == "4801-5400/200.1-247HP(203.1-250..7PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 4801-5400 / 200.1-247HP(203.1-250.7PS)"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 8100 * 365 / 365 = 8100元" + Environment.NewLine + "應納稅額: 共 8100 元";
                    }
                    else if (this.comboBox_CC.Text == "5401-6000")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 5401-6000"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 9000 * 365 / 365 = 9000元" + Environment.NewLine + "應納稅額: 共 9000 元";
                    }
                    else if (this.comboBox_CC.Text == "6001-6600/247.1-286HP(250.8-290.3PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 6001-6600 / 247.1-286HP(250.8-290.3PS)"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 9900 * 365 / 365 = 9900元" + Environment.NewLine + "應納稅額: 共 9900 元";
                    }
                    else if (this.comboBox_CC.Text == "6601-7200")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 6601-7200"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 10800 * 365 / 365 = 10800元" + Environment.NewLine + "應納稅額: 共 10800 元";
                    }
                    else if (this.comboBox_CC.Text == "7201-7800/286.1-336HP(290.4-341.0PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 7201-7800 / 286.1-336HP(290.4-341.0PS)"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 11700 * 365 / 365 = 11700元" + Environment.NewLine + "應納稅額: 共 11700 元";
                    }
                    else if (this.comboBox_CC.Text == "7801-8400")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 7801-8400"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 12600 * 365 / 365 = 12600元" + Environment.NewLine + "應納稅額: 共 12600 元";
                    }
                    else if (this.comboBox_CC.Text == "8401-9000/336.1-361HP(341.1-366.4PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 8401-9000 / 336.1-361HP(341.1-366.4PS)"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 13500 * 365 / 365 = 13500元" + Environment.NewLine + "應納稅額: 共 13500 元";
                    }
                    else if (this.comboBox_CC.Text == "9001-9600")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 9001-9600"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 14400 * 365 / 365 = 14400元" + Environment.NewLine + "應納稅額: 共 14400 元";
                    }
                    else if (this.comboBox_CC.Text == "9601-10200/361.1HP以上(366.5PS以上)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 9601-10200 / 361.1HP以上(366.5PS以上)"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 15300 * 365 / 365 = 15300元" + Environment.NewLine + "應納稅額: 共 15300 元";
                    }
                    else if (this.comboBox_CC.Text == "10201以上")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 10201以上"
                            + Environment.NewLine + "用途: 大客車" + Environment.NewLine + "計算公式: 16200 * 365 / 365 = 16200元" + Environment.NewLine + "應納稅額: 共 16200 元";
                    }

                if (this.comboBox_Type.Text == "自用小客車")
                    if (this.comboBox_CC.Text == "500以下/38HP以下(38.6PS以下)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 500以下 / 38HP以下(38.6PS以下)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 1620 * 365 / 365 = 1620元" + Environment.NewLine + "應納稅額: 共 1620 元";
                    }
                    else if (this.comboBox_CC.Text == "501-600/38.1-56HP(38.7-56.8PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 501~600 / 38.1-56HP(38.7-56.8PS)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 2160 * 365 / 365 = 2160元" + Environment.NewLine + "應納稅額: 共 2160 元";
                    }
                    else if (this.comboBox_CC.Text == "601-1200/56.1-83HP(56.9-84.2PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 601~1200 / 56.1-83HP(56.9-84.2PS)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 4320 * 365 / 365 = 4320元" + Environment.NewLine + "應納稅額: 共 4320 元";
                    }
                    else if (this.comboBox_CC.Text == "1201-1800/83.1-182HP(184.8-265.9PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1201~1800 / 83.1-182HP(84.3-184.7PS)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 7120 * 365 / 365 = 7120元" + Environment.NewLine + "應納稅額: 共 7120 元";
                    }
                    else if (this.comboBox_CC.Text == "1801-2400/182.1-262HP(184.8-265.9PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1801~2400 / 182.1-262HP(184.8-265.9PS)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 11230 * 365 / 365 = 11230元" + Environment.NewLine + "應納稅額: 共 11230 元";
                    }
                    else if (this.comboBox_CC.Text == "2401-3000/262.1-322HP(266-326.8HP)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 2401~3000 / 262.1-322HP(266-326.8PS)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 15210 * 365 / 365 = 15210元" + Environment.NewLine + "應納稅額: 共 15210 元";
                    }
                    else if (this.comboBox_CC.Text == "3001-4200/322.1-414HP(326.9-420.2PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 3001-4200 / 322.1-414HP(326.9-420.2PS"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 28220 * 365 / 365 = 28220元" + Environment.NewLine + "應納稅額: 共 28220 元";
                    }
                    else if (this.comboBox_CC.Text == "4201-5400/414.1-469HP(420.3-476.0PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 4201-5400 / 414.1-469HP(420.3-476.0PS)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 46170 * 365 / 365 = 46170元" + Environment.NewLine + "應納稅額: 共 46170 元";
                    }
                    else if (this.comboBox_CC.Text == "5401-6600/469.1-509HP(476.1-516.6PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 5401-6600 / 469.1-509HP(476.1-516.6PS)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 69690 * 365 / 365 = 69690元" + Environment.NewLine + "應納稅額: 共 69690 元";
                    }
                    else if (this.comboBox_CC.Text == "6601-7800/509.1HP以上(516.7ps以上)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 6601-7800 / 509.1HP以上(516.7PS以上)"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 117000 * 365 / 365 = 117000元" + Environment.NewLine + "應納稅額: 共 117000 元";
                    }
                    else if (this.comboBox_CC.Text == "7801以上")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 7801以上"
                            + Environment.NewLine + "用途: 自用小客車" + Environment.NewLine + "計算公式: 151200 * 365 / 365 = 151200元" + Environment.NewLine + "應納稅額: 共 151200 元";
                    }

                if (this.comboBox_Type.Text == "營業用小客車")
                    if (this.comboBox_CC.Text == "500以下/38HP以下(38.6PS以下)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 500以下 / 38HP以下(38.6PS以下)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 900 * 365 / 365 = 900元" + Environment.NewLine + "應納稅額: 共 900 元";
                    }
                    else if (this.comboBox_CC.Text == "501-600/38.1-56HP(38.7-56.8PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 501~600 / 38.1-56HP(38.7-56.8PS)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 1260 * 365 / 365 = 1260元" + Environment.NewLine + "應納稅額: 共 1260 元";
                    }
                    else if (this.comboBox_CC.Text == "601-1200/56.1-83HP(56.9-84.2PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 601~1200 / 56.1-83HP(56.9-84.2PS)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 2160 * 365 / 365 = 2160元" + Environment.NewLine + "應納稅額: 共 2160 元";
                    }
                    else if (this.comboBox_CC.Text == "1201-1800/83.1-182HP(184.8-265.9PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1201~1800 / 83.1-182HP(84.3-184.7PS)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 3060 * 365 / 365 = 3060元" + Environment.NewLine + "應納稅額: 共 3060 元";
                    }
                    else if (this.comboBox_CC.Text == "1801-2400/182.1-262HP(184.8-265.9PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 1801~2400 / 182.1-262HP(184.8-265.9PS)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 6480 * 365 / 365 = 6480元" + Environment.NewLine + "應納稅額: 共 6480 元";
                    }
                    else if (this.comboBox_CC.Text == "2401-3000/262.1-322HP(266-326.8HP)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 2401~3000 / 262.1-322HP(266-326.8PS)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 9900 * 365 / 365 = 9900元" + Environment.NewLine + "應納稅額: 共 9900 元";
                    }
                    else if (this.comboBox_CC.Text == "3001-4200/322.1-414HP(326.9-420.2PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 3001-4200 / 322.1-414HP(326.9-420.2PS"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 16380 * 365 / 365 = 16380元" + Environment.NewLine + "應納稅額: 共 16380 元";
                    }
                    else if (this.comboBox_CC.Text == "4201-5400/414.1-469HP(420.3-476.0PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 4201-5400 / 414.1-469HP(420.3-476.0PS)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 24300 * 365 / 365 = 24300元" + Environment.NewLine + "應納稅額: 共 24300 元";
                    }
                    else if (this.comboBox_CC.Text == "5401-6600/469.1-509HP(476.1-516.6PS)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 5401-6600 / 469.1-509HP(476.1-516.6PS)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 33660 * 365 / 365 = 33660元" + Environment.NewLine + "應納稅額: 共 33660 元";
                    }
                    else if (this.comboBox_CC.Text == "6601-7800/509.1HP以上(516.7ps以上)")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 6601-7800 / 509.1HP以上(516.7PS以上)"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 44460 * 365 / 365 = 44460元" + Environment.NewLine + "應納稅額: 共 44460 元";
                    }
                    else if (this.comboBox_CC.Text == "7801以上")
                    {
                        this.OutputList.Text = "使用期間: 110-01-01 ~ 110-12-31" + Environment.NewLine + "計算天數: 365天" + Environment.NewLine + "汽缸CC數: 7801以上"
                            + Environment.NewLine + "用途: 營業用小客車" + Environment.NewLine + "計算公式: 56700 * 365 / 365 = 56700元" + Environment.NewLine + "應納稅額: 共 56700 元";
                    }
            }
        }

        //-----------------------------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            OutputList_1();

            int LY = dateTimePicker1.Value.Year;
            int NMSL = 0;
            if (LY % 400 == 0 || LY % 4 == 0 && LY % 100 != 0)
            {
                NMSL = 366;
            }
            else
            {
                NMSL = 365;
            }
                //閏年的判斷條件格式
                // 如果 年能被400整除 或者 年能被4整除 並且年不能被100整除。

                TimeSpan TotalDay = dateTimePicker2.Value - dateTimePicker1.Value;
            int TotalDayData = TotalDay.Days + 1; 
            
            if (radioButton2.Checked)

                //-----------------機車-----------------//
                if (this.comboBox_Type.Text == "機車")
                    if (this.comboBox_CC.Text == "150以下/12HP以下(12.2PS以下)")
                    {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                    + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：150以下/12HP以下(12.2PS以下)"
                    + Environment.NewLine + "用途: 機車" + Environment.NewLine + $"計算公式：0 * {TotalDay.Days+1 / NMSL} / {NMSL} = {0 * (TotalDay.Days + 1) /NMSL}元 " 
                    + Environment.NewLine + $"應納稅額：{0 * (TotalDay.Days + 1) / NMSL}元";
                    }
                    else if (this.comboBox_CC.Text == "151-25012.1-20HP(12.3-20.3PS)")
                    {
                        this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                           + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：151-25012.1-20HP(12.3-20.3PS)"
                           + Environment.NewLine + "用途: 機車" + Environment.NewLine + $"計算公式：800 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {800 * (TotalDay.Days + 1) / NMSL}元 "
                           + Environment.NewLine + $"應納稅額：{800 * (TotalDay.Days + 1) / NMSL}元";
                    }
                    else if (this.comboBox_CC.Text == "251-500/20.1以上(20.4PS以上)")
                    {
                        this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                           + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：251-500/20.1以上(20.4PS以上)"
                           + Environment.NewLine + "用途: 機車" + Environment.NewLine + $"計算公式：1620 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {1620 * (TotalDay.Days + 1) / NMSL}元 "
                           + Environment.NewLine + $"應納稅額：{1620 * (TotalDay.Days + 1) / NMSL}元";
                    }
                    else if (this.comboBox_CC.Text == "501-600")
                    {
                        this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                           + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：501-600"
                           + Environment.NewLine + "用途: 機車" + Environment.NewLine + $"計算公式：2160 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {2160 * (TotalDay.Days + 1) / NMSL}元 "
                           + Environment.NewLine + $"應納稅額：{2160 * (TotalDay.Days + 1) / NMSL}元";
                    }
                    else if (this.comboBox_CC.Text == "601-1200")
                    {
                        this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                           + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：601-1200"
                           + Environment.NewLine + "用途: 機車" + Environment.NewLine + $"計算公式：4320 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {4320 * (TotalDay.Days + 1) / NMSL}元 "
                           + Environment.NewLine + $"應納稅額：{4320 * (TotalDay.Days + 1) / NMSL}元";
                    }
                    else if (this.comboBox_CC.Text == "1201-1800")
                    {
                        this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                           + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1201-1800"
                           + Environment.NewLine + "用途: 機車" + Environment.NewLine + $"計算公式：7120 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {7120 * (TotalDay.Days + 1) / NMSL}元 "
                           + Environment.NewLine + $"應納稅額：{7120 * (TotalDay.Days + 1) / NMSL}元";
                    }
                    else if (this.comboBox_CC.Text == "1801或以上")
                    {
                        this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                           + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1801或以上"
                           + Environment.NewLine + "用途: 機車" + Environment.NewLine + $"計算公式：11230 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {11230 * (TotalDay.Days + 1) / NMSL}元 "
                           + Environment.NewLine + $"應納稅額：{11230 * (TotalDay.Days + 1) / NMSL}元";
                    }

            //-----------------貨車-----------------//
            if (this.comboBox_Type.Text == "貨車")
                if (this.comboBox_CC.Text == "500以下")
                {
                this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：500以下"
                + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：900 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {900 * (TotalDay.Days + 1) / NMSL}元 "
                + Environment.NewLine + $"應納稅額：{900 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "501-600")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：601-1200"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：1080 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {1080 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{1080 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "601-1200")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：601-1200"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：1800 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {1800 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{1800 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1201-1800")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1201-1800"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：2700 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {2700 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{2700 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1801-2400")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1801-2400"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：3600 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {3600 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{3600 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "2401-3000/138HP以下(140,1PS以下)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：2401-3000/138HP以下(140,1PS以下)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：4500 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {4500 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{4500 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "3001-3600")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：3601-4200/138.1-200HP(140.2-230.0PS)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：5400 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {5400 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{5400 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "3601-4200/138.1-200HP(140.2-230.0PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：3601-4200/138.1-200HP(140.2-230.0PS)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：6300 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {6300 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{6300 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "4201-4800")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：4201-4800"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：6300 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {6300 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{6300 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "4801-5400/200.1-247HP(203.1-250..7PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：4801-5400/200.1-247HP(203.1-250..7PS)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：8100 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {8100 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{8100 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "5401-6000")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：5401-6000"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：9000 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {9000 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{9000 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "6001-6600/247.1-286HP(250.8-290.3PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：6001-6600/247.1-286HP(250.8-290.3PS)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：9900 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {9900 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{9900 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "6601-7200")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：6601-7200"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：10800 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {10800 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{10800 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "7201-7800/286.1-336HP(290.4-341.0PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：7201-7800/286.1-336HP(290.4-341.0PS)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：11700 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {11700 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{11700 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "7801-8400")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：7801-8400"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：12600 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {12600 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{12600 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "8401-9000/336.1-361HP(341.1-366.4PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：8401-9000/336.1-361HP(341.1-366.4PS)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：13500 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {13500 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{13500 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "9001-9600")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：9001-9600"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：14400 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {14400 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{14400 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "9601-10200/361.1HP以上(366.5PS以上)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：9601-10200/361.1HP以上(366.5PS以上)"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：15300 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {15300 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{15300 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "10201以上")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：10201以上"
                       + Environment.NewLine + "用途：貨車" + Environment.NewLine + $"計算公式：16200 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {16200 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{16200 * (TotalDay.Days + 1) / NMSL}元";
                }

            //----------------大客車----------------//
            if (this.comboBox_Type.Text == "大客車")
                if (this.comboBox_CC.Text == "600以下")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                    + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：600以下"
                    + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：1080 * {TotalDay.Days + 1 / 365} / {365} = {1080 * (TotalDay.Days + 1) / 365}元 "
                    + Environment.NewLine + $"應納稅額：{1080 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "601-1200")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：601-1200"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：1800 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {1800 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{1800 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1201-1800")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1201-1800"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：2700 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {2700 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{2700 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1801-2400")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1801-2400"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：3600 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {3600 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{3600 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "2401-3000/138HP以下(140,1PS以下)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：2401-3000/138HP以下(140,1PS以下)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：4500 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {4500 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{4500 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "3001-3600")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：3601-4200/138.1-200HP(140.2-230.0PS)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：5400 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {5400 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{5400 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "3601-4200/138.1-200HP(140.2-230.0PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：3601-4200/138.1-200HP(140.2-230.0PS)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：6300 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {6300 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{6300 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "4201-4800")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：4201-4800"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：6300 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {6300 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{6300 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "4801-5400/200.1-247HP(203.1-250..7PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：4801-5400/200.1-247HP(203.1-250..7PS)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：8100 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {8100 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{8100 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "5401-6000")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：5401-6000"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：9000 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {9000 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{9000 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "6001-6600/247.1-286HP(250.8-290.3PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：6001-6600/247.1-286HP(250.8-290.3PS)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：9900 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {9900 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{9900 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "6601-7200")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：6601-7200"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：10800 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {10800 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{10800 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "7201-7800/286.1-336HP(290.4-341.0PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：7201-7800/286.1-336HP(290.4-341.0PS)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：11700 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {11700 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{11700 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "7801-8400")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：7801-8400"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：12600 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {12600 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{12600 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "8401-9000/336.1-361HP(341.1-366.4PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：8401-9000/336.1-361HP(341.1-366.4PS)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：13500 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {13500 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{13500 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "9001-9600")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：9001-9600"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：14400 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {14400 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{14400 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "9601-10200/361.1HP以上(366.5PS以上)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：9601-10200/361.1HP以上(366.5PS以上)"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：15300 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {15300 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{15300 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "10201以上")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：10201以上"
                       + Environment.NewLine + "用途：大客車" + Environment.NewLine + $"計算公式：16200 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {16200 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{16200 * (TotalDay.Days + 1) / NMSL}元";
                }

            //--------------自用小客車--------------//
            if (this.comboBox_Type.Text == "自用小客車")
                if (this.comboBox_CC.Text == "500以下/38HP以下(38.6PS以下)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                    + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：500以下/38HP以下(38.6PS以下)"
                    + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：1620 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {1620 * (TotalDay.Days + 1) / NMSL}元 "
                    + Environment.NewLine + $"應納稅額：{1620 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "501-600/38.1-56HP(38.7-56.8PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：501-600/38.1-56HP(38.7-56.8PS)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：2160 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {2160 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{2160 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "601-1200/56.1-83HP(56.9-84.2PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：601-1200/56.1-83HP(56.9-84.2PS)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：4320 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {4320 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{4320 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1201-1800/83.1-182HP(184.8-265.9PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1201-1800/83.1-182HP(184.8-265.9PS)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：7120 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {7120 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{7120 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1801-2400/182.1-262HP(184.8-265.9PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1801-2400/182.1-262HP(184.8-265.9PS)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：11230 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {11230 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{11230 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "2401-3000/262.1-322HP(266-326.8HP)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：2401-3000/262.1-322HP(266-326.8HP)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：15210 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {15210 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{15210 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "3001-4200/322.1-414HP(326.9-420.2PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：3001-4200/322.1-414HP(326.9-420.2PS)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：28220 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {28220 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{28220 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "4201-5400/414.1-469HP(420.3-476.0PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：4201-5400/414.1-469HP(420.3-476.0PS)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：46170 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {46170 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{46170 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "5401-6600/469.1-509HP(476.1-516.6PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：5401-6600/469.1-509HP(476.1-516.6PS)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：69690 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {69690 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{69690 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "6601-7800/509.1HP以上(516.7ps以上)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：6601-7800/509.1HP以上(516.7ps以上)"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：117000 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {117000 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{117000 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "7801以上")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：7801以上"
                       + Environment.NewLine + "用途：自用小客車" + Environment.NewLine + $"計算公式：151200 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {151200 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{151200 * (TotalDay.Days + 1) / NMSL}元";
                }

            //-------------營業用小客車-------------//
            if (this.comboBox_Type.Text == "營業用小客車")
                if (this.comboBox_CC.Text == "500以下/38HP以下(38.6PS以下)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                    + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：500以下/38HP以下(38.6PS以下)"
                    + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：900 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {900 * (TotalDay.Days + 1) / NMSL}元 "
                    + Environment.NewLine + $"應納稅額：{900 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "501-600/38.1-56HP(38.7-56.8PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：501-600/38.1-56HP(38.7-56.8PS)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：1260 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {1260 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{1260 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "601-1200/56.1-83HP(56.9-84.2PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：601-1200/56.1-83HP(56.9-84.2PS)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：2160 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {2160 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{2160 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1201-1800/83.1-182HP(184.8-265.9PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1201-1800/83.1-182HP(184.8-265.9PS)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：3060 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {3060 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{3060 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "1801-2400/182.1-262HP(184.8-265.9PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：1801-2400/182.1-262HP(184.8-265.9PS)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：6480 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {6480 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{6480 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "2401-3000/262.1-322HP(266-326.8HP)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：2401-3000/262.1-322HP(266-326.8HP)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：9900 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {9900 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{9900 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "3001-4200/322.1-414HP(326.9-420.2PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：3001-4200/322.1-414HP(326.9-420.2PS)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：16380 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {16380 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{16380 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "4201-5400/414.1-469HP(420.3-476.0PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：4201-5400/414.1-469HP(420.3-476.0PS)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：24300 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {24300 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{24300 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "5401-6600/469.1-509HP(476.1-516.6PS)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：5401-6600/469.1-509HP(476.1-516.6PS)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：69690 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {69690 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{69690 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "6601-7800/509.1HP以上(516.7ps以上)")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：6601-7800/509.1HP以上(516.7ps以上)"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：33660 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {33660 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{33660 * (TotalDay.Days + 1) / NMSL}元";
                }
                else if (this.comboBox_CC.Text == "7801以上")
                {
                    this.OutputList.Text = $"使用期間：{dateTimePicker1.Value.ToString("yyyy/MM/dd")} ~ {dateTimePicker2.Value.ToString("yyyy/MM/dd")}"
                       + Environment.NewLine + $"計算天數：{TotalDayData}" + Environment.NewLine + "汽缸CC數：7801以上"
                       + Environment.NewLine + "用途：營業用小客車" + Environment.NewLine + $"計算公式：56700 * {TotalDay.Days + 1 / NMSL} / {NMSL} = {56700 * (TotalDay.Days + 1) / NMSL}元 "
                       + Environment.NewLine + $"應納稅額：{56700 * (TotalDay.Days + 1) / NMSL}元";
                }

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Init()
        {
            this.comboBox_Type.SelectedIndex = 0;
            this.comboBox_CC.SelectedIndex = 0;
            this.OutputList.Text = "";
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void OutputList_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
