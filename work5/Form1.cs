using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        parama para = new parama();

        void calcu()     //統一運算  總分  平均  最低   最高
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)                     //目前為算單人 總分 平均  最低  最高
            {
                sum += para.score[para.stu_num,i];
                if (i == 0) para.min = para.max = para.score[para.stu_num,0];

                else
                {
                    if (para.max < para.score[para.stu_num,i]) para.max = para.score[para.stu_num,i];
                    if (para.min > para.score[para.stu_num,i]) para.min = para.score[para.stu_num,i];
                }
            }

            //int avg_out;
            para.sum = sum;
            para.avg = sum / 3;
            para.avg = Math.Round(para.avg, 1, MidpointRounding.AwayFromZero);

        }

        void print()        //隨機生成的列表  所以textbox不會輸入
        {
            textBox5.Text += $"\r\n{textBox1.Text.PadRight(15)}{para.score[para.stu_num, 0].ToString().PadLeft(16)}{para.score[para.stu_num, 1].ToString().PadLeft(20)}" +
                $"{para.score[para.stu_num, 2].ToString().PadLeft(20)}{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(20)}" +
                $"{para.max.ToString().PadLeft(9)}";

        }

        private void button1_Click(object sender, EventArgs e)      //插入字串所加入的新值
        {

            string name;
            
            name = textBox1.Text;                                   //名字
            para.score[para.stu_num,0] = Convert.ToInt32(textBox2.Text);              //國文
            para.score[para.stu_num,1] = Convert.ToInt32(textBox3.Text);              //英文
            para.score[para.stu_num,2] = Convert.ToInt32(textBox4.Text);              //數學

            calcu();

            print();
            //textBox5.Text += $"\r\n{textBox1.Text.PadRight(15)}{textBox2.Text.PadLeft(20)}{textBox3.Text.PadLeft(20)}{textBox4.Text.PadLeft(20)}"+
            //                $"{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(20)}" +
            //                $"{para.max.ToString().PadLeft(20)}";

            para.stu_num++;
          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {       //姓名  國文分數   英文分數   數學分數  各科名字 

            int[] score = new int[3];
            Random rd = new Random();
            //1.名字根據  排序 顯示出數字  2.隨機出三科分數   3.透過calcu算出剩餘


            for (int j = 0; j < 3; j++) //放入隨機參數
                {
                    
                    int rd_num = rd.Next(0, 100);
                    para.score[para.stu_num, j] = rd_num;
                    
                }

            calcu();
            //textBox5.Text += $"\r\n{para.stu_num.ToString().PadRight(10)}{para.score[para.stu_num, 0].ToString().PadLeft(10)}{para.score[para.stu_num, 1].ToString().PadLeft(20)}" +
            //    $"{para.score[para.stu_num, 2].ToString().PadLeft(20)}{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(14)}" +
            //    $"{para.max.ToString().PadLeft(14)}";
            //print();

            label5.Text += $"\n{para.stu_num.ToString().PadRight(20)}{para.score[para.stu_num, 0].ToString().PadLeft(20)}{para.score[para.stu_num, 1].ToString().PadLeft(20)}{para.score[para.stu_num, 2].ToString().PadLeft(20)}{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(20)}{para.max.ToString().PadLeft(20)}";


            para.stu_num++;

            //MessageBox.Show(rd_num.ToString());


        }

        Random rd = new Random();
        

        private void button5_Click(object sender, EventArgs e)
        {
            int rd_num = rd.Next(0, 100);
            //Random rd = new Random();
            for (int i = 0; i<20; i++)
            {
                int[] score = new int[3];
                
                //1.名字根據  排序 顯示出數字  2.隨機出三科分數   3.透過calcu算出剩餘


                for (int j = 0; j < 3; j++) //放入隨機參數
                {

                    //int rd_num = rd.Next(0, 100);
                    //para.score[para.stu_num, j] = rd_num;

                }

                calcu();
                //textBox5.Text += $"\r\n{para.stu_num.ToString().PadRight(15)}{para.score[para.stu_num, 0].ToString().PadLeft(16)}{para.score[para.stu_num, 1].ToString().PadLeft(20)}" +
                //    $"{para.score[para.stu_num, 2].ToString().PadLeft(20)}{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(14)}" +
                //    $"{para.max.ToString().PadLeft(14)}";
                //print();
                label5.Text += $"\n{para.stu_num.ToString().PadRight(15)}{para.score[para.stu_num, 0].ToString().PadLeft(16)}{para.score[para.stu_num, 1].ToString().PadLeft(20)}" +
                    $"{para.score[para.stu_num, 2].ToString().PadLeft(20)}{para.sum.ToString().PadLeft(20)}{para.avg.ToString().PadLeft(20)}{para.min.ToString().PadLeft(14)}" +
                    $"{para.max.ToString().PadLeft(14)}";


                para.stu_num++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] a_sum = new int[3];           //國英數的總分
            double[] a_avg = new double[3];           //國英數的平均
            int[] a_max = new int[3];           //國英數的最大
            int[] a_min = new int[3];           //國英數的最低
            string[] statis = new string[4] {"總分","平均","最高","最低"};

            int sum;
            //單一科目的統計
            for (int i= 0; i < 3 ; i++)
            {
                sum = 0;
                for(int j = 0; j< para.stu_num ; j++)           //第零科為國文 英文 數學 每次不同學生
                {

                        sum += para.score[j, i];
                        if (j == 0) para.min = para.max = para.score[j, i];

                        else
                        {
                            if (para.max < para.score[j, i]) para.max = para.score[j, i];
                            if (para.min > para.score[j, i]) para.min = para.score[j, i];
                        }
     
                    //int avg_out;
                   
                }

                a_sum[i] = sum;
                para.avg = sum / para.stu_num;
                a_avg[i] = Math.Round(para.avg, 1, MidpointRounding.AwayFromZero);
                a_max[i] = para.max;
                a_min[i] = para.min;
                //MessageBox.Show(a_sum[i] + "   " + a_avg[i] + "   " + a_max[i] + "   " + a_min[i]);
            }


            //for(int i = 0 ; i<4 ; i++)
            //{
                textBox6.Text += $"\r\n{statis[0].PadRight(6)}{a_sum[0].ToString().PadLeft(14)}{a_sum[1].ToString().PadLeft(30)}" +
                    $"{a_sum[2].ToString().PadLeft(30)}";

                textBox6.Text += $"\r\n{statis[1].PadRight(6)}{a_avg[0].ToString().PadLeft(14)}{a_avg[1].ToString().PadLeft(30)}" +
                      $"{a_avg[2].ToString().PadLeft(30)}";

                textBox6.Text += $"\r\n{statis[2].PadRight(6)}{a_max[0].ToString().PadLeft(14)}{a_max[1].ToString().PadLeft(30)}" +
                        $"{a_max[2].ToString().PadLeft(30)}";

                textBox6.Text += $"\r\n{statis[3].PadRight(6)}{a_min[0].ToString().PadLeft(14)}{a_min[1].ToString().PadLeft(30)}" +
                       $"{a_min[2].ToString().PadLeft(30)}";
            //}
        }
    }
}
