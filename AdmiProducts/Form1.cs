using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmiProducts
{
    public partial class Form1 : Form
    {
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("CODIGO", typeof(string));
            dt.Columns.Add("PRODUCTO", typeof(string));
            dt.Columns.Add("CATEGORIA", typeof(string));
            dt.Columns.Add("PRECIO", typeof(string));
            dt.Columns.Add("STOCK", typeof(string));

            combCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }
       
        private bool RepiteCode()
        {
            

            if(dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    if (row["CODIGO"].Equals(txtbCode.Text))
                    {
                        return  true; 
                    }
                }
            }

            return false;
        }

        private bool VerificationInputs()
        {
            bool Ok = true;

            if (string.IsNullOrEmpty(txtbCode.Text)  )
            {
                
                MessageBox.Show("Campo \"CODIGO\" está vacío, Llénalo");
            }
            if (RepiteCode())
            {
                Ok = false;
                MessageBox.Show("El código ya existe, ingrese un código diferente");
            }

            if (string.IsNullOrEmpty(txtbName.Text))
            {
                Ok = false;
                MessageBox.Show("Campo \"NOMBRE\" está vacío, Llénalo");
            }

            if (combCategory.SelectedItem == null)
            {
                Ok = false;
                MessageBox.Show("Seleccione un campo en CATEGORIA");
            }

            if (!decimal.TryParse(txtbPrice.Text, out decimal price))
            {
                Ok = false;
                MessageBox.Show("Introduce dígitos en el PRECIO");
            }

            if (!int.TryParse(txtbStock.Text, out int stock))
            {
                Ok = false;
                MessageBox.Show("Introduce dígitos en el campo STOCK");
            }

            return Ok;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (VerificationInputs())
            {
                DataRow row = dt.NewRow();
                row["CODIGO"] = txtbCode.Text;
                row["PRODUCTO"] = txtbName.Text;
                row["CATEGORIA"] = combCategory.SelectedItem.ToString();
                row["PRECIO"] = txtbPrice.Text;
                row["STOCK"] = txtbStock.Text;
                dt.Rows.Add(row);

                dgvProduct.DataSource = dt.DefaultView;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (VerificationInpSearch())
            {
                if (!chbNameP.Checked)
                {

                    string categoryQuery = combQueryCategory.Text.ToString();
                    string fielCategory = string.Concat("[", dt.Columns[2].ColumnName, "]");
                    string fieldPrice = string.Concat("[", dt.Columns[3].ColumnName, "]");
                    double minprice = double.Parse(txtbQueryPriceMin.Text);
                    double maxprice = double.Parse(txtbQueryPriceMax.Text);


                    dt.DefaultView.RowFilter = $"{fieldPrice} >= {minprice} AND {fieldPrice} <= {maxprice} AND {fielCategory} = '{categoryQuery}'  ";
                    dgvProduct.DataSource = dt.DefaultView;

                }
            }
        }
        private void txtbQueryName_TextChanged(object sender, EventArgs e)
        {
            if (!chbNameP.Checked)
            {
                string fieldNameS = string.Concat("[", dt.Columns[1].ColumnName, "]");

                dt.DefaultView.RowFilter = $" {fieldNameS} LIKE '%{txtbQueryName.Text}%' ";

                dgvProduct.DataSource = dt.DefaultView;
            }
        }

        private void grpbQuery_Enter(object sender, EventArgs e)
        {
            combCategory.SelectedIndex = -1;
            combCategory.Text = "CATEGORIA";
        }
        private void grpbAddpro_Enter(object sender, EventArgs e)
        {
        }

        private bool VerificationInpSearch()
        {
            bool Ok = false;

            if (chbNameP.Checked)
            {
                if (!string.IsNullOrEmpty(txtbQueryName.Text))
                {
                    Ok = true;
                }
                else
                {
                    MessageBox.Show("El campo NOMBRE está vacío. Llénalo."); Ok = false;
                }
            }

            if (chbPricemin.Checked)
            {
                if (!string.IsNullOrEmpty(txtbQueryPriceMin.Text))
                {
                    Ok = true;
                }
                else
                {
                    MessageBox.Show("El campo \"PRECIO MÍNIMO\" debe contener dígitos."); Ok = false;
                }
            }

            if (chbPricemax.Checked)
            {
                if (!string.IsNullOrEmpty(txtbQueryPriceMax.Text))
                {
                    Ok = true;
                }
                else
                {
                    MessageBox.Show("El campo \"PRECIO MÁXIMO\" debe contener dígitos."); Ok = false;
                }
            }

            if (combQueryCategory.SelectedItem != null && !string.IsNullOrEmpty(combQueryCategory.SelectedItem.ToString()))
            {
                Ok = true;
            }
            else
            {
                MessageBox.Show("El campo \"CATEGORÍA\" debe estar seleccionado."); Ok = false;
            }


            return Ok;
        }


        private void btnOriginal_Click(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Empty;
            // Asigna la vista sin filtrar al DataGridView
            dgvProduct.DataSource = dt.DefaultView;

        }


        private void txtbQueryName_Leave(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Empty;
            dgvProduct.DataSource = dt.DefaultView;

        }
        private void ClearInput()
        {
            txtbCode.Text = string.Empty;
            txtbName.Text = string.Empty;
            txtbPrice.Text = string.Empty;
            txtbStock.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


     
    
    private void txtbCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void combCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
     

       

        private void txtbQueryPriceMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void combQueryCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbQueryPriceMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbQueryPriceMin_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lblQueryPrice_Click(object sender, EventArgs e)
        {

        }

        private void chbNameP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbPricemin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbPricemax_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbCategoty_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
