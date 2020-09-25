using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 文心雕龙.文本模板
{
    public partial class 运行时模板
    {
        public static void Run()
        {
            string Content = new 运行时模板().TransformText();

            //Debug.WriteLine("显示结果");
            Debug.WriteLine("---------");
            Debug.WriteLine(Content);
           
            //ConsoleX.WriteLine(Content);
            //ConsoleX.Show();
        }
    }
}

public class AppSetting
{
    public static string AppName = "文心雕龙";
}

/*

<#=AppSetting.AppName#>

*/