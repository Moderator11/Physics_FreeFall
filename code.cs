using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFallSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            float acc_g = 0, pos_st = 0, pos_ed = 0;

            Console.Title = "< 2 - 2 - 14 박수민 물리 자유낙하 탐구 프로젝트>";
            Console.WriteLine("<2-2-14 박수민 물리 자유낙하 탐구 프로젝트>\n");

            Console.Write("시작 높이=");
            pos_st = float.Parse(Console.ReadLine());//2-2-14 박수민
            Console.Write("끝 높이=");
            pos_ed = float.Parse(Console.ReadLine());
            //출발 높이와 도착 높이, 가속도를 입력받는 코드
            Console.Write("중력 가속도=");
            acc_g = float.Parse(Console.ReadLine());

            double timestep_d = Math.Sqrt(2 * (pos_st - pos_ed) / acc_g);
            //출발 높이와 끝높이, 가속도로 운동 시간을 계산하는 코드

            int timestep = (int)timestep_d;
            int[] posAf = new int[timestep];

            for (int i = 1; i <= timestep; i++)
            {
                posAf[i-1] = (int)(pos_st - i * i * acc_g / 2);
                //시각화를 위한 소숫점 자리의 버림
            }

            Console.WriteLine("아무 키나 눌러 실험을 시작합니다.");
            Console.ReadKey();

            bool afMatch = false;
            int curPos = (int)pos_st;
            for (int i = (int)pos_st; i >= pos_ed; i--)
            {
                for (int k = 0; k < posAf.Length; k++)//2-2-14 박수민
                {
                    if (i == posAf[k])
                    {
                        Console.WriteLine(string.Format("{0}m   o", i));
                        afMatch = true;
                    }
                }
                if (afMatch == false)
                {
                    Console.WriteLine(string.Format("{0}m", i));
                }
                else
                {
                    afMatch = false;
                }
            }

            Console.WriteLine(string.Format("\n중력 가속도 = {0}, 시작지점 = {1}m, 끝지점 = {2}m\n도착까지 걸린시간 = {3}초\n", acc_g, pos_st, pos_ed, timestep_d));
            Console.ReadKey();
        }
    }
}
