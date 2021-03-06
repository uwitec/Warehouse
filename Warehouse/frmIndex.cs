﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;

namespace Warehouse
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            toolStatus_Time.Text = "当前用户：" + Global.userName + "    登录时间：" + DateTime.Now.ToString("yyyy年MM月dd日 HH:mm:ss");

            if (Global.userName != "admin")
            {
                公司信息设置ToolStripMenuItem.Visible = false;
                代理商级别维护ToolStripMenuItem.Visible = false;
                成品规格维护ToolStripMenuItem.Visible = false;
                用户管理ToolStripMenuItem.Visible = false;
            }
            if (!Global.IsAdmin)
            {
                统计查询ToolStripMenuItem1.Visible = false;
                客户管理ToolStripMenuItem.Visible = false;
            }
            //ShowFrom(new frmWarehouseView());
        }

        public void ShowFrom(Form fm)
        {
            panel1.Controls.Clear();
            fm.MdiParent = this;
            fm.Parent = panel1;
            fm.Dock = DockStyle.Fill;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Show();
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmUser());
        }

        private void frmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void 成品规格维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsNorm());
        }

        private void 代理商级别维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmAgentNorm());
        }

        private void 成品入仓ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsIn());
        }

        private void 成品出仓ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsOut());
        }

        private void 查询ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmGoodsSearch());
        }

        private void 修改个人密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             frmUpdatePwd f = new frmUpdatePwd();
             f.ShowDialog();
        }

        private void 库存查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmWarehouseView());
        }


        private void 统计查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmStatistics());
        }

        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出系统?", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
                //System.Environment.Exit(0);
            }
        }

        private void 公司信息设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmCompany());
        }

        private void frmIndex_KeyDown(object sender, KeyEventArgs e)
        {
            ////单键 
            //switch (e.KeyCode)
            //{
            //    case Keys.F1:
            //        成品入仓ToolStripMenuItem_Click(this, EventArgs.Empty);
            //        break;
            //    case Keys.F2:
            //        成品出仓ToolStripMenuItem_Click(this, EventArgs.Empty);
            //        break;
            //    case Keys.F3:
            //        查询ToolStripMenuItem1_Click(this, EventArgs.Empty);
            //        break;
            //    case Keys.F4:
            //        库存查看ToolStripMenuItem_Click(this, EventArgs.Empty);
            //        break;
            //    case Keys.F5:
            //        客户管理ToolStripMenuItem_Click(this, EventArgs.Empty);
            //        break;
            //    case Keys.Escape:
            //        退出ToolStripMenuItem_Click_1(this, EventArgs.Empty);
            //        break;
            //} 

        }

        private void 客户管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowFrom(new frmCustomer());
        }

        private void 锁定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLock fl = new frmLock();
            fl.Owner = this;
            fl.ShowDialog();
        }




    }
}
