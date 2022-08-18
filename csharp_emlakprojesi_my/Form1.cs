using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_emlakprojesi_my
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Context context =new Context();

        private void btnlistele_Click(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            dataGridView1.DataSource=values;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtad.Text;
            category.CategoryDetails = txtdes.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Kategori eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            var values = context.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
            context.Categories.Remove(values);
            context.SaveChanges();
            MessageBox.Show("Kategori silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            var values = context.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
            values.CategoryName = txtad.Text;
            values.CategoryDetails = txtdes.Text;
            context.SaveChanges();
            MessageBox.Show("Kategori Güncellendi");
        }
    }
}
