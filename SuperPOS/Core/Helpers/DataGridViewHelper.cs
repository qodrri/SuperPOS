using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SuperPOS.Core.Helpers
{
    internal class DataGridViewHelper
    {
        // Method untuk mengenerate kolom button pada DataGridView
        public static void GenerateColumnButon(DataGridView dataGridView, int index, string name)
        {
            if (dataGridView.Columns.Contains(name) == false)
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn
                {
                    Name = name,
                    HeaderText = name,
                    UseColumnTextForButtonValue = true,
                    Width = 64,
                };
                dataGridView.Columns.Insert(index, btn);
            }
        }

        // Method untuk mengenerate icon di kolom button pada DataGridView
        public static void AddColumnButtonIcon(DataGridViewCellPaintingEventArgs e, string fileName, int index)
        {
            if (e.ColumnIndex == index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var width = 44; // Lebar icon
                var height = 44; // Tinggi icon
                var x = e.CellBounds.Left + (e.CellBounds.Width - width) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - height) / 2;
                var currentDirectory = Directory.GetCurrentDirectory();
                var iconPath = Path.Combine(currentDirectory, "icons", fileName + ".png");
                var img = Image.FromFile(iconPath, true);
                e.Graphics.DrawImage(img, new Rectangle(x, y, width, height));
                e.Handled = true;
            }
        }

        // Method untuk mengenerate icon update di kolom button pada DataGridView
        public static void AddColumnButtonUpdate(DataGridViewCellPaintingEventArgs e, int index)
        {
            AddColumnButtonIcon(e, SuperPosHelper.ICON_EDIT, index);
        }

        // Method untuk mengenerate icon delete di kolom button pada DataGridView
        public static void AddColumnButtonDelete(DataGridViewCellPaintingEventArgs e, int index)
        {
            AddColumnButtonIcon(e, SuperPosHelper.ICON_DELETE, index);
        }

        // Method untuk memperbarui warna baris data pada DataGridView
        public static void UpdateDataGridViewBackgroundColor(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }
    }
}
