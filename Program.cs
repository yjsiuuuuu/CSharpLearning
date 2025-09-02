using GiftBoxNamespace;
using GiftBoxManagerNamespace;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using static GiftBoxManagerNamespace.GiftBoxManager;
using System.Text;

namespace ConsoleApp3
{
    internal class Program

    {
        //Method (함수)
        //1.정리하기위해, 2. 반복을 단순화 (함수쓰는이유)
        static void Main(string[] args)
        {

            //string.Format,toString(),$,+,StringBuiler
            //ㄴstring.format (반올림,통화 표시 , 1의자리 앞에 0표시, 천의 자리 콤마표시, 절대 값 표시)

            string name = "민아";
            int point = 3000;

            Console.WriteLine(name+"고객님,적립금"+point+"원 있으십니다");
            Console.WriteLine(string.Format("{0}고객님,적립금{1}원 있으십니다",name,point));
            Console.WriteLine($"{name}고객님,적립금{point}원 있으십니다");

            double spoint = 234.239;
            Console.WriteLine(Math.Round(spoint,2));
            Console.WriteLine(string.Format("{0:0.00}",spoint));

            Console.WriteLine(string.Format("{0:C}",spoint));
            string point2 = string.Format("{0:C}", spoint);
            Console.WriteLine(point2.Replace(point2.Substring(0, 1), point2.Substring(0, 1) + " "));
            Console.WriteLine(string.Format("{0:D3}",3));
            Console.WriteLine(string.Format("{0:N0}",1231233));
            Console.WriteLine(Math.Abs(-1231233));
            Console.WriteLine((int)-1231.233);

            Console.WriteLine(23123123.ToString("N0"));

            Console.WriteLine(name + "고객님,적립금" + point + "원 있으십니다");
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append("고객님, 적립금");
            sb.Append(point.ToString());
            sb.Append("원 있으십니다");
            Console.WriteLine(sb.ToString());



        }  

    }

}
