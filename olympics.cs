using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奥运会
{
    public class SportEvent
    {
        public int SerialNumber;//项目编号
        public int serialNumber
        {
            set { SerialNumber = value; }
            get { return SerialNumber; }
        }
        public int AwardNum;//获得奖项的个数，3个或者5个
        public int awardNum
        {
            set { AwardNum = value; }
            get { return AwardNum; }
        }
        public bool BoyOrGirl;//0:男子项目，1：女子项目
        public bool boyOrGirl
        {
            set { BoyOrGirl = value; }
            get { return BoyOrGirl; }
        }
        public int[] AwardList = { 0, 0, 0, 0, 0 };
        public int[] awardList
        {
            set { AwardList = value; }
            get { return AwardList; }
        }
        public SportEvent(int sn, int an, bool bg, int[] al)
        {
            SerialNumber = sn;
            AwardNum = an;
            BoyOrGirl = bg;
            AwardList = al;
        }
        public SportEvent() { }
    }
    public class CountryScore
    {
        public int Num;//国家编号
        public int Score;//国家总分
        public int MenScore;//国家男子团体总分
        public int WomenScore;//国家女子团体总分
        public int[] AllScore;
        public string Print()
        {
            string str = "**";
            str = str + "国家编号:" + Num.ToString() + "\r\n";
            str = str + "   国家总分:" + Score.ToString() + "\r\n";
            str = str + "   国家男子团体总分:" + MenScore.ToString() + "\r\n";
            str = str + "   国家女子团体总分:" + WomenScore.ToString()+"\r\n" + "\r\n";
            return str;
        }
    }
    public class olympics
    {
        public int MenSport;//男子项目的个数
        public int WomenSport;//女子项目的个数
        public int NumCountry;//国家的数目
        public int numCountry
        {
            set { NumCountry = value; }
            get { return NumCountry; }
        }
        public SportEvent[] SeList;
        public olympics()
        {
            
        }
        //初始化各个比赛项目的信息
        public olympics( int[] an, bool[] bg, int[][] al)
        {
            //SeList = new SportEvent[MenSport + WomenSport];
            int i = 0;
            for (i = 0; i < MenSport + WomenSport; i++)
            {
                SeList[i].SerialNumber = i;
                SeList[i].AwardNum = an[i];
                SeList[i].BoyOrGirl = bg[i];
                SeList[i].AwardList = al[i];
            }
        }
        //统计各个国家的总分,男/女子团体总分,0:男子，1：女子，2:总分
        public void ScoreOfCountry(ref int[] score, int MenOrWomen)
        {
            score = new int[NumCountry];
            //遍历所有的项目
            int i = 0;
            for (i = 0; i < MenSport + WomenSport; i++)
            {
                if (MenOrWomen == 2)
                {
                    if (SeList[i].AwardNum == 5)
                    {//得分为7 5 3 2 1
                        score[SeList[i].AwardList[0]] += 7;
                        score[SeList[i].AwardList[1]] += 5;
                        score[SeList[i].AwardList[2]] += 3;
                        score[SeList[i].AwardList[3]] += 2;
                        score[SeList[i].AwardList[4]] += 1;
                    }
                    else if (SeList[i].AwardNum == 3)
                    {
                        score[SeList[i].AwardList[0]] += 5;
                        score[SeList[i].AwardList[1]] += 3;
                        score[SeList[i].AwardList[2]] += 2;
                    }
                }
                else
                {
                    if ((SeList[i].BoyOrGirl == false && MenOrWomen == 0) || (SeList[i].BoyOrGirl == true && MenOrWomen == 1))
                    {
                        if (SeList[i].AwardNum == 5)
                        {//得分为7 5 3 2 1
                            score[SeList[i].AwardList[0]] += 7;
                            score[SeList[i].AwardList[1]] += 5;
                            score[SeList[i].AwardList[2]] += 3;
                            score[SeList[i].AwardList[3]] += 2;
                            score[SeList[i].AwardList[4]] += 1;
                        }
                        else if (SeList[i].AwardNum == 3)
                        {
                            score[SeList[i].AwardList[0]] += 5;
                            score[SeList[i].AwardList[1]] += 3;
                            score[SeList[i].AwardList[2]] += 2;
                        }
                    }
                }
            }
        }
        public CountryScore[] Cs;
        //初始化各个国家的信息
        public void InitCountry()
        {
            Cs = new CountryScore[NumCountry];
            int[] score, menscore, womenscore;
            score = new int[NumCountry];
            menscore = new int[NumCountry];
            womenscore = new int[NumCountry];
            ScoreOfCountry(ref score, 2);
            ScoreOfCountry(ref menscore, 0);
            ScoreOfCountry(ref womenscore, 1);
            int i = 0;
            int j = 0;
            for (i = 0; i < NumCountry; i++)
            {
                Cs[i] = new CountryScore();
                Cs[i].Num = i + 1;
                Cs[i].Score = score[i];
                Cs[i].MenScore = menscore[i];
                Cs[i].WomenScore = womenscore[i];
                Cs[i].AllScore = new int[MenSport+WomenSport];
                for (j = 0; j < MenSport + WomenSport; j++)
                {
                    Cs[i].AllScore[j] = 0;
                }

            }
            for(i=0;i< MenSport+WomenSport;i++ )
            {
                if(SeList[i].AwardNum==5)
                {
                    Cs[SeList[i].AwardList[0]].AllScore[i] = 1;
                    Cs[SeList[i].AwardList[1]].AllScore[i] = 2;
                    Cs[SeList[i].AwardList[2]].AllScore[i] = 3;
                    Cs[SeList[i].AwardList[3]].AllScore[i] = 4;
                    Cs[SeList[i].AwardList[4]].AllScore[i] = 5;

                }
                else if(SeList[i].AwardNum ==3)
                {
                    Cs[SeList[i].AwardList[0]].AllScore[i] = 1;
                    Cs[SeList[i].AwardList[1]].AllScore[i] = 2;
                    Cs[SeList[i].AwardList[2]].AllScore[i] = 3;
                }
            }
        }
        //按照各国编号、各国总分、男女团体总分排序输出,
        //gist:0:各国编号,1:各国总分,2:男子团体总分，3：女子团体总分
        public string SortPrint(int gist)
        {
            //InitCountry();
            int[] sort = new int[NumCountry ];
            string str = "";
            int i = 0;
            for(i=0;i<NumCountry;i++)
            {
                sort[i] = i;
            }
            int j = 0, tmp = 0;
            if (gist != 0)
            {
                for (i = 0; i < NumCountry; i++)
                {
                    for (j = 0; j < NumCountry - i-1; j++)
                    {
                        if ((Cs[sort[j]].Score < Cs[sort[j + 1]].Score && gist == 1) || (Cs[sort[j]].MenScore < Cs[sort[j + 1]].MenScore && gist == 2) || (Cs[sort[j]].WomenScore < Cs[sort[j + 1]].WomenScore && gist == 3))
                        {
                            tmp = sort[j];
                            sort[j] = sort[j + 1];
                            sort[j + 1] = tmp;
                        }
                    }
                }
            }
            for(i=0;i< NumCountry; i++)
            {
                str = str + Cs[sort[i]].Print();
            }
            return str;
        }        
    }
}