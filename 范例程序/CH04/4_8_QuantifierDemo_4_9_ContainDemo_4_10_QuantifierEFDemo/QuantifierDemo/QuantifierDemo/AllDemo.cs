using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifierDemo
{
    class AllDemo
    {
        public static void DoAll()
        {
            List<baidu> strList = new List<baidu> {
               new baidu{
                    website="www.baidu.com",name="百度搜索"},
                    new baidu{
                    website="www.baidu.com",name="百度"},
                    new baidu{
                    website="www.baidu.com",name="百度搜索引擎"}
                };


            ////All
            //bool allCheck = strList.All(baidu =>
            //        baidu.name == "百度");
            //if (allCheck)
            //    Console.WriteLine(
            //        "所有的“www.baidu.com”对应的中文名称都是“百度”");
            //else
            //    Console.WriteLine(
            //        "并非所有的“www.baidu.com"对应的中文名称都是“百度”");

            //Any
            bool allCheck = strList.Any(baidu =>
                    baidu.name == "百度");
            if (allCheck)
                Console.WriteLine(
                "集合中存在“www.baidu.com”对应的中文名称是“百度”的元素");
            else
                Console.WriteLine(
                "集合中没有“www.baidu.com”对应的中文名称是“百度”的元素");

            ////All
            List<checkString> strList2 = new List<checkString> {
                    new checkString{qName="www"},
                    new checkString{qName="www.baidu"},
                    new checkString{qName="www.baidu.com"},
                 };
            allCheck = strList2.All(checkString =>
                    checkString.qName.StartsWith("www"));
            if (allCheck)
                Console.WriteLine("所有的元素均以“www”为前缀");
            else
                Console.WriteLine("并非所有的元素均以“www”为前缀");
            Console.ReadKey();
        }
        class baidu
        {
            public string website { get; set; }
            public string name { get; set; }
        }
        class checkString
        {
            public string qName { get; set; }
        }

    }
}