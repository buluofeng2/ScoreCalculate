using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 奥运会
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        olympics ol=new olympics() ;
        int iSportNUm = 0;
        //提交项目规模时
        private void btnNum_Click(object sender, EventArgs e)
        {
            int NumCountry, NumMen, NumWomen;
            NumCountry = Convert.ToInt32(mtxtNumCountry.Text .ToString());
            NumMen = Convert.ToInt32(mtxtNumMen.Text.ToString());
            NumWomen = Convert.ToInt32(mtxtNumWomen.Text.ToString());
            ol.NumCountry = NumCountry;
            ol.MenSport = NumMen;
            ol.WomenSport = NumWomen;
            
            ol.SeList = new SportEvent[ol.MenSport + ol.WomenSport];
            int i = 0;
            for (i = 0; i < ol.MenSport + ol.WomenSport; i++)
            {
                ol.SeList[i] = new SportEvent();
                if (i < ol.MenSport) ol.SeList[i].BoyOrGirl = false;
                else ol.SeList[i].BoyOrGirl = true;
            }

            iSportNUm = 0;
            btnFinished.Visible = false;
            btnPre.Visible = false;
            btnNext.Visible = true;
            lblGender.Text = "男子项目";
            lblSportNum.Text = "比赛项目" + (iSportNUm+1).ToString ();
            
            NumAward1.Minimum = 1; NumAward1.Maximum = NumCountry;
            NumAward2.Minimum = 1; NumAward2.Maximum = NumCountry;
            NumAward3.Minimum = 1; NumAward3.Maximum = NumCountry;
            NumAward4.Minimum = 1; NumAward4.Maximum = NumCountry;
            NumAward5.Minimum = 1; NumAward5.Maximum = NumCountry;

            FindNumCountry1.Minimum = 1; FindNumCountry1.Maximum = NumCountry;
            FindNumEvent1.Minimum = 1; FindNumEvent1.Maximum = ol.MenSport +ol.WomenSport ;
            FindNumEvent2.Minimum = 1; FindNumEvent2.Maximum = ol.MenSport + ol.WomenSport;
        }
        //选择项目的获奖人数发生改变时
        private void rbtnAwardNum_CheckedChanged(object sender, EventArgs e)
        {
            lblAward4.Visible = false;
            lblAward5.Visible = false;
            NumAward4.Visible = false;
            NumAward5.Visible = false;
        }
        private void rbtnAwardNUm2_CheckedChanged(object sender, EventArgs e)
        {
            lblAward4.Visible = true;
            lblAward5.Visible = true;
            NumAward4.Visible = true;
            NumAward5.Visible = true;
        }

        //选择下一个项目信息进行录入
        private void btnNext_Click(object sender, EventArgs e)
        {                   
            if (rbtnAwardNum3.Checked == true) ol.SeList[iSportNUm].AwardNum = 3;
            else ol.SeList[iSportNUm].AwardNum = 5;
            if(ol.SeList[iSportNUm].AwardNum == 5)
            {
                ol.SeList[iSportNUm].AwardList[0] = (int)NumAward1.Value - 1;
                ol.SeList[iSportNUm].AwardList[1] = (int)NumAward2.Value - 1;
                ol.SeList[iSportNUm].AwardList[2] = (int)NumAward3.Value - 1;
                ol.SeList[iSportNUm].AwardList[3] = (int)NumAward4.Value - 1;
                ol.SeList[iSportNUm].AwardList[4] = (int)NumAward5.Value - 1;
            }
            else
            {
                ol.SeList[iSportNUm].AwardList[0] = (int)NumAward1.Value - 1;
                ol.SeList[iSportNUm].AwardList[1] = (int)NumAward2.Value - 1;
                ol.SeList[iSportNUm].AwardList[2] = (int)NumAward3.Value - 1;
                
            }
            iSportNUm++;
            lblSportNum.Text = "比赛项目" + (iSportNUm + 1).ToString();
            if (ol.SeList[iSportNUm].BoyOrGirl == false) lblGender.Text = "男子项目";
            else lblGender.Text = "女子项目";
            NumAward1.Value = 1;
            NumAward2.Value = 1;
            NumAward3.Value = 1;
            NumAward4.Value = 1;
            NumAward5.Value = 1;
            btnFinished.Visible = false;
            btnNext.Visible = true;
            btnPre.Visible = true;
            if (iSportNUm == (ol.MenSport + ol.WomenSport - 1))
            {
                btnNext.Visible = false;
                btnFinished.Visible = true;
            }
            
        }
        //选择上一个项目信息进行录入
        private void btnPre_Click(object sender, EventArgs e)
        {
            NumAward1.Value = 1;
            NumAward2.Value = 1;
            NumAward3.Value = 1;
            NumAward4.Value = 1;
            NumAward5.Value = 1;
            iSportNUm--;
            lblSportNum.Text = "比赛项目" + (iSportNUm+1).ToString();
            if (ol.SeList[iSportNUm].BoyOrGirl == false) lblGender.Text = "男子项目";
            else lblGender.Text = "女子项目";
            btnFinished.Visible = false;
            btnNext.Visible = true;
            btnPre.Visible = true;
            if (iSportNUm == 0) btnPre.Visible = false;
        }
        //打印顺序选择发生改变时
        private void cboxPrintAccord_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=cboxPrintAccord.SelectedIndex;
            string str=ol.SortPrint(index);
            txtPrint.Text = str;// index.ToString();
        }
        //完成信息录入
        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (rbtnAwardNum3.Checked == true) ol.SeList[iSportNUm].AwardNum = 3;
            else ol.SeList[iSportNUm].AwardNum = 5;
            if (ol.SeList[iSportNUm].AwardNum == 5)
            {
                ol.SeList[iSportNUm].AwardList[0] = (int)NumAward1.Value-1;
                ol.SeList[iSportNUm].AwardList[1] = (int)NumAward2.Value-1;
                ol.SeList[iSportNUm].AwardList[2] = (int)NumAward3.Value - 1;
                ol.SeList[iSportNUm].AwardList[3] = (int)NumAward4.Value - 1;
                ol.SeList[iSportNUm].AwardList[4] = (int)NumAward5.Value - 1;
            }
            else
            {                
                //ol.SeList[iSportNUm].AwardList[2] = Convert.ToInt32(mtxtAward3.Text.ToString()) - 1;
                ol.SeList[iSportNUm].AwardList[0] = (int)NumAward1.Value - 1;
                ol.SeList[iSportNUm].AwardList[1] = (int)NumAward2.Value - 1;
                ol.SeList[iSportNUm].AwardList[2] = (int)NumAward3.Value - 1;
            }
            ol.InitCountry();
            string str = ol.SortPrint(0);
            txtPrint.Text = str;// index.ToString();
        }
        //窗体加载时
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrint.ForeColor = Color.Red;
            rbtnAwardNum3.Checked = true;
        }

        private void FindNumCountry1_ValueChanged(object sender, EventArgs e)
        {
            int nc = (int)FindNumCountry1.Value,ne=(int)FindNumEvent1.Value ;
            if(ol.Cs[nc-1].AllScore[ne-1]==0)
            {
                txtScore1.Text = "很遗憾!未获奖!!!";
            }
            else
            {
                txtScore1.Text = "恭喜！获得第"+ ol.Cs[nc - 1].AllScore[ne - 1].ToString ()+"名！";
            }
        }

        private void FindNumEvent1_ValueChanged(object sender, EventArgs e)
        {
            int nc = (int)FindNumCountry1.Value, ne = (int)FindNumEvent1.Value;
            if (ol.Cs[nc - 1].AllScore[ne - 1] == 0)
            {
                txtScore1.Text = "很遗憾!未获奖!!!";
            }
            else
            {
                txtScore1.Text = "恭喜！获得第" + ol.Cs[nc - 1].AllScore[ne - 1].ToString() + "名！";
            }
        }

        private void FindNumEvent2_ValueChanged(object sender, EventArgs e)
        {
            int  ne = (int)FindNumEvent2.Value, nArea = ol.SeList[ne - 1].awardNum;
            string str = "项目" + ne.ToString() + "共有" + nArea.ToString() + "个国家获奖！\r\n";          
            int i = 0;
            for(i=0;i<nArea;i++)
            {
                str = str + "第" + (i + 1).ToString() + "名:国家" + (ol.SeList[ne - 1].AwardList[i]+1).ToString()+"\r\n"; 
            }
            txtScore2.Text = str;
        }
    }
}
