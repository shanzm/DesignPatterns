using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//这个项目中，有一个ParentForm窗口，其有一个菜单栏，栏中有ToolBox按钮
//若是点击该按钮则创建一个ToolBox窗口

//我们设置一个FormToolBox类型的属性ftb，创建ToolBox窗口后，则将窗口对象赋值给ftb
//在创建ToolBox窗口的过程中，我们判断ftb是否为空，为空则创建ToolBox窗口，不为空则不创建新的ToolBox窗口
//从而实现一次只能创建一个ToolBox窗口


namespace 单例模式_单一窗口
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;//子窗口的容器
        }

        private FormToolBox ftb = null;
        private void ToolStripMenuItemToolBox_Click(object sender, EventArgs e)
        {
            OpenToolBox();
        }


        //时刻记得将可能会重复的操作封装为方法
        //创建ToolBox窗口
        private void OpenToolBox()
        {
            //判断当前是否已经存在FormToolBox窗口或者FormToolBox窗口对象已经被释放
            //若是不判断ftb.IsDisposed则在你关闭FormToolBox后，再次点击菜单栏ToolBox,不会新建FormToolBox窗口
            if (ftb == null || ftb.IsDisposed)
            {
                ftb = new FormToolBox();
                ftb.MdiParent = this;
                ftb.Show();
            }
        }
    }
}
