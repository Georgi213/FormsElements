using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsElements
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pic;

        public Form1()
        {
            this.Height = 500;
            this.Width = 700;
            this.Text = "Vorm elementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("Silt-Label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("Märkeruut-Checkbox"));
            tn.Nodes.Add(new TreeNode("Radionupp-Radiobutton"));
            tn.Nodes.Add(new TreeNode("Tekstkast-TextBox"));
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));
            //nupp
            btn =new Button();
            btn.Text = "Vajuta siia";
            btn.Location = new Point(150, 30);
            btn.Height = 30;
            btn.Width = 100;
            btn.Click += Btn_Click;
            //pealkiri
            lbl = new Label();
            lbl.Text = "Elementide loomine c# abil";
            lbl.Size = new Size(600, 30);
            lbl.Location = new Point(150, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseHover;
            //PictureBox
            pic = new PictureBox();
            pic.Size = new Size(50, 50);
            pic.Location = new Point(150, 0);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = Image.FromFile(@"..\..\pilti.jpg");
            pic.Image = Image.FromFile(@"..\..\car.jpg");
            pic.Image = Image.FromFile(@"..\..\ford.jpg");
            pic.Image = Image.FromFile(@"..\..\sport.jpg");
            pic.ImageLocation = ("../../pilti.jpg");
            pic.SizeMode = PictureBoxSizeMode.AutoSize;
            pic.MouseDoubleClick += Pic_MouseDoubleClick;

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }
        private void Lbl_MouseLeave(object sender,EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }
        private void Pic_MouseDoubleClick(object sender,EventArgs e)
        {
            pic.ImageLocation = ("../../car.jpg");
        }
        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(200,10,20);
        }
        private void Btn_Click(object sender,EventArgs e)
        {
            if (MessageBox.Show("Ты уверен, что хочешь закрыть программу?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Tree_AfterSelect(object sender,TreeViewEventArgs e)
        {
            if(e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "Silt-Label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pic);
            }
        }
    }
}
