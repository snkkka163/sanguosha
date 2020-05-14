using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 三国杀
{
    public partial class pvp : Form
    {
        public pvp()
        {
            InitializeComponent();
        }

        int index;//获取我方角色索引
        int drindex;//获取敌人角色索引
        Random rd = new Random();

        //敌方角色随机事件
        public void juese1() {
            int index1 = rd.Next(0, 3);
            drindex = index1;//成员变量获取敌人角色索引
            if (index1 != index)
            {
                MessageBox.Show("第一次判断");
                MessageBox.Show(index1.ToString());
                this.pvp1juese1.BackgroundImage = Jueseimages.Images[index1];
            }
            else {
                for (int i = 0; i <= 2; i++) {
                    if (i != index) {
                        MessageBox.Show(i.ToString());
                        this.pvp1juese1.BackgroundImage = Jueseimages.Images[i];
                        drindex = i;
                    }
                }
            }
        }
        //游戏开始方法
        public void start() {
            juese1();
            this.js1.Hide();
            this.js2.Hide();
            this.js3.Hide();
            this.pvp1juese1.Show();
            this.pvp1juese2.Show();
            this.qdan.Show();
            this.PB.Show();
            this.mesm.Show();
            this.juese1kpcount.Show();
            this.metime.Enabled = true;
            this.timehelp.Show();
            this.jqrkp.Show();
            this.qdan.Show();
        }

        //机器人出牌
        int drpai1 = -1;
        int drpai2 = -1;
        int drpai3 = -1;
        int drpai4 = -1;
        int kpnum = 4;//初始化敌对实时卡牌数量
        //机器人卡牌初始化
        public void startkps() {
            this.juese1kpcount.Text = "当前敌人手牌数:" + kpnum;
            int pai1 = rd.Next(1, 1);

            //基础牌判断
            int indexkpjcs1 = rd.Next(0, 2);
            int indexkpjcs2 = rd.Next(0, 2);
            int indexkpjcs3 = rd.Next(0, 2);
            int indexkpjcs4 = rd.Next(0, 2);
            //锦囊牌判断
            int indexkpjns1 = rd.Next(4, 14);
            int indexkpjns2 = rd.Next(4, 14);
            int indexkpjns3 = rd.Next(4, 14);
            int indexkpjns4 = rd.Next(4, 14);
            //装备牌
            int indexkpzb1 = rd.Next(15, 27);
            int indexkpzb2 = rd.Next(15, 27);
            int indexkpzb3 = rd.Next(15, 27);
            int indexkpzb4 = rd.Next(15, 27);
            //所有总牌的随机数
            int indexkp1 = rd.Next(1, 160);
            int indexkp2 = rd.Next(1, 160);
            int indexkp3 = rd.Next(1, 160);
            int indexkp4 = rd.Next(1, 160);

            
            //敌人第一牌的地址
            //初始化第一张牌
            if (indexkp1 >= 0 && indexkp1 <= 85)
            {
                drpai1 = 20;//将drpai1变量的值等于机器人本张基础牌的下标
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjcs1];
            }
            else if (indexkp1 >= 86 && indexkp1 <= 145)
            {
                drpai1 = 20;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjns1];
            }
            else
            {
                drpai1 = 20;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpzb1];
            }

            //初始化第二张牌
            if (indexkp2 >= 0 && indexkp2 <= 85)
            {
                drpai2 = indexkpjcs2;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjcs2];
            }
            else if (indexkp1 >= 86 && indexkp1 <= 145)
            {
                drpai2 = indexkpjcs2;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjns2];
            }
            else
            {
                drpai2 = indexkpzb2;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpzb2];
            }

            //初始化第三张牌
            if (indexkp3 >= 0 && indexkp3 <= 85)
            {
                drpai3 = indexkpjcs3;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjcs3];
            }
            else if (indexkp1 >= 86 && indexkp1 <= 145)
            {
                drpai3 = indexkpjcs3;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjns3];
            }
            else
            {
                drpai3 = indexkpzb3;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpzb3];
            }

            //初始化第四张牌
            if (indexkp4 >= 0 && indexkp4 <= 85)
            {
                drpai4 = indexkpjcs4;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjcs4];
            }
            else if (indexkp1 >= 86 && indexkp1 <= 145)
            {
                drpai4 = indexkpjcs4;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjns4];
            }
            else
            {
                drpai4 = indexkpzb4;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpzb4];
            }
            
        }

        //该方法判断敌人出的装备牌ID然后减少手牌总数量
        public void zhuangbeiId(int a) {
            if (drpai1 == a)
            {
                drpai1 = -1;
                kpnum--;
            }
            else if (drpai2 == a)
            {
                drpai2 = -1;
                kpnum--;
            }
            else if (drpai3 == a)
            {
                drpai3 = -1;
                kpnum--;
            }
            else if (drpai4 == a)
            {
                drpai4 = -1;
                kpnum--;
            }
        }

        string depart;//人每回合出的牌
        //机器人判断玩家的出牌情况出牌
        int blood = 0;//机器人血量判断
        public void jqrchupai(string wjcp) //参数为玩家出牌
        {
            try
            {
                
                #region 玩家出杀
                if (wjcp.Equals("杀"))
                {
                    if (wjcp.Equals("杀") && (drpai1 == 1 || drpai2 == 1 || drpai3 == 1 || drpai4 == 1))//人出杀且人机有闪
                    {
                        this.jqrkp.BackgroundImage = kapaiimages.Images[1];//如果人出杀机器人有闪就出
                        if (drpai1 == 1) 
                        {
                            drpai1 = -1;//机器人这张牌丢失
                            kpnum--;
                        }
                        else if (drpai2 == 1) 
                        {
                            drpai2 = -1;
                            kpnum--;
                        }
                        else if (drpai3 == 1)
                        {
                            drpai3 = -1;
                            kpnum--;
                        }
                        else if (drpai4 == 1)
                        {
                            drpai4 = -1;
                            kpnum--;
                        }
                    }
                    else
                    {
                        //如果机器人不出杀,那就扣血
                        //判断机器人是什么英雄再进行扣血操作
                        MessageBox.Show(index.ToString());

                        //如果英雄已经剩下三滴血了
                        if (drindex == 0 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[11];
                        }
                        else if (drindex == 1 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[8];
                        }
                        else if (drindex == 2 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[5];
                        }
                        else if (drindex == 0 && blood == 3)
                        {//曹操
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[10];
                            blood = 2;
                        }
                        else if (drindex == 1 && blood == 3)
                        {//孙权
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[7];
                            blood = 2;
                        }
                        else if (drindex == 2 && blood == 3)
                        {//刘备
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[4];
                            blood = 2;
                        }
                        else if (drindex == 0)
                        {//曹操
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[9];
                            blood = 3;
                        }
                        else if (drindex == 1)
                        {//孙权
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[6];
                            blood = 3;
                        }
                        else if (drindex == 2)
                        {//刘备
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[3];
                            blood = 3;
                        }
                    }
                }
                #endregion
                #region 玩家发动万箭齐发
                if (wjcp.Equals("万箭齐发"))
                {
                    if (wjcp.Equals("万箭齐发") && (drpai1 == 1 || drpai2 == 1 || drpai3 == 1 || drpai4 == 1))//人出杀且人机有闪
                    {
                        this.jqrkp.BackgroundImage = kapaiimages.Images[1];//如果人出杀机器人有闪就出

                        if (drpai1 == 1)
                        {
                            drpai1 = -1;//机器人这张牌丢失
                            kpnum--;
                        }
                        else if (drpai2 == 1)
                        {
                            drpai2 = -1;
                            kpnum--;
                        }
                        else if (drpai3 == 1)
                        {
                            drpai3 = -1;
                            kpnum--;
                        }
                        else if (drpai4 == 1)
                        {
                            drpai4 = -1;
                            kpnum--;
                        }
                    }
                    else
                    {
                        //如果机器人不出杀,那就扣血
                        //判断机器人是什么英雄再进行扣血操作
                        MessageBox.Show(index.ToString());

                        //如果英雄已经剩下三滴血了
                        if (drindex == 0 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[11];
                        }
                        else if (drindex == 1 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[8];
                        }
                        else if (drindex == 2 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[5];
                        }
                        else if (drindex == 0 && blood == 3)
                        {//曹操
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[10];
                            blood = 2;
                        }
                        else if (drindex == 1 && blood == 3)
                        {//孙权
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[7];
                            blood = 2;
                        }
                        else if (drindex == 2 && blood == 3)
                        {//刘备
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[4];
                            blood = 2;
                        }
                        else if (drindex == 0)
                        {//曹操
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[9];
                            blood = 3;
                        }
                        else if (drindex == 1)
                        {//孙权
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[6];
                            blood = 3;
                        }
                        else if (drindex == 2)
                        {//刘备
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[3];
                            blood = 3;
                        }
                    }
                }
                #endregion
                #region 玩家发动南蛮入侵
                if (wjcp.Equals("南蛮入侵"))
                {
                    if (wjcp.Equals("南蛮入侵") && (drpai1 == 0 || drpai2 == 0 || drpai3 == 0 || drpai4 == 0))//人出杀且人机有杀
                    {
                        this.jqrkp.BackgroundImage = kapaiimages.Images[0];//如果人出杀机器人有杀就出

                        if (drpai1 == 0)
                        {
                            drpai1 = -1;//机器人这张牌丢失
                            kpnum--;
                        }
                        else if (drpai2 == 0)
                        {
                            drpai2 = -1;
                            kpnum--;
                        }
                        else if (drpai3 == 0)
                        {
                            drpai3 = -1;
                            kpnum--;
                        }
                        else if (drpai4 == 0)
                        {
                            drpai4 = -1;
                            kpnum--;
                        }
                    }
                    else
                    {
                        //如果机器人不出杀,那就扣血
                        //判断机器人是什么英雄再进行扣血操作
                        MessageBox.Show(index.ToString());

                        //如果英雄已经剩下三滴血了
                        if (drindex == 0 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[11];
                        }
                        else if (drindex == 1 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[8];
                        }
                        else if (drindex == 2 && blood == 2)
                        {
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[5];
                        }
                        else if (drindex == 0 && blood == 3)
                        {//曹操
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[10];
                            blood = 2;
                        }
                        else if (drindex == 1 && blood == 3)
                        {//孙权
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[7];
                            blood = 2;
                        }
                        else if (drindex == 2 && blood == 3)
                        {//刘备
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[4];
                            blood = 2;
                        }
                        else if (drindex == 0)
                        {//曹操
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[9];
                            blood = 3;
                        }
                        else if (drindex == 1)
                        {//孙权
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[6];
                            blood = 3;
                        }
                        else if (drindex == 2)
                        {//刘备
                            this.pvp1juese1.BackgroundImage = Jueseimages.Images[3];
                            blood = 3;
                        }
                    }
                }
                #endregion
                #region 玩家使用装备牌
                if (zhuangbeipai)
                {
                    if (wjcp.Equals("赤兔"))
                    {
                        this.mejianma.BackgroundImage = kapaiimages.Images[15];
                       zhuangbeiId(15);
                    }
                    else if (wjcp.Equals("骅骝"))
                    {
                        this.mejiama.BackgroundImage = kapaiimages.Images[16];
                        zhuangbeiId(16);
                    }
                    else if (wjcp.Equals("大苑"))
                    {
                        this.mejianma.BackgroundImage = kapaiimages.Images[19];
                        zhuangbeiId(19);
                    }
                    else if (wjcp.Equals("绝影"))
                    {
                        this.mejianma.BackgroundImage = kapaiimages.Images[20];
                        zhuangbeiId(20);
                    }
                    else if (wjcp.Equals("爪黄飞电"))
                    {
                        this.mejiama.BackgroundImage = kapaiimages.Images[24];
                        zhuangbeiId(24);
                    }
                    else if (wjcp.Equals("紫騂"))
                    {
                        this.mejianma.BackgroundImage = kapaiimages.Images[25];
                        zhuangbeiId(25);
                    }
                    else if (wjcp.Equals("八卦阵"))
                    {
                        this.mefangju.BackgroundImage = kapaiimages.Images[17];
                        zhuangbeiId(17);
                    }
                    else if (wjcp.Equals("白银狮子"))
                    {
                        this.mefangju.BackgroundImage = kapaiimages.Images[18];
                        zhuangbeiId(18);
                    }
                    else if (wjcp.Equals("青杠剑"))
                    {
                        this.mewuqi.BackgroundImage = kapaiimages.Images[21];
                        zhuangbeiId(21);
                    }
                    else if (wjcp.Equals("藤甲"))
                    {
                        this.mefangju.BackgroundImage = kapaiimages.Images[22];
                        zhuangbeiId(22);
                    }
                    else if (wjcp.Equals("诸葛连弩"))
                    {
                        this.mewuqi.BackgroundImage = kapaiimages.Images[23];
                        zhuangbeiId(23);
                    }
                    else if (wjcp.Equals("方天画戟"))
                    {
                        this.mewuqi.BackgroundImage = kapaiimages.Images[26];
                        zhuangbeiId(26);
                    }
                    else if (wjcp.Equals("麒麟弓"))
                    {
                        this.mewuqi.BackgroundImage = kapaiimages.Images[27];
                        zhuangbeiId(27);
                    }
                } 
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //玩家牌
        int wjpai1;
        int wjpai2;
        int wjpai3;
        int wjpai4;
       


        //玩家卡牌初始化
        public void startkp() {
            //基础牌判断
            int indexkpjcs1 = rd.Next(0, 2);
            int indexkpjcs2 = rd.Next(0, 2);
            int indexkpjcs3 = rd.Next(0, 2);
            int indexkpjcs4 = rd.Next(0, 2);
            //锦囊牌判断
            int indexkpjns1 = rd.Next(4, 14);
            int indexkpjns2 = rd.Next(4, 14);
            int indexkpjns3 = rd.Next(4, 14);
            int indexkpjns4 = rd.Next(4, 14);
            //装备牌
            int indexkpzb1 = rd.Next(15, 26);
            int indexkpzb2 = rd.Next(15, 26);
            int indexkpzb3 = rd.Next(15, 26);
            int indexkpzb4 = rd.Next(15, 26);
            //所有总牌的随机数
            int indexkp1 = rd.Next(1, 160);
            int indexkp2 = rd.Next(1, 160);
            int indexkp3 = rd.Next(1, 160);
            int indexkp4 = rd.Next(1, 160);

            //初始化第一张牌
            if (indexkp1 >= 0 && indexkp1 <= 85) {
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjcs1];
                wjpai1 = indexkpjcs1;
            }
            else if (indexkp1 >= 86 && indexkp1 <= 145)
            {
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpjns1];
                wjpai1 = indexkpjns1;
            }
            else {
                wjpai1 = indexkpzb1;
                this.kp1.BackgroundImage = kapaiimages.Images[indexkpzb1];
            }


            //初始化第二张牌
            if (indexkp2 >= 0 && indexkp2 <= 65)
            {
                this.kp2.BackgroundImage = kapaiimages.Images[indexkpjcs2];
                wjpai2 = indexkpjcs2;
            }
            else if (indexkp2 >= 66 && indexkp2 <= 85)
            {
                this.kp2.BackgroundImage = kapaiimages.Images[indexkpjns2];
                wjpai2 = indexkpjns2;
            }
            else
            {
                this.kp2.BackgroundImage = kapaiimages.Images[indexkpzb2];
                wjpai2 = indexkpzb2;
            }


            //初始化第三张牌
            if (indexkp3 >= 0 && indexkp3 <= 65)
            {
                this.kp3.BackgroundImage = kapaiimages.Images[indexkpjcs3];
                wjpai3 = indexkpjcs3;
            }
            else if (indexkp3 >= 66 && indexkp3 <= 85)
            {
                this.kp3.BackgroundImage = kapaiimages.Images[indexkpjns3];
                wjpai3 = indexkpjns3;
            }
            else
            {
                this.kp3.BackgroundImage = kapaiimages.Images[indexkpzb3];
                wjpai3 = indexkpzb3;
            }


            //初始化第四张牌
            if (indexkp4 >= 0 && indexkp4 <= 65)
            {
                this.kp4.BackgroundImage = kapaiimages.Images[indexkpjcs4];
                wjpai4 = indexkpjcs4;
            }
            else if (indexkp4 >= 66 && indexkp4 <= 85)
            {
                this.kp4.BackgroundImage = kapaiimages.Images[indexkpjns4];
                wjpai4 = indexkpjns4;
            }
            else
            {
                this.kp4.BackgroundImage = kapaiimages.Images[indexkpzb4];
                wjpai4 = indexkpzb4;
            }

            this.kp1.Show();
            this.kp2.Show();
            this.kp3.Show();
            this.kp4.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.pvp1juese1.Show();
            this.pvp1juese2.Show();
        }

        //窗体加载时先隐藏各控件
        private void pvp1_Load(object sender, EventArgs e)
        {
           //this.jqrkp.BackgroundImage = kapaiimages.Images[0];
                startkps();//初始化敌人手牌
                MessageBox.Show(drpai1.ToString());
                MessageBox.Show(drpai2.ToString());
                MessageBox.Show(drpai3.ToString());
                MessageBox.Show(drpai4.ToString());
            if (drpai1 == 0 || drpai2 == 0 || drpai3 == 0 || drpai4 == 0)
            {
                MessageBox.Show("人机有杀");
            }
            else
            {
                MessageBox.Show("本局人机没有杀");
            }


            MessageBox.Show("进入游戏成功，请选择您的角色");
            this.pvp1juese1.Hide();
            this.pvp1juese2.Hide();
            this.kp1.Hide();
            this.kp2.Hide();
            this.kp3.Hide();
            this.kp4.Hide();
            this.qdan.Hide();
            this.PB.Hide();
            this.mesm.Hide();
            this.juese1kpcount.Hide();
            this.timehelp.Hide();
            this.jqrkp.Hide();
            this.qdan.Hide();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            startkp();//执行卡牌初始化   
            index = 0;
            start();
            this.pvp1juese2.BackgroundImage = Jueseimages.Images[0];
        }//曹操

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            startkp();//执行卡牌初始化   
            index = 1;
            start();
            this.pvp1juese2.BackgroundImage = Jueseimages.Images[1];
        }//孙权

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            startkp();//执行卡牌初始化   
            index = 2;
            start();
            this.pvp1juese2.BackgroundImage = Jueseimages.Images[2];
        }//刘备


        int chupai = -1;
        int x;
        int y;
        int dj1 = 1;
        int dj2 = 1;
        int dj3 = 1;
        int dj4 = 1;
        //判断出牌
        private void kp1_Click(object sender, EventArgs e)
        {
            if (dj1 == 1)
            {
                #region 判断是否有多张牌进入预备状态(如果是那么只有当前进入其余撤销)
                if (dj2 == 2)
                {
                    kp2.Top += 10;
                    dj2 = 1;
                }
                if (dj3 == 2)
                {
                    kp3.Top += 10;
                    dj3 = 1;
                }
                if (dj4 == 2)
                {
                    kp4.Top += 10;
                    dj4 = 1;
                } 
                #endregion
                #region 判断玩家预备的牌再决定是否启用确定按钮
                if (wjpai1 != 1 && wjpai1 != 13)
                {
                    if (wjpai1 == 3 && kpnum != 0)
                    {
                        this.qdan.BackgroundImage = buttonstyle.Images[0];
                    }
                    else
                    {
                        this.qdan.BackgroundImage = buttonstyle.Images[1];
                    }
                    this.qdan.BackgroundImage = buttonstyle.Images[0];
                }
                else
                {
                    this.qdan.BackgroundImage = buttonstyle.Images[1];
                }
                #endregion
                kp1.Top -= 10;
                dj1 = 2;
                wjcp1();//判断玩家第一张牌的出牌情况
                chupai = 1;
                //如果玩家出的是杀一类那么开启确定按钮
            }
            else if(dj1==2){
                kp1.Top += 10;
                dj1 = 1;
                this.qdan.BackgroundImage = buttonstyle.Images[1];
            }
        }

        private void kp4_Click(object sender, EventArgs e)
        {
            #region 判断是否有多张牌进入预备状态(如果是那么只有当前进入其余撤销)
            if (dj2 == 2)
            {
                kp2.Top += 10;
                dj2 = 1;
            }
            if (dj3 == 2)
            {
                kp3.Top += 10;
                dj3 = 1;
            }
            if (dj1 == 2)
            {
                kp1.Top += 10;
                dj1 = 1;
            }
            #endregion
            #region 判断玩家预备的牌再决定是否启用确定按钮
            if (wjpai4 != 1 && wjpai4 != 13)
            {
                if (wjpai4 == 3 && kpnum != 0)
                {
                    this.qdan.BackgroundImage = buttonstyle.Images[0];
                }
                else
                {
                    this.qdan.BackgroundImage = buttonstyle.Images[1];
                }
                this.qdan.BackgroundImage = buttonstyle.Images[0];
            }
            else
            {
                this.qdan.BackgroundImage = buttonstyle.Images[1];
            }
            #endregion
            if (dj4 == 1)
            {
                kp4.Top -= 10;
                dj4 = 2;
                wjcp4();//判断玩家第四张牌的出牌情况
                chupai = 4;
            }
            else if (dj4 == 2)
            {
                kp4.Top += 10;
                dj4 = 1;
            }
        }

        private void kp3_Click(object sender, EventArgs e)
        {
            #region 判断是否有多张牌进入预备状态(如果是那么只有当前进入其余撤销)
            if (dj2 == 2)
            {
                kp2.Top += 10;
                dj2 = 1;
            }
            if (dj1 == 2)
            {
                kp1.Top += 10;
                dj1 = 1;
            }
            if (dj4 == 2)
            {
                kp4.Top += 10;
                dj4 = 1;
            }
            #endregion
            #region 判断玩家预备的牌再决定是否启用确定按钮
            if (wjpai3 != 1 && wjpai3 != 13)
            {
                if (wjpai3 == 3 && kpnum != 0)
                {
                    this.qdan.BackgroundImage = buttonstyle.Images[0];
                }
                else
                {
                    this.qdan.BackgroundImage = buttonstyle.Images[1];
                }
                this.qdan.BackgroundImage = buttonstyle.Images[0];
            }
            else
            {
                this.qdan.BackgroundImage = buttonstyle.Images[1];
            }
            #endregion

            if (dj3 == 1)
            {
                kp3.Top -= 10;
                dj3 = 2;
                wjcp3();//判断玩家第三张牌的出牌情况
                chupai = 3;
            }
            else if (dj3 == 2)
            {
                kp3.Top += 10;
                dj3 = 1;
            }
        }

        private void kp2_Click(object sender, EventArgs e)
        {
            #region 判断是否有多张牌进入预备状态(如果是那么只有当前进入其余撤销)
            if (dj1 == 2)
            {
                kp1.Top += 10;
                dj1 = 1;
            }
            if (dj3 == 2)
            {
                kp3.Top += 10;
                dj3 = 1;
            }
            if (dj4 == 2)
            {
                kp4.Top += 10;
                dj4 = 1;
            }
            #endregion
            #region 判断玩家预备的牌再决定是否启用确定按钮
            if (wjpai2 != 1 && wjpai2 != 13)
            {
                if (wjpai2 == 3 && kpnum != 0)
                {
                    this.qdan.BackgroundImage = buttonstyle.Images[0];
                }
                else
                {
                    this.qdan.BackgroundImage = buttonstyle.Images[1];
                }
                this.qdan.BackgroundImage = buttonstyle.Images[0];
            }
            else
            {
                this.qdan.BackgroundImage = buttonstyle.Images[1];
            }
            #endregion
            if (dj2 == 1)
            {
                kp2.Top -= 10;
                dj2 = 2;
                wjcp2();//判断玩家第二张牌的出牌情况
                chupai = 2;
            }
            else if (dj2 == 2)
            {
                kp2.Top += 10;
                dj2 = 1;
            }
        }
        //确定按钮事件
        private void quedin_Click(object sender, EventArgs e)
        {
            if (chupai == 1) {
              this.jqrkp.BackgroundImage = kp1.BackgroundImage;
              kp1.Hide();
            }
            if (chupai == 2) {
                this.jqrkp.BackgroundImage = kp2.BackgroundImage;
                kp2.Hide();
            }
            if (chupai == 3)
            {
                this.jqrkp.BackgroundImage = kp3.BackgroundImage;
                kp3.Hide();
            }
            if (chupai == 4)
            {
                this.jqrkp.BackgroundImage = kp4.BackgroundImage;
                kp4.Hide();
            }
            jqrchupai(depart);//判断人机出牌;
        }

        int timeS;
        private void metime_Tick(object sender, EventArgs e)
        {
            shoupainum = 0;
            numAdd();//让随机数每一秒都会发生变化
            //将回合结束时隐藏的控件重新启动
            if (this.PB.Value == 0) 
            {
                AddPai();//给玩家补牌
                this.timehelp.Show();
                this.PB.Show();//出牌时间到 换玩家出牌(进度条显示)
                this.qdan.Show();//出牌按钮显示
            }
            if (this.PB.Value < 100)
            {
                this.PB.Value += 5;
            }
            else 
            {
                jqrAddPai();//机器人补牌
                timeS++;
                this.timehelp.Hide();
                this.PB.Hide();//出牌时间到 换人机出牌(进度条隐藏)
                this.qdan.Hide();//出牌按钮隐藏
                jqrtime.Enabled = true;//开启人机出牌定时器
                if (jqrtimes==false)
                {
                    this.PB.Value = 0;//玩家模式恢复
                }

            }
        }

        private void PB_Click(object sender, EventArgs e)
        {

        }

        //玩家框里面第一张牌
        int borad;
        bool zhuangbeipai;//判断是否是装备牌且及其装备部位
        public void wjcp1() {
            borad = wjpai1;
            if (borad == 0) 
            {
                depart = "杀";
                zhuangbeipai = false;
            }
            else if (borad == 1)
            {
                depart = "闪";
                zhuangbeipai = false;
            }
            else if (borad == 2)
            {
                depart = "桃";
                zhuangbeipai = false;
            }
            else if (borad == 3)
            {
                depart = "兵粮寸断";
                zhuangbeipai = false;
            }
            else if (borad == 4)
            {
                depart = "过河拆桥";
                zhuangbeipai = false;
            }
            else if (borad == 5)
            {
                depart = "火攻";
                zhuangbeipai = false;
            }
            else if (borad == 6)
            {
                depart = "借刀杀人";
                zhuangbeipai = false;
            }
            else if (borad == 7)
            {
                depart = "乐不思蜀";
                zhuangbeipai = false;
            }
            else if (borad == 8)
            {
                depart = "南蛮入侵";
                zhuangbeipai = false;
            }
            else if (borad == 9)
            {
                depart = "万箭齐发";
                zhuangbeipai = false;
            }
            else if (borad == 10)
            {
                depart = "顺手牵羊";
                zhuangbeipai = false;
            }
            else if (borad == 11)
            {
                depart = "水淹七军";
                zhuangbeipai = false;
            }
            else if (borad == 12)
            {
                depart = "五谷丰登";
                zhuangbeipai = false;
            }
            else if (borad == 13)
            {
                depart = "无懈可击";
                zhuangbeipai = false;
            }
            else if (borad == 14)
            {
                depart = "无中生有";
                zhuangbeipai = false;
            }
            else if (borad == 15)
            {
                depart = "赤兔";
                zhuangbeipai = true;
            }
            else if (borad == 16)
            {
                depart = "骅骝";
                zhuangbeipai = true;
            }
            else if (borad == 17) 
            {
                depart = "八卦阵";
                zhuangbeipai = true;
            }
            else if (borad == 18)
            {
                depart = "白银狮子";
                zhuangbeipai = true;
            }
            else if (borad == 19)
            {
                depart = "大苑";
                zhuangbeipai = true;
            }
            else if (borad == 20)
            {
                depart = "绝影";
                zhuangbeipai = true;
            }
            else if (borad == 21)
            {
                depart = "青杠剑";
                zhuangbeipai = true;
            }
            else if (borad == 22)
            {
                depart = "藤甲";
                zhuangbeipai = true;
            }
            else if (borad == 23)
            {
                depart = "诸葛连弩";
                zhuangbeipai = true;
            }
            else if (borad == 24)
            {
                depart = "爪黄飞电";
                zhuangbeipai = true;
            }
            else if (borad == 25)
            {
                depart = "紫騂";
                zhuangbeipai = true;
            }
            else if (borad == 26)
            {
                depart = "方天画戟";
                zhuangbeipai = true;
            }
            else if (borad == 27)
            {
                depart = "麒麟弓";
                zhuangbeipai = true;
            }
        }

        public void wjcp2()
        {
            borad = wjpai2;
            if (borad == 0)
            {
                depart = "杀";
                zhuangbeipai = false;
            }
            else if (borad == 1)
            {
                depart = "闪";
                zhuangbeipai = false;
            }
            else if (borad == 2)
            {
                depart = "桃";
                zhuangbeipai = false;
            }
            else if (borad == 3)
            {
                depart = "兵粮寸断";
                zhuangbeipai = false;
            }
            else if (borad == 4)
            {
                depart = "过河拆桥";
                zhuangbeipai = false;
            }
            else if (borad == 5)
            {
                depart = "火攻";
                zhuangbeipai = false;
            }
            else if (borad == 6)
            {
                depart = "借刀杀人";
                zhuangbeipai = false;
            }
            else if (borad == 7)
            {
                depart = "乐不思蜀";
                zhuangbeipai = false;
            }
            else if (borad == 8)
            {
                depart = "南蛮入侵";
                zhuangbeipai = false;
            }
            else if (borad == 9)
            {
                depart = "万箭齐发";
                zhuangbeipai = false;
            }
            else if (borad == 10)
            {
                depart = "顺手牵羊";
                zhuangbeipai = false;
            }
            else if (borad == 11)
            {
                depart = "水淹七军";
                zhuangbeipai = false;
            }
            else if (borad == 12)
            {
                depart = "五谷丰登";
                zhuangbeipai = false;
            }
            else if (borad == 13)
            {
                depart = "无懈可击";
                zhuangbeipai = false;
            }
            else if (borad == 14)
            {
                depart = "无中生有";
                zhuangbeipai = false;
            }
            else if (borad == 15)
            {
                depart = "赤兔";
                zhuangbeipai = true;
            }
            else if (borad == 16)
            {
                depart = "骅骝";
                zhuangbeipai = true;
            }
            else if (borad == 17)
            {
                depart = "八卦阵";
                zhuangbeipai = true;
            }
            else if (borad == 18)
            {
                depart = "白银狮子";
                zhuangbeipai = true;
            }
            else if (borad == 19)
            {
                depart = "大苑";
                zhuangbeipai = true;
            }
            else if (borad == 20)
            {
                depart = "绝影";
                zhuangbeipai = true;
            }
            else if (borad == 21)
            {
                depart = "青杠剑";
                zhuangbeipai = true;
            }
            else if (borad == 22)
            {
                depart = "藤甲";
                zhuangbeipai = true;
            }
            else if (borad == 23)
            {
                depart = "诸葛连弩";
                zhuangbeipai = true;
            }
            else if (borad == 24)
            {
                depart = "爪黄飞电";
                zhuangbeipai = true;
            }
            else if (borad == 25)
            {
                depart = "紫騂";
                zhuangbeipai = true;
            }
            else if (borad == 26)
            {
                depart = "方天画戟";
                zhuangbeipai = true;
            }
            else if (borad == 27)
            {
                depart = "麒麟弓";
                zhuangbeipai = true;
            }
        }

        public void wjcp3()
        {
            borad = wjpai3;
            if (borad == 0)
            {
                depart = "杀";
                zhuangbeipai = false;
            }
            else if (borad == 1)
            {
                depart = "闪";
                zhuangbeipai = false;
            }
            else if (borad == 2)
            {
                depart = "桃";
                zhuangbeipai = false;
            }
            else if (borad == 3)
            {
                depart = "兵粮寸断";
                zhuangbeipai = false;
            }
            else if (borad == 4)
            {
                depart = "过河拆桥";
                zhuangbeipai = false;
            }
            else if (borad == 5)
            {
                depart = "火攻";
                zhuangbeipai = false;
            }
            else if (borad == 6)
            {
                depart = "借刀杀人";
                zhuangbeipai = false;
            }
            else if (borad == 7)
            {
                depart = "乐不思蜀";
                zhuangbeipai = false;
            }
            else if (borad == 8)
            {
                depart = "南蛮入侵";
                zhuangbeipai = false;
            }
            else if (borad == 9)
            {
                depart = "万箭齐发";
                zhuangbeipai = false;
            }
            else if (borad == 10)
            {
                depart = "顺手牵羊";
                zhuangbeipai = false;
            }
            else if (borad == 11)
            {
                depart = "水淹七军";
                zhuangbeipai = false;
            }
            else if (borad == 12)
            {
                depart = "五谷丰登";
                zhuangbeipai = false;
            }
            else if (borad == 13)
            {
                depart = "无懈可击";
                zhuangbeipai = false;
            }
            else if (borad == 14)
            {
                depart = "无中生有";
                zhuangbeipai = false;
            }
            else if (borad == 15)
            {
                depart = "赤兔";
                zhuangbeipai = true;
            }
            else if (borad == 16)
            {
                depart = "骅骝";
                zhuangbeipai = true;
            }
            else if (borad == 17)
            {
                depart = "八卦阵";
                zhuangbeipai = true;
            }
            else if (borad == 18)
            {
                depart = "白银狮子";
                zhuangbeipai = true;
            }
            else if (borad == 19)
            {
                depart = "大苑";
                zhuangbeipai = true;
            }
            else if (borad == 20)
            {
                depart = "绝影";
                zhuangbeipai = true;
            }
            else if (borad == 21)
            {
                depart = "青杠剑";
                zhuangbeipai = true;
            }
            else if (borad == 22)
            {
                depart = "藤甲";
                zhuangbeipai = true;
            }
            else if (borad == 23)
            {
                depart = "诸葛连弩";
                zhuangbeipai = true;
            }
            else if (borad == 24)
            {
                depart = "爪黄飞电";
                zhuangbeipai = true;
            }
            else if (borad == 25)
            {
                depart = "紫騂";
                zhuangbeipai = true;
            }
            else if (borad == 26)
            {
                depart = "方天画戟";
                zhuangbeipai = true;
            }
            else if (borad == 27)
            {
                depart = "麒麟弓";
                zhuangbeipai = true;
            }
        }

        public void wjcp4()
        {
            borad = wjpai4;
            if (borad == 0)
            {
                depart = "杀";
                zhuangbeipai = false;
            }
            else if (borad == 1)
            {
                depart = "闪";
                zhuangbeipai = false;
            }
            else if (borad == 2)
            {
                depart = "桃";
                zhuangbeipai = false;
            }
            else if (borad == 3)
            {
                depart = "兵粮寸断";
                zhuangbeipai = false;
            }
            else if (borad == 4)
            {
                depart = "过河拆桥";
                zhuangbeipai = false;
            }
            else if (borad == 5)
            {
                depart = "火攻";
                zhuangbeipai = false;
            }
            else if (borad == 6)
            {
                depart = "借刀杀人";
                zhuangbeipai = false;
            }
            else if (borad == 7)
            {
                depart = "乐不思蜀";
                zhuangbeipai = false;
            }
            else if (borad == 8)
            {
                depart = "南蛮入侵";
                zhuangbeipai = false;
            }
            else if (borad == 9)
            {
                depart = "万箭齐发";
                zhuangbeipai = false;
            }
            else if (borad == 10)
            {
                depart = "顺手牵羊";
                zhuangbeipai = false;
            }
            else if (borad == 11)
            {
                depart = "水淹七军";
                zhuangbeipai = false;
            }
            else if (borad == 12)
            {
                depart = "五谷丰登";
                zhuangbeipai = false;
            }
            else if (borad == 13)
            {
                depart = "无懈可击";
                zhuangbeipai = false;
            }
            else if (borad == 14)
            {
                depart = "无中生有";
                zhuangbeipai = false;
            }
            else if (borad == 15)
            {
                depart = "赤兔";
                zhuangbeipai = true;
            }
            else if (borad == 16)
            {
                depart = "骅骝";
                zhuangbeipai = true;
            }
            else if (borad == 17)
            {
                depart = "八卦阵";
                zhuangbeipai = true;
            }
            else if (borad == 18)
            {
                depart = "白银狮子";
                zhuangbeipai = true;
            }
            else if (borad == 19)
            {
                depart = "大苑";
                zhuangbeipai = true;
            }
            else if (borad == 20)
            {
                depart = "绝影";
                zhuangbeipai = true;
            }
            else if (borad == 21)
            {
                depart = "青杠剑";
                zhuangbeipai = true;
            }
            else if (borad == 22)
            {
                depart = "藤甲";
                zhuangbeipai = true;
            }
            else if (borad == 23)
            {
                depart = "诸葛连弩";
                zhuangbeipai = true;
            }
            else if (borad == 24)
            {
                depart = "爪黄飞电";
                zhuangbeipai = true;
            }
            else if (borad == 25)
            {
                depart = "紫騂";
                zhuangbeipai = true;
            }
            else if (borad == 26)
            {
                depart = "方天画戟";
                zhuangbeipai = true;
            }
            else if (borad == 27)
            {
                depart = "麒麟弓";
                zhuangbeipai = true;
            }
        }

        private void pvp1juese1_Click(object sender, EventArgs e)
        {

        }

        //清空目前出牌堆的牌
        public void delete() 
        {
            if (this.jqrkp.BackgroundImage != null) 
            {
                this.jqrkp.BackgroundImage = null;
            }
        }

        //四个补牌随机数
        int meRandom1;
        int meRandom2;
        int meRandom3;
        int meRandom4;
        #region 玩家补牌随机数
        //给玩家补牌的随机数进行填充
        public void numAdd()
        {
            //基础牌判断
            int indexkpjcs1 = rd.Next(0, 2);
            int indexkpjcs2 = rd.Next(0, 2);
            int indexkpjcs3 = rd.Next(0, 2);
            int indexkpjcs4 = rd.Next(0, 2);
            //锦囊牌判断
            int indexkpjns1 = rd.Next(4, 14);
            int indexkpjns2 = rd.Next(4, 14);
            int indexkpjns3 = rd.Next(4, 14);
            int indexkpjns4 = rd.Next(4, 14);
            //装备牌
            int indexkpzb1 = rd.Next(15, 27);
            int indexkpzb2 = rd.Next(15, 27);
            int indexkpzb3 = rd.Next(15, 27);
            int indexkpzb4 = rd.Next(15, 27);
            //所有总牌的随机数
            int indexkp1 = rd.Next(1, 160);
            int indexkp2 = rd.Next(1, 160);
            int indexkp3 = rd.Next(1, 160);
            int indexkp4 = rd.Next(1, 160);


            //敌人第一牌的地址
            //初始化第一张牌随机数
            if (indexkp1 >= 0 && indexkp1 <= 85)
            {
                meRandom1 = indexkpjcs1;//将drpai1变量的值等于机器人本张基础牌的下标
            }
            else if (indexkp1 >= 86 && indexkp1 <= 145)
            {
                meRandom1 = indexkpjns1;
            }
            else
            {
                meRandom1 = indexkpzb1;
            }

            //初始化第二张牌随机数
            if (indexkp2 >= 0 && indexkp2 <= 85)
            {
                meRandom2 = indexkpjcs2;//将drpai1变量的值等于机器人本张基础牌的下标
            }
            else if (indexkp2 >= 86 && indexkp2 <= 145)
            {
                meRandom2 = indexkpjns2;
            }
            else
            {
                meRandom2 = indexkpzb2;
            }

            //初始化第三张牌随机数
            if (indexkp3 >= 0 && indexkp3 <= 85)
            {
                meRandom3 = indexkpjcs3;//将drpai1变量的值等于机器人本张基础牌的下标
            }
            else if (indexkp2 >= 86 && indexkp2 <= 145)
            {
                meRandom3 = indexkpjns3;
            }
            else
            {
                meRandom3 = indexkpzb3;
            }


            //初始化第四张牌随机数
            if (indexkp4 >= 0 && indexkp4 <= 85)
            {
                meRandom4 = indexkpjcs4;//将drpai1变量的值等于机器人本张基础牌的下标
            }
            else if (indexkp4 >= 86 && indexkp4 <= 145)
            {
                meRandom4 = indexkpjns4;
            }
            else
            {
                meRandom4 = indexkpzb4;
            }
        } 
        #endregion
        int shoupainum;//判断现在已经补充了多少牌，一回合至多两张
        //新的回合给玩家补牌
        public void AddPai() {
            if (kp1.BackgroundImage == null && shoupainum<2) 
            {
                shoupainum++;
                kp1.BackgroundImage = kapaiimages.Images[meRandom1];
                wjpai1 = meRandom1;//让当前的随机数传递给第一张牌的下标
                kp1.Visible = true;
            }
            if (kp2.BackgroundImage == null && shoupainum < 2)
            {
                shoupainum++;
                kp2.BackgroundImage = kapaiimages.Images[meRandom2];
                wjpai2 = meRandom2;
                kp2.Visible = true;
            }
            if (kp3.BackgroundImage == null && shoupainum < 2)
            {
                shoupainum++;
                kp3.BackgroundImage = kapaiimages.Images[meRandom3];
                wjpai3 = meRandom3;
                kp3.Visible = true;
            }
            if (kp4.BackgroundImage == null && shoupainum < 2)
            {
                shoupainum++;
                kp4.BackgroundImage = kapaiimages.Images[meRandom4];
                wjpai4 = meRandom4;
                kp4.Visible = true;
            }
        }

        int shoupainum2=0;//判断现在已经补充了多少牌，一回合至多两张
        //新的回合给机器人补牌
        public void jqrAddPai()
        {
            if (drpai1 == -1 && shoupainum2 < 2)
            {
                shoupainum2++;
                drpai1 = meRandom1;//让当前的随机数传递给第一张牌的下标
                kpnum++;
            }
            if (drpai2 == -1 && shoupainum2 < 2)
            {
                shoupainum2++;
                drpai2 = meRandom1;//让当前的随机数传递给第一张牌的下标
                kpnum++;
            }
            if (drpai3 == -1 && shoupainum2 < 2)
            {
                shoupainum2++;
                drpai3 = meRandom1;//让当前的随机数传递给第一张牌的下标
                kpnum++;
            }
            if (drpai4 == -1 && shoupainum2 < 2)
            {
                shoupainum2++;
                drpai4 = meRandom1;//让当前的随机数传递给第一张牌的下标
                kpnum++;
            }
        }

        int count1 = 0;//出牌数量
        //机器人出牌主系统 主线程停止后调用
        public void jiqirenchupai() 
        {
            //如果机器人手中有杀的话就发出,并且一回合只能出一次,除非有诸葛连弩
            if (count1 == 0) 
            {
                if (drpai1 == 0 || drpai2 == 0 || drpai3 == 0 || drpai4 == 0)
                {
                    //MessageBox.Show("人机出了杀，请出闪否则扣血");
                    this.jqrkp.BackgroundImage = kapaiimages.Images[0];
                    if (drpai1 == 0) {
                        drpai1 = -1;
                        kpnum--;
                    }
                    else if (drpai2 == 0) 
                    {
                        drpai2 = -1;
                        kpnum--;
                    }
                    else if (drpai3 == 0)
                    {
                        drpai3 = -1;
                        kpnum--;
                    }
                    else if (drpai4== 0)
                    {
                        drpai4 = -1;
                        kpnum--;
                    }
                    count1++;
                }
            }
        }

        int jqrzhuangbeiid;//机器人装备的ID情况

        //该方法实现人机使用装备牌
        public void jqrzhuangbei() 
        {
                #region 判断该装备牌是否为减马
                if (drpai1 == 15 || drpai1 == 19 || drpai1 == 25) //判断该装备牌是否为减马
                {
                    jqrzhuangbeiid = drpai1;
                    this.jqrjianma.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai1 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai2 == 15 || drpai2 == 19 || drpai2 == 25)
                {
                    jqrzhuangbeiid = drpai2;
                    this.jqrjianma.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai2 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai3 == 15 || drpai3 == 19 || drpai3 == 25)
                {
                    jqrzhuangbeiid = drpai3;
                    this.jqrjianma.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai3 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai4 == 15 || drpai4 == 19 || drpai4 == 25)
                {
                    jqrzhuangbeiid = drpai3;
                    this.jqrjianma.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai4 = -1;//当前卡槽置空
                    kpnum -= 1;
                } 
                #endregion
                #region 判断该装备牌是否为加马
                if (drpai1 == 16 || drpai1 == 20 || drpai1 == 24) //判断该装备牌是否为加马
                {
                    jqrzhuangbeiid = drpai1;
                    this.jqrjiama.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai1 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai2 == 16 || drpai2 == 20 || drpai2 == 24)
                {
                    jqrzhuangbeiid = drpai2;
                    this.jqrjiama.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai2 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai3 == 16 || drpai3 == 20 || drpai3 == 24)
                {
                    jqrzhuangbeiid = drpai3;
                    this.jqrjiama.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai3 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai4 == 16 || drpai4 == 20 || drpai4 == 24)
                {
                    jqrzhuangbeiid = drpai4;
                    this.jqrjiama.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai4 = -1;//当前卡槽置空
                    kpnum -= 1;
                } 
                #endregion
                #region 判断该装备是否为武器
                if (drpai1 == 21 || drpai1 == 23 || drpai1 == 26 || drpai1 == 27)//判断该装备牌是否为武器
                {
                    jqrzhuangbeiid = drpai1;
                    this.jqrwuqi.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai1 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai2 == 21 || drpai2 == 23 || drpai2 == 26 || drpai2 == 27)//判断该装备牌是否为武器
                {
                    jqrzhuangbeiid = drpai2;
                    this.jqrwuqi.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai2 = -1;//当前卡槽置空
                    kpnum -= 1;

                }
                else if (drpai3 == 21 || drpai3 == 23 || drpai3 == 26 || drpai3 == 27)//判断该装备牌是否为武器
                {
                    jqrzhuangbeiid = drpai3;
                    this.jqrwuqi.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai3 = -1;//当前卡槽置空
                    kpnum -= 1;

                }
                else if (drpai4 == 21 || drpai4 == 23 || drpai4 == 26 || drpai4 == 27)//判断该装备牌是否为武器
                {
                    jqrzhuangbeiid = drpai4;
                    this.jqrwuqi.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai4 = -1;//当前卡槽置空
                    kpnum -= 1;
                } 
                #endregion
                #region 判断该装备牌是否为防具
                if (drpai1 == 17 || drpai1 == 18 || drpai1 == 22)//判断该装备牌是否为防具
                {
                    jqrzhuangbeiid = drpai1;
                    this.jqrfangju.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai1 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai2 == 17 || drpai2 == 18 || drpai2 == 22)
                {
                    jqrzhuangbeiid = drpai2;
                    this.jqrfangju.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai2 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai3 == 17 || drpai3 == 18 || drpai3 == 22)
                {
                    jqrzhuangbeiid = drpai3;
                    this.jqrfangju.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai3 = -1;//当前卡槽置空
                    kpnum -= 1;
                }
                else if (drpai4 == 17 || drpai4 == 18 || drpai4 == 22)
                {
                    jqrzhuangbeiid = drpai4;
                    this.jqrfangju.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    this.jqrkp.BackgroundImage = kapaiimages.Images[jqrzhuangbeiid];
                    drpai4 = -1;//当前卡槽置空
                    kpnum -= 1;
                } 
                #endregion
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(zhuangbeipai.ToString());
            if (chupai == 1)
            {
                this.jqrkp.BackgroundImage = kp1.BackgroundImage;
                kp1.BackgroundImage = null;
                kp1.Hide();
                MessageBox.Show(wjpai1.ToString());
            }
            if (chupai == 2)
            {
                this.jqrkp.BackgroundImage = kp2.BackgroundImage;
                kp2.BackgroundImage = null;
                kp2.Hide();
                MessageBox.Show(wjpai2.ToString());
            }
            if (chupai == 3)
            {
                this.jqrkp.BackgroundImage = kp3.BackgroundImage;
                kp3.BackgroundImage = null;
                kp3.Hide();
                MessageBox.Show(wjpai3.ToString());
            }
            if (chupai == 4)
            {
                this.jqrkp.BackgroundImage = kp4.BackgroundImage;
                kp4.BackgroundImage = null;
                kp4.Hide();
                MessageBox.Show(wjpai4.ToString());
            }
            jqrchupai(depart);//判断人机出牌;
        }
        private void jqrkp_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.juese1kpcount.Text = "当前敌人手牌数:" + kpnum;//强制事实更新敌人手牌数
        }

        //机器人出牌时间
        int jqrtimedigit;
        bool jqrtimes=true;
        private void jqrtime_Tick(object sender, EventArgs e)
        {
            jqrtimedigit++;
            if (jqrtimedigit == 1)
            {
                jiqirenchupai();//机器人出杀方法,如果机器人有杀就打出
                if (chupai == 1 && wjpai1 == 1)
                {
                    MessageBox.Show("闪避成功");
                }
                else if (chupai == 1 && wjpai2 == 1)
                {
                    MessageBox.Show("闪避成功");
                }
                else if (chupai == 1 && wjpai3 == 1)
                {
                    MessageBox.Show("闪避成功");
                }
                else if (chupai == 1 && wjpai4 == 1)
                {
                    MessageBox.Show("闪避成功");
                }
            }
            if (jqrtimedigit == 2) {
                jqrtimes = false;
            }
            jiqirenchupai();//机器人出杀方法,如果机器人有杀就打出
            jqrzhuangbei();//机器人装备牌方法
        }
    }
}
