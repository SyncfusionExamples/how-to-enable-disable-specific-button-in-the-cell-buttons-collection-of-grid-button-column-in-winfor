using SfDataGrid_Demo;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Data;
using Syncfusion.Data;
using System.Collections.Generic;

namespace SfDataGrid_Demo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        

        /// <summary>
        /// Initializes the new instance for the Form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            sfDataGrid1.AutoGenerateColumns = false;
            sfDataGrid1.DataSource = GetDataTable();

            List<CellButton> buttons = new List<CellButton>();
            buttons.Add(new CellButton() { Text = "Button1"});
            buttons.Add(new CellButton() { Text = "Button2" });
            buttons.Add(new CellButton() { Text = "Button3" });
            this.sfDataGrid1.Columns.Add(new GridButtonColumn()
            {
                Buttons = buttons
            });

            this.sfDataGrid1.QueryButtonCellStyle += OnSfDataGrid_QueryButtonCellStyle;
        }

        private void OnSfDataGrid_QueryButtonCellStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryButtonCellStyleEventArgs e)
        {
            if (e.Button.Text == "Button2" && e.RowIndex % 3 == 0)
            {
                e.Style.Enabled = false;
            }
        }

        public DataTable GetDataTable()
        {
            string[] productName = new string[]
         {
            "Alice Mutton",
            "NuNuCa Nuß-Nougat-Creme",
            "Boston Crab Meat",
            "Raclette Courdavault",
            "Wimmers gute",
            "Gorgonzola Telino",
            "Chartreuse verte",
            "Fløtemysost",
            "Carnarvon Tigers",
            "Thüringer",
            "Vegie-spread",
            "Tarte au sucre",
            "Konbu",
            "Valkoinen suklaa",
            "Queso Manchego",
            "Perth Pasties",
            "Vegie-spread",
            "Tofu",
            "Sir Rodney's",
            "Manjimup Dried Apples"
         };

            string[] CustomerID = new string[]
      {
            "ALFKI",
            "FRANS",
            "MEREP",
            "FOLKO",
            "SIMOB",
            "WARTH",
            "VAFFE",
            "FURIB",
            "SEVES",
            "LINOD",
            "RISCU",
            "PICCO",
            "BLONP",
            "WELLI",
            "FOLIG",
            "SHIWL",
            "ASDFI",
            "YIWOL",
            "SIEPZ",
            "UIKOC",
            "BNUTQ",
            "FDKIO",
            "UJIKW",
            "QOLPX",
            "WJXKO",
            "SXEWD",
            "ZXSOL",
            "KKMJU",
            "QMICP",
            "SJWII",
            "WDOPO",
            "SAIOP",
            "SSOLE",
            "CUEMC",
            "HWIMQ"
      };

            var table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("CustomerName", typeof(string));
            table.Columns.Add("StoreID", typeof(int));
            table.Columns.Add("ProductName", typeof(string));


            Random r = new Random();
            table.Rows.Add(17, CustomerID[r.Next(1, 15)], 1001, productName[r.Next(5)]);
            table.Rows.Add(18, CustomerID[r.Next(1, 15)], 1001, productName[r.Next(5)]);

            table.Rows.Add(19, CustomerID[r.Next(1, 15)], 1003, productName[r.Next(5)]);
            table.Rows.Add(20, CustomerID[r.Next(1, 15)], 1003, productName[r.Next(5)]);

            table.Rows.Add(21, CustomerID[r.Next(1, 15)], 1005, productName[r.Next(5)]);

            table.Rows.Add(23, CustomerID[r.Next(1, 15)], 1006, productName[r.Next(5)]);
            table.Rows.Add(24, CustomerID[r.Next(1, 15)], 1006, productName[r.Next(5)]);
            table.Rows.Add(25, CustomerID[r.Next(1, 15)], 1006, productName[r.Next(5)]);
            table.Rows.Add(26, CustomerID[r.Next(1, 15)], 1006, productName[r.Next(5)]);
            table.Rows.Add(27, CustomerID[r.Next(1, 15)], 1006, productName[r.Next(5)]);
            table.Rows.Add(28, CustomerID[r.Next(1, 15)], 1006, productName[r.Next(5)]);

            table.Rows.Add(29, CustomerID[r.Next(1, 15)], 1007, productName[r.Next(5)]);
            table.Rows.Add(30, CustomerID[r.Next(1, 15)], 1007, productName[r.Next(5)]);
            table.Rows.Add(31, CustomerID[r.Next(1, 15)], 1007, productName[r.Next(5)]);
            table.Rows.Add(32, CustomerID[r.Next(1, 15)], 1007, productName[r.Next(5)]);

            table.Rows.Add(33, CustomerID[r.Next(1, 15)], 1008, productName[r.Next(5)]);
            table.Rows.Add(34, CustomerID[r.Next(1, 15)], 1008, productName[r.Next(5)]);
            table.Rows.Add(35, CustomerID[r.Next(1, 15)], 1008, productName[r.Next(5)]);
            table.Rows.Add(36, CustomerID[r.Next(1, 15)], 1008, productName[r.Next(5)]);

            return table;
        }
    }


    
}
