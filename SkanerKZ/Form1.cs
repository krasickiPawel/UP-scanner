using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WIA;
using System.Windows.Forms;

namespace SkanerKZ
{
    public partial class Form1 : Form
    {
        DeviceManager dm;
        Device scanner;
        ImageFile scannedImage;
        int colorMode;


        public Form1()
        {
            InitializeComponent();
            dm = new DeviceManager();
            scanner = null;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            dpiTextBox.Text = "300";
            colorMode = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= dm.DeviceInfos.Count; i++)
            {
                if (dm.DeviceInfos[i].Type.Equals(WiaDeviceType.ScannerDeviceType))
                {
                    scannerComboBox.Items.Add(dm.DeviceInfos[i].Properties["Name"].get_Value());
                }
            }
            if(scannerComboBox.Items.Count > 0)
            {
                scannerComboBox.SelectedItem = scannerComboBox.Items[0];
            }

        }

        private void scanButton_Click(object sender, EventArgs e)
        {
            if (scannerComboBox.Items.Count > 0)
            {
                string scannerName = (String)scannerComboBox.SelectedItem;
                Scan(scannerName);
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego skanera! Sprawdź czy jakikolwiek skaner jest podłączony.", "Błąd skanera", MessageBoxButtons.OK);
            }
        }

        private void Scan(String scannerName)
        {
            foreach (DeviceInfo devInfo in dm.DeviceInfos)
            {
                if (scannerName == (String)devInfo.Properties["Name"].get_Value())
                {
                    scanner = devInfo.Connect();
                }
                if (scanner != null)
                {
                    Item item = scanner.Items[1];
                    try
                    {
                        WIA.CommonDialog cmd = new WIA.CommonDialog();
                        InitScan(item);
                        //string wiaFormatBMP = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";
                        string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
                        scannedImage = (ImageFile)cmd.ShowTransfer(item, wiaFormatJPEG);
                        byte[] imgBytes = (byte[])scannedImage.FileData.get_BinaryData();
                        MemoryStream ms = new MemoryStream(imgBytes);
                        Image image = Image.FromStream(ms);
                        pictureBox.Image = image;
                    
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.StackTrace, "Błąd skanowania", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Nie można połączyć się z wybranym skanerem!", "Błąd skanera", MessageBoxButtons.OK);
                }
            }
        }

        private void InitScan(Item item)
        {

            if (dpiTextBox.Text != null)
            {
                try
                {
                    int dpi = Convert.ToInt32(dpiTextBox.Text);
                    int contrast = Convert.ToInt32(contrastScale.Value);
                    int brightness = Convert.ToInt32(brightnessScale.Value);
                    try
                    {
                        SetScannerProperties(item.Properties, "6147", dpi);
                        SetScannerProperties(item.Properties, "6148", dpi);
                        SetScannerProperties(item.Properties, "6154", brightness);
                        SetScannerProperties(item.Properties, "6155", contrast);
                        SetScannerProperties(item.Properties, "6146", colorMode);

                        foreach (WIA.Property itemProperty in item.Properties)
                        {
                            IProperty tempProperty;
                            Object tempNewProperty;

                            if (itemProperty.Name.Equals("Horizontal Resolution"))
                            {
                                tempNewProperty = dpi;
                                ((Property)itemProperty).set_Value(ref tempNewProperty);
                            }
                            else if (itemProperty.Name.Equals("Vertical Resolution"))
                            {
                                tempNewProperty = dpi;
                                ((Property)itemProperty).set_Value(ref tempNewProperty);
                            }
                            else if (itemProperty.Name.Equals("Horizontal Extent"))
                            {
                                tempNewProperty = Convert.ToInt32(dpi * 8.26);
                                ((Property)itemProperty).set_Value(ref tempNewProperty);
                            }
                            else if (itemProperty.Name.Equals("Vertical Extent"))
                            {
                                tempNewProperty = Convert.ToInt32(dpi * 11.6);
                                ((Property)itemProperty).set_Value(ref tempNewProperty);
                            }
                        }


                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.StackTrace, "Nie można ustawić atrybutów skanowania", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("DPI musi być liczbą (zakresy 100 - 600). Podano błędne DPI", "Błąd DPI", MessageBoxButtons.OK);
                }

            }
            else MessageBox.Show("Wpisz DPI", "Nie podano DPI", MessageBoxButtons.OK);


        }
        private static void SetScannerProperties(IProperties properties, object property, object value)
        {
            Property prop = properties.get_Item(ref property);
            prop.set_Value(ref value);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(pictureBox.Image != null)
            {
                Image photo = pictureBox.Image;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = DateTime.Now.ToString().Replace(' ', '_').Replace('.', ' ').Replace(':', ' ').Replace(' ', '-');
                saveFileDialog.DefaultExt = ".jpg";
                saveFileDialog.Filter = "JPeg Image|*.jpg";
                saveFileDialog.Title = "Save an Image";
                DialogResult userAnswer = saveFileDialog.ShowDialog();
                if (userAnswer == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                    photo.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            else
            {
                MessageBox.Show("Najpierw zeskanuj, później możesz zapisać skan", "Nic nie zeskanowano", MessageBoxButtons.OK);
            }
        }
        private void blackWhiteButt_CheckedChanged(object sender, EventArgs e)
        {
            colorMode = 2;
        }

        private void colorButt_CheckedChanged(object sender, EventArgs e)
        {
            colorMode = 1;
        }
        private void monoButt_CheckedChanged(object sender, EventArgs e)
        {
            colorMode = 4;
        }


        //automatycznie wygenerowany kod visual studio
        private void cotrastScale_Scroll(object sender, EventArgs e)
        {

        }

        private void brightnessScale_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
