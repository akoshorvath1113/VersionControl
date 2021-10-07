using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace NegyedikHet_LKX2MO
{
    public partial class Form1 : Form
    {
        List<Flat> Flats;
        RealEstateEntities1 context = new RealEstateEntities1();
        excel.Application xlApp;
        excel.Workbook xlWB; 
        excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
           Flats=context.Flats.ToList();
        }
    }
}
