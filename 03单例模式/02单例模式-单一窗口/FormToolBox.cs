using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02单例模式_单一窗口
{
    public partial class FormToolBox : Form
    {
        private FormToolBox()//将构造函数改为私有的，使得该类之外无法实例化该类,而将实例化的放在静态函数GetInstance()中
        {
            InitializeComponent();
        }
        private static FormToolBox ftb = null;
        public static FormToolBox GetInstance()
        {
            //存储唯一对象的字段为空，或者窗口对象已经被释放
            if (ftb == null || ftb.IsDisposed)
            {
                ftb = new FormToolBox();
                ftb.MdiParent = FormParent.ActiveForm;
            }
            return ftb;
        }
    }
}
