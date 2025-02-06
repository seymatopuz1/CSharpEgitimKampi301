﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concrete;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    {
        private readonly ICategoryService _categoryService;

        public FrmCategory()
        {
            _categoryService = new CategoryManager(new EfCategoryDal());
            InitializeComponent();
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            // Ben burda servisine ulaşıp servisin üzerinde işlem yapacağım 
            var categoryvalues = _categoryService.TGetAll();
            dataGridView1.DataSource = categoryvalues;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ekleme işlemi yapmadan önce bizim entityden bir tane nesne örneği almamız lazım .
            // presenatation katmanında artık görevimiz
            //Contextten nesne örnekleyerek 

            Category category = new Category();
            category.CategoryName = txtCategoryName.Text;
            category.CategoryStatus = true;
            _categoryService.TInsert(category);
            MessageBox.Show("Ekleme işlemi başarılı!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.TDelete(deletedValues);
            MessageBox.Show("Silme işlemi başarılı");

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var values = _categoryService.TGetById(id);
            dataGridView1 .DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            int updatedId = int.Parse(txtCategoryId.Text);
            var updatedValue = _categoryService.TGetById(updatedId);
            updatedValue.CategoryName = txtCategoryName.Text;
            updatedValue.CategoryStatus = true;
            _categoryService.TUpdate(updatedValue);
            MessageBox.Show("Güncelleme işlemi başarılı");
        }
    }
}
