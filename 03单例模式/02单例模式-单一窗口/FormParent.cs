using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//在01单例模式-单一窗口项目中，我们是实现了ToolBox窗口一次只能创建一个
//但是，我们把创建ToolBox窗口的代码都是在FormParent窗口项目中实现的
//这明显不符合


namespace _02单例模式_单一窗口
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;//作为子窗口的容器
        }

        private void toolBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormToolBox.GetInstance().Show();
        }
    }
}
