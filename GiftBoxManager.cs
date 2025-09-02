using ConsoleApp3;
using GiftBoxNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp3.Program;

namespace GiftBoxManagerNamespace
{
    internal class GiftBoxManager
    {

        //시작점
        public void SetInIt()
        {
            // 선물생성 3개
            GiftBox addressA = GiftBoxMaker("A친구야 잘지내니", 100000, ITEM_GRADE.NORMAL);
            GiftBox addressB = GiftBoxMaker("B친구야 잘지내니", 110000, ITEM_GRADE.RARE);
            GiftBox addressC = GiftBoxMaker("C친구야 잘지내니", 120000, ITEM_GRADE.UNIQUE);
            GiftBox addressD = GiftBoxMaker("D친구야 잘지내니", 130000, ITEM_GRADE.NORMAL);
            GiftBox addressE = GiftBoxMaker("E친구야 잘지내니", 140000, ITEM_GRADE.RARE);
        }

        private GiftBox GiftBoxMaker(string letter, int money, ITEM_GRADE item_grade)
        {
            //인스턴스 생성
            GiftBox address = new GiftBox()
            {
                Letter = letter,
                Money = money,
                Grade = item_grade,
            };

            return address; //여기서 중단 , 여기서 중단하고 값을 돌려주겠다.

        }
    }
}
