using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDropAuto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSourceDrag_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSourceDrag.DoDragDrop(buttonSourceDrag.Text, DragDropEffects.Copy);
        }
        
        private void textBoxTargetDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void textBoxTargetDrop_DragDrop(object sender, DragEventArgs e)
        {
            string text = (string)e.Data.GetData(DataFormats.Text);
            textBoxTargetDrop.Text = text;
        }

        private void buttonSourceDrag1_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSourceDrag1.DoDragDrop(buttonSourceDrag1.Text, DragDropEffects.Copy);
        }

        private void pictureBoxSourceDrag_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox temp = sender as PictureBox;
            temp.DoDragDrop(temp.Image, DragDropEffects.Copy);
        }

        private void panelTargetDrag_DragEnter(object sender, DragEventArgs e)
        {
            // проверить тип данных для перетаскивания
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelTargetDrag_DragDrop(object sender, DragEventArgs e)
        {
            Image img = (Image)e.Data.GetData(DataFormats.Bitmap);
            panelTargetDrag.BackgroundImage = img;

        }
        ListBox temp = null;
        private void listBoxColors_MouseDown(object sender, MouseEventArgs e)
        {
            temp = sender as ListBox;
            temp.DoDragDrop(temp.SelectedIndex.ToString(), DragDropEffects.Copy);
           
        }

        private void listBoxFruits_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void listBoxFruits_DragDrop(object sender, DragEventArgs e)
        {
            int index = Convert.ToInt32(e.Data.GetData(DataFormats.Text));
            // тупой вариант
            //string tempStr = (string)listBoxColors.Items[index];
            //listBoxColors.Items[index] = listBoxFruits.Items[index];
            //listBoxFruits.Items[index] = tempStr;

            // умный вариант
            ListBox source = temp;
            ListBox target = sender as ListBox;
            if (source != target)
            {
                string tempStr = (string)source.Items[index];
                source.Items[index] = target.Items[index];
                target.Items[index] = tempStr;
            }

        }
    }
}
