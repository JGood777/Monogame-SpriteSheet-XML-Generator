using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace MonogameXMLGenerator
{
    public partial class Form1 : Form
    {
        Size Scalesize;
        System.Drawing.Image preload_IMG;
        bool XY_Priority = true;
        int spriteWidth;
        int spriteHeight;

        bool xPaddingBeforeRow;
        bool yPaddingBeforeRow;
        int xPadding = 0;
        int yPadding = 0;

        string FileLocation;
        //TextWriter textWriter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void radioX_Button_CheckedChanged(object sender, EventArgs e)
        {
            XY_Priority = true;

        }

        private void radioY_Button_CheckedChanged(object sender, EventArgs e)
        {
            XY_Priority = false;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Monogame Compatible Image Files| *.bmp; *.dds; *.dib; *.hdr; *.jpg; *.pfm; *.png; *.ppm; *.tga";
            openFileDialog1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Load_IMG_filetext.Text = openFileDialog1.FileName;
            FileLocation = Load_IMG_filetext.Text;
            preload_IMG = System.Drawing.Image.FromFile(FileLocation);
            pictureBox1.ImageLocation = FileLocation;
            int thumbnailWidth = preload_IMG.Width / pictureBox1.Width;
            int thumbnailHeight = preload_IMG.Height / pictureBox1.Height;

            Scalesize.Width = thumbnailWidth;
            Scalesize.Height = thumbnailHeight;

            label5.Text = "Dimensions: " + preload_IMG.Width + " x " + preload_IMG.Height;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML|*.xml";
            saveFileDialog1.ShowDialog();


        }

        private void Load_IMG_filetext_TextChanged(object sender, EventArgs e)
        {
            FileLocation = Load_IMG_filetext.Text;
        }

        private void XPaddingTextBox_TextChanged(object sender, EventArgs e)
        {
            //xPadding = (int)sender;
            //XPaddingBox = XPaddingTextBox.Text.Trim();
            if (XPaddingTextBox.Text != String.Empty)
            {
                xPadding = Int32.Parse(XPaddingTextBox.Text.Trim());
            }
            else if (XPaddingTextBox.Text == String.Empty)
            {
                xPadding = 0;
            }

        }

        private void YPaddingTextBox_TextChanged(object sender, EventArgs e)
        {

            if (YPaddingTextBox.Text != String.Empty)
            {
                yPadding = Int32.Parse(YPaddingTextBox.Text.Trim());
            }
            else if (YPaddingTextBox.Text == String.Empty)
            {
                yPadding = 0;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SpriteWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SpriteWidthTextBox.Text != String.Empty)
            {
                spriteWidth = Int32.Parse(SpriteWidthTextBox.Text.Trim());
            }
            else if (SpriteWidthTextBox.Text == String.Empty)
            {
                spriteWidth = 0;
            }
        }

        private void SpriteHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SpriteHeightTextBox.Text != String.Empty)
            {
                spriteHeight = Int32.Parse(SpriteHeightTextBox.Text.Trim());
            }
            else if (SpriteHeightTextBox.Text == String.Empty)
            {
                spriteHeight = 0;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;
                case 1:
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                /* case 2:
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    break; */
                case 2:
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
                    break;


            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            if (FileLocation != String.Empty)
            {

                //FileStream XML_File = File.Open(saveFileDialog1.FileName, FileMode.Create);
                //textWriter = new StreamWriter(XML_File);

                
                int x = 0, y = 0;
                string str_Row = "row";
                int row = 0;
                string str_column = "col";
                int column = 0;
                int key = 0;


                int tempXPadding = xPadding;
                int tempYPadding = yPadding;




                XmlTextWriter XML_Writer = new XmlTextWriter(saveFileDialog1.FileName, null);
                XML_Writer.Formatting = Formatting.Indented;
                XML_Writer.Indentation = 1;

                XML_Writer.WriteStartDocument();

                XML_Writer.WriteStartElement("XnaContent");
                XML_Writer.WriteStartElement("Asset");
                XML_Writer.WriteAttributeString("Type", "System.Collections.Generic.Dictionary[System.String, Microsoft.Xna.Framework.Rectangle]");
                XML_Writer.WriteWhitespace("\n");

                if (XY_Priority == true)
                {
                    for (y = 0; y < preload_IMG.Height; y += (spriteHeight + yPadding))
                    {

                        if (xPaddingBeforeRow == true && (y == 0))
                        {
                            yPadding = 0;
                        }
                        else if (x != 0)
                        {
                            yPadding = tempYPadding;
                        }



                        for (x = 0; x < preload_IMG.Width; x += (spriteWidth + xPadding))
                        {

                            if (xPaddingBeforeRow == false && (x == 0))
                            {
                                xPadding = 0;
                            }
                            else if (x != 0)
                            {
                                xPadding = tempXPadding;
                            }

                            XML_Writer.WriteWhitespace("\n");
                            XML_Writer.WriteStartElement("Item");
                            XML_Writer.WriteStartElement("Key");
                            XML_Writer.WriteString(str_Row + row + "_" + key);
                            XML_Writer.WriteEndElement();
                            XML_Writer.WriteStartElement("Value");
                            XML_Writer.WriteString(x + " " + y + " " + spriteWidth + " " + spriteHeight);
                            XML_Writer.WriteEndElement();
                            XML_Writer.WriteEndElement();


                            key += 1;
                        }
                        key = 0;
                        row += 1;
                        XML_Writer.WriteWhitespace("\n");

                    }
                }
                else if (XY_Priority == false)
                {
                    for (x = 0; x <= preload_IMG.Width; x += (spriteWidth + xPadding))
                    {

                        if (xPaddingBeforeRow == false && (x == 0))
                        {
                            xPadding = 0;
                        }
                        else if (x != 0)
                        {
                            xPadding = tempXPadding;
                        }

                        for (y = 0; y <= preload_IMG.Height; y += (spriteHeight + yPadding))
                        {


                            if (xPaddingBeforeRow == true && (y == 0))
                            {
                                yPadding = 0;
                            }
                            else if (x != 0)
                            {
                                yPadding = tempYPadding;
                            }

                            XML_Writer.WriteWhitespace("\n");
                            XML_Writer.WriteStartElement("Item");
                            XML_Writer.WriteStartElement("Key");
                            XML_Writer.WriteString(str_column + column + "_" + key);
                            XML_Writer.WriteEndElement();
                            XML_Writer.WriteStartElement("Value");


XML_Writer.WriteString(x + " " + y + " " + spriteWidth + " " + spriteHeight);
                            XML_Writer.WriteEndElement();
                            XML_Writer.WriteEndElement();


                            key += 1;
                        }
                        key = 0;
                        column += 1;
                        XML_Writer.WriteWhitespace("\n");
                    }

                }

                XML_Writer.WriteEndElement();
                XML_Writer.WriteEndElement();

                XML_Writer.WriteEndDocument();
                XML_Writer.Close();

            }
            
        }

        //Need to implement Sprite Regions and Empty Regions


    }
}
