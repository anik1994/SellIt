using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace SellIt
{
    public partial class WelcomeCashier : Form
    {
        StockDAO stockDao = new StockDAO();
        SelltblDAO selltblDao = new SelltblDAO();
        DataTable productSearchTable;
        DataTable cartTable;

        Double subTotal = 0, totalVat = 0, totalAmount = 0, givenAmount = 0, returnAmount = 0;
        String selectedBarcode, selectedQuantity;
        public WelcomeCashier()
        {
            InitializeComponent();

            Timer tmr = new Timer();
            tmr.Interval = 1000;//ticks every 1 second
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Start();

            this.loadProductsSearchTable();
            this.loadCartTable();
        }

        //normal methods 
        private void tmr_Tick(object sender, EventArgs e)
        {
            LblLocalTime.Text = DateTime.Now.ToString("    HH:mm:ss\ndd/MM/yyyy");
        }
        
        private void loadProductsSearchTable()
        {
            String name,stock, price, type, weight, barcode,vat;
            productSearchTable = new DataTable();
            DataSet ds = stockDao.GetProductList();
            DataTable fatchedTable = ds.Tables[0];
            
            //table.Columns.Add("ID", typeof(int));
            productSearchTable.Columns.Add("Barcode", typeof(string));
            productSearchTable.Columns.Add("Name", typeof(string));
            productSearchTable.Columns.Add("Stock", typeof(int));
            productSearchTable.Columns.Add("Price", typeof(double));
            //table.Columns.Add("pur", typeof(double));
            productSearchTable.Columns.Add("Type", typeof(string));
            productSearchTable.Columns.Add("Weight", typeof(string));
            productSearchTable.Columns.Add("Vat(%)", typeof(int));
            

            foreach (DataRow dr in fatchedTable.Rows)
            {
                //id = dr["item_id"].ToString();
                name = dr["item_name"].ToString();
                stock = dr["rest_item"].ToString();
                price = dr["selling_price"].ToString();
                //pur = dr["purhase_price"].ToString();
                type = dr["type"].ToString();
                weight = dr["weight"].ToString();
                barcode = dr["barcode"].ToString();
                vat = dr["vat"].ToString();

                productSearchTable.Rows.Add(barcode, name, stock, price, type, weight, vat);
            }
            
            dataGridViewSearchProducts.DataSource = productSearchTable;

        }
        private bool isPresentInCart(string barcode)
        {
            bool flag = false;
            foreach (DataRow dr in cartTable.Rows)
            {
                if (dr["Barcode"].ToString().Equals(barcode))
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }
        private void loadCartTable()
        {
            cartTable = new DataTable();

            cartTable.Columns.Add("Barcode", typeof(string));
            cartTable.Columns.Add("Name", typeof(string));
            cartTable.Columns.Add("Weight", typeof(string));
            cartTable.Columns.Add("Quantity", typeof(string));
            cartTable.Columns.Add("Unit Price", typeof(string));
            cartTable.Columns.Add("Vat(%)", typeof(string));

            dataGridViewCart.DataSource = cartTable;
 
        }


        //button methdos
        private void searchProducts(object sender, EventArgs e)
        {
            String code = textBoxBarcode.Text;
            textLengthChecking(code);
                
        }
        private void textLengthChecking(string code)
        {
            if (code.Length == 9)
            {
                foreach (DataRow dr in productSearchTable.Rows)
                {
                    if (dr["Barcode"].ToString().Equals(code))
                    {
                        if (!isPresentInCart(code))
                        {
                            String bcode = dr["Barcode"].ToString();
                            String name = dr["Name"].ToString();
                            String weight = dr["Weight"].ToString();
                            String quantity = "1";
                            String price = dr["Price"].ToString();
                            String vat = dr["Vat(%)"].ToString();

                            cartTable.Rows.Add(bcode, name, weight, quantity, price, vat);
                        }
                        else
                        {
                            foreach (DataRow drTemp in cartTable.Rows)
                            {
                                if (drTemp["Barcode"].ToString().Equals(code))
                                {
                                    String tempQuantity = drTemp["Quantity"].ToString();
                                    drTemp["Quantity"] = (Convert.ToInt32(tempQuantity) + 1).ToString();
                                    break;
                                }
                            }
                        }

                        String tempStock = dr["Stock"].ToString();
                        dr["Stock"] = (Convert.ToInt32(tempStock) - 1).ToString();

                        break;
                    }
                }
                dataGridViewSearchProducts.DataSource = productSearchTable;
                dataGridViewCart.DataSource = cartTable;
                textBoxBarcode.Text = "";
                calculateAmounts();
                
            }
        }
        
        private void calculateAmounts()
        {
            subTotal = 0;
            totalVat = 0;
            totalAmount = 0;
            foreach (DataRow dr in cartTable.Rows)
            {
                subTotal = subTotal + (Convert.ToDouble(dr["Unit Price"].ToString()) * Convert.ToDouble(dr["Quantity"].ToString()));
                totalVat = totalVat + ((Convert.ToDouble(dr["Unit Price"].ToString()) * Convert.ToDouble(dr["Quantity"].ToString()) * Convert.ToDouble(dr["Vat(%)"].ToString())) / 100.00);
                //returnAmount = givenAmount - Convert.ToDouble(textBoxTotalAmount.Text);
                //textBoxReturnAmount.Text = returnAmount.ToString();
            }
            totalAmount = totalAmount + subTotal + totalVat;

            textBoxSubTotal.Text = subTotal.ToString();
            textBoxTotalVat.Text = totalVat.ToString();
            textBoxTotalAmount.Text = totalAmount.ToString();
            calculateReturnAmount();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Calculator obj = new Calculator();
            obj.Show();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This software is Developed for the C# lab project ", "Software Information", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obj = new Login();
            obj.Show();
        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordChange obj = new PasswordChange();
            obj.Show();
        }

        private void textBoxGivenAmount_KeyUp(object sender, KeyEventArgs e)
        {
            calculateReturnAmount();
        }

        private void calculateReturnAmount()
        {
            String str = textBoxGivenAmount.Text;
            if (str.Equals(""))
            {
                returnAmount = 0 - totalAmount;
                textBoxReturnAmount.Text = returnAmount.ToString();
            }
            else
            {
                returnAmount = Convert.ToDouble(textBoxGivenAmount.Text) - totalAmount;
                textBoxReturnAmount.Text = returnAmount.ToString();
            }
        }

        private void textBoxBarcode_Click(object sender, EventArgs e)
        {
            textBoxBarcode.Text = "";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            WelcomeCashier obj = new WelcomeCashier();
            obj.Show();
        }

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridViewCart.Rows[index];
            selectedBarcode = selectedRow.Cells[0].Value.ToString();
            selectedQuantity = selectedRow.Cells[3].Value.ToString();

            textBoxQuantity.Text = selectedQuantity;
        }

        private void updateQuantity()
        {
            Console.WriteLine("Inside else");
            foreach (DataRow drTemp in cartTable.Rows)
            {
                if (drTemp["Barcode"].ToString().Equals(selectedBarcode))
                {
                    String tempQuantity = drTemp["Quantity"].ToString();
                    drTemp["Quantity"] = (Convert.ToInt32(tempQuantity) + Convert.ToInt32(textBoxQuantity.Text)).ToString();
                    Console.WriteLine("inside cart loop");
                    break;
                }
            }
            foreach (DataRow dr in productSearchTable.Rows)
            {
                if (dr["Barcode"].ToString().Equals(selectedBarcode))
                {
                    String tempStock = dr["Stock"].ToString();
                    dr["Stock"] = (Convert.ToInt32(tempStock) - Convert.ToInt32(textBoxQuantity.Text)).ToString();
                    Console.WriteLine("inside product loop");
                    break;
                }
            }
            dataGridViewSearchProducts.DataSource = productSearchTable;
            dataGridViewCart.DataSource = cartTable;
            calculateAmounts();
        }

        private void decrementQuantity()
        {
            foreach (DataRow drTemp in cartTable.Rows)
            {
                if (drTemp["Barcode"].ToString().Equals(selectedBarcode))
                {
                    String tempQuantity = drTemp["Quantity"].ToString();
                    drTemp["Quantity"] = (Convert.ToInt32(tempQuantity) - Convert.ToInt32(textBoxQuantity.Text)).ToString();    
                    break;
                }
            }
            foreach (DataRow dr in productSearchTable.Rows)
            {
                if (dr["Barcode"].ToString().Equals(selectedBarcode))
                {
                    String tempStock = dr["Stock"].ToString();
                    dr["Stock"] = (Convert.ToInt32(tempStock) + Convert.ToInt32(textBoxQuantity.Text)).ToString();
                    break;
                }
            }
            dataGridViewSearchProducts.DataSource = productSearchTable;
            dataGridViewCart.DataSource = cartTable;
            calculateAmounts();
        }

        private void buttonIncreasQuantity_Click(object sender, EventArgs e)
        {
            String str = textBoxQuantity.Text;
            if (str.Equals(""))
            {
                MessageBox.Show("Please Select Any Products ", "Attention!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Console.WriteLine("Inside else");
                updateQuantity();
            }
        
        }

        private void buttonDecreaseQuantity_Click(object sender, EventArgs e)
        {
            String str = textBoxQuantity.Text;
            if (str.Equals(""))
            {
                MessageBox.Show("Please Select Any Products ", "Attention!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Console.WriteLine("Inside else");
                decrementQuantity();
            }
        }

        private void removeProducts()
        {
            foreach (DataRow dr in productSearchTable.Rows)
            {
                if (dr["Barcode"].ToString().Equals(selectedBarcode))
                {
                    foreach (DataRow drTemp in cartTable.Rows)
                    {
                        if (drTemp["Barcode"].ToString().Equals(selectedBarcode))
                        {
                            String tempQuantity = drTemp["Quantity"].ToString();
                            String tempStock = dr["Stock"].ToString();
                            dr["Stock"] = (Convert.ToInt32(tempStock) + Convert.ToInt32(tempQuantity)).ToString();
                            drTemp.Delete();
                            break;
                        }
                    }
                    break;
                }
            }
            dataGridViewSearchProducts.DataSource = productSearchTable;
            dataGridViewCart.DataSource = cartTable;
            calculateAmounts();
        }
        private void buttonRemoveProducts_Click(object sender, EventArgs e)
        {
            String str = textBoxQuantity.Text;
            if (str.Equals(""))
            {
                MessageBox.Show("Please Select Any Products ", "Attention!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Console.WriteLine("Inside else");
                removeProducts();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchProducts obj = new SearchProducts();
            obj.Show();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            string sellItems = "";
            string sellQuantity = "";
            foreach (DataRow dr in productSearchTable.Rows)
            {
                stockDao.SellProduct(dr["Barcode"].ToString(), dr["Stock"].ToString());
            }
            foreach (DataRow dr in cartTable.Rows)
            {
                sellItems += dr["Barcode"].ToString()+ ",";
                sellQuantity += dr["Quantity"].ToString() + ",";
            }
            selltblDao.Insert(new SelltblDTO(sellItems, sellQuantity, subTotal.ToString(), totalVat.ToString(), totalAmount.ToString(), DateTime.Now.ToString("HH:mm:ss\ndd/MM/yyyy")));

            string path = "@E:\test";
            path +=selltblDao.getReceiptNumber();
            path+=".pdf";

            ExportDataTableToPdf(cartTable, @"E:\test.pdf", "SellIt");
                
        }

        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
           
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("SellIt", fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));
            string str = "";
            str = str + "Sub Total: " + subTotal.ToString() + "Total Vat: " + totalVat.ToString() + "Total Amount :" + totalAmount.ToString() + "Return Amount :" + returnAmount.ToString();
            
            document.Add(new Chunk(str, fntHead));
            document.Close();
            writer.Close();
            fs.Close();
            init();
        }
        void init()
        {
            this.loadProductsSearchTable();
            this.loadCartTable();
            subTotal = 0;
            totalVat = 0;
            totalAmount = 0;
            givenAmount = 0;
            returnAmount = 0;
            textBoxSubTotal.Text = "";
            textBoxTotalVat.Text = "";
            textBoxTotalAmount.Text = "";
            textBoxGivenAmount.Text = "";
            textBoxReturnAmount.Text = "";
        }

        private void buttonCustomerInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerView obj = new CustomerView();
            obj.Show();
        }
    }
}

