using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace EyeCatchGenerator
{
    public partial class MainForm : Form
    {
        private bool Initialized { get; set; } = false;
        private Image ImageOriginal { get; set; } = null;
        private Image ImageResize { get; set; } = null;
        private Size OriginalImageSize { get; set; } = Size.Empty;

        public MainForm()
        {
            InitializeComponent();

            Icon = Properties.Resources.image;

            cmbSize.SelectedIndex = 0;
            Initialized = true;
        }

        private void pnlNavigate_DragDrop(object sender, DragEventArgs e)
        {
            var filePath = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
            SetImage(filePath);
        }

        private void SetImage(string imagePath)
        {
            var ext = Path.GetExtension(imagePath).ToUpper();

            if (!(ext == ".PNG" ||
                ext == ".ICO" ||
                ext == ".JPEG" ||
                ext == ".JPG" ||
                ext == ".BMP"))
                return;

            ControlEnableChange(true);

            using (var fst = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                ImageOriginal = Image.FromStream(fst);
                OriginalImageSize = ImageOriginal.Size;

                txtSizeW.Text = ImageOriginal.Width.ToString();
                txtSizeH.Text = ImageOriginal.Height.ToString();

                txtFilePath.Text = imagePath;
            }

            cmbSize_SelectedIndexChanged(null, null);
        }

        private void pnlImage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var drags = e.Data.GetData(DataFormats.FileDrop) as string[];
                if (drags.Length != 1) return;
                if (!File.Exists(drags[0])) return;

                e.Effect = DragDropEffects.Copy;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ControlEnableChange(false);

            picImage.Image?.Dispose();
            picImage.Image = null;
            pnlImage.BringToFront();

            OriginalImageSize = Size.Empty;

            ImageOriginal?.Dispose();
            ImageOriginal = null;

            ImageResize?.Dispose();
            ImageResize = null;

            rdoTitleAHLeft.Checked = true;
            rdoTitleAVCenter.Checked = true;

            cmbSize.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picImage.Image == null) return;

            using(var dlg = new SaveFileDialog())
            {
                dlg.Filter = "Image|*.png;*.bmp;*.jpeg;*.jpg";

                if (DialogResult.OK == dlg.ShowDialog())
                {
                    using (var image = new Bitmap(ImageResize))
                    using (var g = Graphics.FromImage(image))
                    {
                        DrawImage(g);

                        image.Save(dlg.FileName);
                    }
                }
            }
        }

        private void btnFileSearch_Click(object sender, EventArgs e)
        {
            using(var dlg = new OpenFileDialog())
            {
                dlg.Multiselect = false;
                dlg.Filter = "Image|*.png;*.bmp;*.jpeg;*.jpg";
                if(DialogResult.OK == dlg.ShowDialog())
                {
                    SetImage(dlg.FileName);
                }
            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;
            cmbSize_SelectedIndexChanged(null, null);
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;

            Size size = Size.Empty;
            if (cmbSize.SelectedIndex == 0)
            {
                size = OriginalImageSize;
            }
            else if (cmbSize.SelectedIndex == 1)
            {
                if(int.TryParse(txtSizeW.Text, out int w) && int.TryParse(txtSizeH.Text, out int h) && 0 < w && 0 < h)
                {
                    size = new Size(w, h);
                }
                else
                {
                    return;
                }
            }
            else if (cmbSize.SelectedIndex == 2)
            {
                size = new Size(300, (int)(OriginalImageSize.Height * ((double)300) / (double)OriginalImageSize.Width));
            }
            else if(cmbSize.SelectedIndex == 3)
            {
                size = new Size(500, (int)(OriginalImageSize.Height * ((double)500) / (double)OriginalImageSize.Width));
            }
            else if( cmbSize.SelectedIndex == 4)
            {
                size = new Size(700, (int)(OriginalImageSize.Height * ((double)700) / (double)OriginalImageSize.Width));
            }

            if(ImageOriginal != null)
            {
                ImageResize = ResizeImage(ImageOriginal, size.Width, size.Height);
                picImage.Image?.Dispose();
                picImage.Image = null;
                picImage.Image = ImageResize.Clone() as Image;

                txtSizeW.Text = size.Width.ToString();
                txtSizeH.Text = size.Height.ToString();
            }

            txtSizeW.Enabled = (cmbSize.SelectedIndex == 1);
            txtSizeH.Enabled = (cmbSize.SelectedIndex == 1);

            picImage.Invalidate();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;
            picImage.Invalidate();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == fontDialog.ShowDialog())
            {
                picImage.Invalidate();
            }
        }

        private void rdoTitleAlign_CheckedChanged(object sender, EventArgs e)
        {
            if (!Initialized) return;
            picImage.Invalidate();
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog.ShowDialog())
            {
                picImage.Invalidate();
            }
        }

        private void picImage_Paint(object sender, PaintEventArgs e)
        {
            if (!Initialized) return;
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            g.DrawImage(ImageResize, 0, 0, ImageResize.Width, ImageResize.Height);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.HighQuality;
            var p = GetTitlePosition(txtTitle.Text, fontDialog.Font, ImageResize.Size);

            using(var brush = new SolidBrush(colorDialog.Color))
            {
                g.DrawString(txtTitle.Text, fontDialog.Font, brush, p);
            }
        }

        private void ControlEnableChange(bool enabled)
        {
            foreach (var ctl in gpSettings.Controls.OfType<Control>())
            {
                if (ctl is TextBox txt)
                {
                    txt.Text = "";
                }

                if (ctl.Name == "txtFilePath" ||
                    ctl.Name == "btnFileSearch" ||
                    ctl.Name == "txtSizeW" ||
                    ctl.Name == "txtSizeH" ||
                    ctl.Name == "btnReset" ||
                    ctl is Label)
                    continue;

                ctl.Enabled = enabled;

                if (ctl is GroupBox)
                {
                    foreach (var chk in ctl.Controls.OfType<Control>())
                    {
                        chk.Enabled = enabled;
                    }
                }

                lblNavigate1.Visible = !enabled;
                lblNavigate2.Visible = !enabled;
                btnSave.Enabled = enabled;
                picImage.Visible = enabled;
            }
        }

        public static Image ResizeImage(Image image, int width, int height)
        {
            var destinationRect = new Rectangle(0, 0, width, height);
            var destinationImage = new Bitmap(width, height);

            destinationImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destinationImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destinationRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destinationImage;
        }

        private Point GetTitlePosition(string title, Font font, Size size)
        {
            int offset = 20;
            int x = 0;
            int y = 0;

            using(var g = Graphics.FromImage(new Bitmap(size.Width, size.Height)))
            {
                var titleSize = g.MeasureString(title, font, size.Width, new StringFormat(StringFormatFlags.MeasureTrailingSpaces));

                if (rdoTitleAHLeft.Checked)
                {
                    x = offset;
                }
                else if (rdoTitleAHCenter.Checked)
                {
                    x = (size.Width - (int)titleSize.Width) / 2;
                }
                else if (rdoTitleAHRight.Checked)
                {
                    x = (size.Width - (int)titleSize.Width) - offset;
                }

                if (rdoTitleAVTop.Checked)
                {
                    y = offset;
                }
                else if (rdoTitleAVCenter.Checked)
                {
                    y = (size.Height - (int)titleSize.Height) / 2;
                }
                else if (rdoTitleAVBottom.Checked)
                {
                    y = (size.Height - (int)titleSize.Height) - offset;
                }
            }

            return new Point(x, y);
        }
    }
}
