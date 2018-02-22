using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace albumFormative
{
    public partial class MainScreen : UserControl
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        List<string> originalOrder = new List<string>();
        List<string> sortedOrder;
        string inputAlbum;

        private void MainScreen_Load(object sender, EventArgs e)
        {
            ReplaceItems(originalOrder);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            inputAlbum = inputTextBox.Text;
            originalOrder.Add(inputAlbum);
            sortedOrder = new List<string>(originalOrder);
            ReplaceItems(sortedOrder);
        }

        public void ReplaceItems(List<string> sortOrder)
        {
            originalListBox.Items.Clear();
            sortListBox.Items.Clear();

            originalListBox.Items.Add("Original Order");
            originalListBox.Items.Add("****************");
            sortListBox.Items.Add("Sorted Order");
            sortListBox.Items.Add("***************");

            sortOrder.Sort();

            for (int i = 0; i < originalOrder.Count(); i++)
            {
                originalListBox.Items.Add(originalOrder[i]);
                sortListBox.Items.Add(sortOrder[i]);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            inputAlbum = inputTextBox.Text;
            if (originalOrder.Contains(inputAlbum))
            {
                originalOrder.Remove(inputAlbum);
                sortedOrder = new List<string>(originalOrder);
                ReplaceItems(sortedOrder);
            }
            else
            {
                MessageBox.Show("Album not found!");
            }         
        }       
    }
}
