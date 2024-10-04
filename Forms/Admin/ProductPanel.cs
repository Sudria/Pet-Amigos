using Pet_Amigos.Classes.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Amigos.Forms.Admin
{
    public partial class ProductPanel : UserControl
    {
        public ProductPanel()
        {
            InitializeComponent();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Validator.isValidText(TBPName.Text, "Nombre del producto");
            Validator.isValidText(CBPCategory.Text, "Categoria");
            Validator.isValidText(CBPSubcategory.Text, "Sub-Categoria");
            Validator.isValidText(CBProvider.Text, "Sub-Categoria");
            Validator.isValidNum(TBPrice.Text, "Precio");

        }

        private void BImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cargar la imagen seleccionada en el PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void BCategoryPlus_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void BSubCategoryPlus_Click(object sender, EventArgs e)
        {
            SubCategoryForm subCategoryForm = new SubCategoryForm();
            subCategoryForm.ShowDialog();
        }
    }
}
