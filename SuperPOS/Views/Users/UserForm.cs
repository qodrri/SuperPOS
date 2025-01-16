using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using SuperPOS.Core.Helpers;
using SuperPOS.Models;
using SuperPOS.Repositories.UserRepository;
using SuperPOS.Views.Commons;
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
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace SuperPOS.Views.Users
{
    public partial class UserForm : Form
    {
        private readonly IUserRepository _userRepository;
        private List<User> _dataUsers = new List<User>();
        private User _selectedUser;
        public UserForm()
        {
            InitializeComponent();
            _userRepository = Program.ServiceProvider.GetService<IUserRepository>();
        }

        private async Task LoadUserData(string keyword = "")
        {
            try
            {
                var users = await _userRepository.GetAllAsync(keyword);
                if (users != null)
                {
                    _dataUsers.Clear();
                    _dataUsers = users;
                    dataGridViewMain.Rows.Clear();
                    if (_dataUsers.Count > 0)
                    {
                        dataGridViewMain.Rows.Add(_dataUsers.Count);
                        for (int i = 0; i < _dataUsers.Count; i++)
                        {
                            dataGridViewMain.Rows[i].Height = 48;
                            var user = _dataUsers[i];
                            dataGridViewMain.Rows[i].Cells[0].Value = i + 1;
                            dataGridViewMain.Rows[i].Cells[1].Value = user.Username;
                            dataGridViewMain.Rows[i].Cells[2].Value = user.Firstname;
                            dataGridViewMain.Rows[i].Cells[3].Value = user.Lastname;
                            dataGridViewMain.Rows[i].Cells[4].Value = user.Email;
                            dataGridViewMain.Rows[i].Cells[5].Value = user.Phone;
                            dataGridViewMain.Rows[i].Cells[6].Value = user.IsAdmin;
                        }

                        // Generate kolom button
                        DataGridViewHelper.GenerateColumnButon(dataGridViewMain, 7, SuperPosHelper.ACTION_EDIT);
                        DataGridViewHelper.GenerateColumnButon(dataGridViewMain, 8, SuperPosHelper.ACTION_DELETE);
                        // Mempebarui warna baris data
                        DataGridViewHelper.UpdateDataGridViewBackgroundColor(dataGridViewMain);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat data user: {ex.ToString()}");
            }
        }

        private async void UserForm_Load(object sender, EventArgs e)
        {
            await LoadUserData();
        }

        private void dataGridViewMain_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _dataUsers.Count) return;
            if (e.ColumnIndex == 7)
            {
                DataGridViewHelper.AddColumnButtonUpdate(e, 7);
            }
            else if (e.ColumnIndex == 8)
            {
                DataGridViewHelper.AddColumnButtonDelete(e, 8);
            }
        }

        private async void iconButtonNew_Click(object sender, EventArgs e)
        {
            using (var userEntryForm = new UserEntryForm())
            {
                if (userEntryForm.ShowDialog() == DialogResult.OK)
                {
                    // Menyimpan data user
                    await _userRepository.CreateAsync(userEntryForm.NewUser);

                    await LoadUserData();
                }
            }
        }

        private async void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _selectedUser = _dataUsers[e.RowIndex];
            if (e.ColumnIndex == dataGridViewMain.Columns[SuperPosHelper.ACTION_DELETE].Index)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    await _userRepository.DeleteAsync(_selectedUser.Id);
                    MessageBox.Show("Data user berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadUserData();
                }
            }
            else if (e.ColumnIndex == dataGridViewMain.Columns[SuperPosHelper.ACTION_EDIT].Index)
            {
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin mengubah data user ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (var userEntryForm = new UserEntryForm())
                    {
                        // Set data user yang akan diubah
                        userEntryForm.UpdateUser = _selectedUser;
                        if (userEntryForm.ShowDialog() == DialogResult.OK)
                        {
                            // Menyimpan perubahan data user
                            await _userRepository.UpdateAsync(userEntryForm.UpdateUser);
                            await LoadUserData();
                        }
                    }
                }
            }
        }

        private async void iconButtonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSearch.Text))
            {
                await LoadUserData();
            }
            else
            {
                await LoadUserData(textBoxSearch.Text);
            }
        }

        private void iconButtonDownload_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Simpan data user";
                saveFileDialog.FileName = "Data User";
                saveFileDialog.DefaultExt = ".xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Mendeklarasikan lisensi EPPlus
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    // Membuat file baru
                    using (var ep = new ExcelPackage())
                    {
                        // Membuat worksheet
                        ExcelWorksheet ws = ep.Workbook.Worksheets.Add("User");
                        // Membuat file header berdasarkan nama kolom
                        for (int i = 0; i < dataGridViewMain.Columns.Count - 2; i++)
                        {
                            ws.Cells[1, i + 1].Value = dataGridViewMain.Columns[i].HeaderText;
                        }
                        // Menambahkan data ke dalam file
                        for (int i = 0; i < dataGridViewMain.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridViewMain.Columns.Count - 2; j++)
                            {
                                ws.Cells[i + 2, j + 1].Value = dataGridViewMain.Rows[i].Cells[j].Value;
                            }
                        }

                        // Menyimpan file
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        ep.SaveAs(fileInfo);
                        MessageBox.Show("Data user berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void iconButtonPrint_Click(object sender, EventArgs e)
        {
            // Variabel bantu untuk nomor baris
            int rowNumber = 1;
            // Membuat dataset
            DataSet dataSet = new DataSet();
            // Membuat data table
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("No", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Firstname", typeof(string));
            dataTable.Columns.Add("Lastname", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("IsAdmin", typeof(bool));
            // Menambahkan data ke dalam data table
            foreach (var user in _dataUsers)
            {
                dataTable.Rows.Add(rowNumber, user.Username, user.Firstname, user.Lastname, user.Email, user.Phone, user.IsAdmin);
                rowNumber++;
            }
            // Menambahkan data table ke dalam dataset
            dataSet.Tables.Add(dataTable);
            // Membuat file report dalam format XML
            dataSet.WriteXml("UserReport.xml");
            // Cetak file report
            using (var printForm = new PrintForm())
            {
                var userReport = new UserCrystalReport();
                userReport.SetDataSource(dataSet);
                printForm.crystalReportViewerMain.ReportSource = userReport;
                printForm.crystalReportViewerMain.Refresh();
                printForm.ShowDialog();
            }
        }
    }
}
