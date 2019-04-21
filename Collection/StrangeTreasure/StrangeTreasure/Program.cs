using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StrangeTreasure
{
    class Program
    {
        static bool Bt = true;
        static int i = 0;
        //static int count = 100;
        static AttendanceSheet AS = new AttendanceSheet();
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Elapsed += Program.Action;
            timer.Start();
            if(Bt == false) {
                timer.Stop();
            }

            Console.ReadLine();
        }

        private static void Action(object sender, ElapsedEventArgs e)
        {
            string[] ss = new string[] { "2/30早上7:20大學學生宿舍308室....\r\n", "鹿人:蚯蚓，你是要去上王金發的社畜課?\r\n",
                "泥鰍:嘿阿，安抓。\r\n", "鹿人:王金發之前不是說過一學期只有一次簽到，如果剛好沒簽到的話就當掉，如果是今天的話幫我簽到一下，我想翹課睡覺。\r\n",
                "泥鰍:是可以啦，但是你那麼混好嗎?\r\n", "鹿人:沒事的啦，我算過學分了，這科過就不會被二一。\r\n",
                "小痣:等等，lol明天結算，我今天要衝菁英，也幫我簽一下。\r\n","泥鰍:你們兩個齁，最好都這樣啦，只幫你們這次。\r\n",
                "泥鰍:出門了，掰掰。還有!!!林北泥鰍啦!!!!!\r\n","一段時間後.....................................................\r\n",
                "早上7:40，大學學生宿舍509室....\r\n","極.奇怪寶貝A&B:可以幫我們一個忙嗎?我們兩個等等要去唱KTV，如果有簽到的話可以幫我們把簽到單換成這張嗎?我們已經簽好了。\r\n",
                "真.奇怪寶貝:痾...。\r\n","極.奇怪寶貝A&B:你換完之後再簽你的這樣就沒問題了，就謝謝你囉，下次請你喝飲料。\r\n",
                "真.奇怪寶貝:痾...。\r\n","早上7:50泥鰍到教室後簽到....\r\n","早上7:55奇怪寶貝到教室後換掉簽到單並蓋章...\r\n","期末...."
                 };
            if (i < ss.Length) { CW(ss[i]); }

            switch (i)
            {
                case 15:
                    Room305(ref AS);
                    break;
                case 16:
                    Room509(ref AS);
                    break;
                case 19:
                    CWEnd(AS);
                    Program.StopTimer();
                    break;
                default:
                    break;
            }
            i++;
            //if (count > 99) { Console.WriteLine("2/30早上7:20大學學生宿舍308室....\r\n"); }
            //else if (count > 98) { Console.WriteLine("鹿人:蚯蚓，你是要去上王金發的社畜課?\r\n"); }
            //else if (count > 97) { Console.WriteLine("泥鰍:嘿阿，安抓。\r\n"); }
            //else if (count > 96) { Console.WriteLine("鹿人:王金發之前不是說過一學期只有一次簽到，如果剛好沒簽到的話就當掉，如果是今天的話幫我簽到一下，我想翹課睡覺。\r\n"); }
            //else if (count > 95) { Console.WriteLine("泥鰍:是可以啦，但是你那麼混好嗎?\r\n"); }
            //else if (count > 94) { Console.WriteLine("鹿人:沒事的啦，我算過學分了。\r\n"); }
            //else if (count > 93) { Console.WriteLine("小痣:等等，lol明天結算，我今天要衝菁英，也幫我簽一下。\r\n"); }
            //else if (count > 92) { Console.WriteLine("泥鰍:你們兩個齁，最好都這樣啦，只幫你們這次。\r\n"); }
            //else if (count > 91) { Console.WriteLine("泥鰍:出門了，掰掰。還有!!!林北泥鰍啦!!!!!\r\n"); }

            //else if (count > 90) { Console.WriteLine("一段時間後.....................................................\r\n"); }

            //else if (count > 89) { Console.WriteLine("早上7:40，大學學生宿舍509室....\r\n"); }
            //else if (count > 88) { Console.WriteLine("極.奇怪寶貝A&B:可以幫我們一個忙嗎?我們兩個等等要去唱KTV，可以幫我們把簽到單換成這張嗎?我們已經簽好了。\r\n"); }
            //else if (count > 87) { Console.WriteLine("真.奇怪寶貝:痾...。\r\n"); }
            //else if (count > 86) { Console.WriteLine("極.奇怪寶貝A&B:你換完之後再簽你的這樣就沒問題了，就謝謝你囉，下次請你喝飲料。\r\n"); }
            //else if (count > 85) { Console.WriteLine("真.奇怪寶貝:痾...。\r\n"); }

            //else if (count > 84)
            //{
            //    Console.WriteLine("早上7:50泥鰍到教室後簽到....\r\n");
            //    Room305(ref AS);
            //}
            //else if (count > 83)
            //{
            //    Console.WriteLine("早上7:55奇怪寶貝到教室後換掉簽到單並蓋章...\r\n");
            //    Room509(ref AS);
            //}
            //else if (count > 82) { Console.WriteLine("期末...."); }
            //else if (count > 81)
            //{
            //    CWEnd(AS);
            //    Program.StopTimer();
            //}
            //count--;
        }

        public static void Room305(ref AttendanceSheet AS)
        {
            for (int i = 0; i < 2; i++)
            {
                AS.Stu[i].Attend = "簽";
            }
            AS.Stu[2].Attend = "自簽";

        }

        static void Room509(ref AttendanceSheet AS)
        {
            AS = new AttendanceSheet();
            for (int i = 3; i < 5; i++)
            {
                AS.Stu[i].Attend = "自簽";
            }

            AS.Stu[5].Attend = "蓋章";
            
        }

        public static void StopTimer()
        {
            Bt = false;
        }

        static void CWEnd(AttendanceSheet a)
        {
            foreach (var item in a.Stu)
            {
                Console.WriteLine("{0}:{1}({2})\r\n",item.Name , item.Attend,item.Attend == "自簽" ? "Pass" :"Fail" );
            }
            Console.WriteLine("因此鹿人就被二一了，教室ㄟref寶貝~~~~~\r\n請按Enter鍵繼續 . . .");
        }

        static void CW(string ss)
        {
            Console.WriteLine("" + ss);
        }
    }



    class AttendanceSheet {
      public  Student[] Stu = new Student[] { new Student("鹿人"), new Student("小痣") , new Student("泥鰍") ,
            new Student("極.奇怪寶貝A") , new Student("極.奇怪寶貝B") , new Student("真.奇怪寶貝") };
    }


    class Student 
    {
        public Student(string name)
        {
            Name = name;
            attend = "未到";
        }
        public string Name { get; set; }

        private string attend;
        public string Attend
        {
            get { return attend; }
            set {
                if (value == "自簽"){attend = value;}
                else {attend = "不是自己的筆跡";}
            }
        }

    }

}
