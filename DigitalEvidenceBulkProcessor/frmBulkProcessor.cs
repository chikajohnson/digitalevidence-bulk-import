//using DigitalEvidenceBulkProcessor.Data;
using DigitalEvidenceBulkProcessor.Data;
using ExcelDataReader;
using Newtonsoft.Json.Linq;
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


namespace DigitalEvidenceBulkProcessor
{
    public partial class frmBulkPRocessor : Form
    {
        private List<IZUUser> users;
        private IEnumerable<IZUUser> existingTellers;
        private readonly BankEyeIzuEntities db;
        private const string tellerRole = "teller";
        private string tabNewUserText = "Loaded Users";
        private string tabExistingUsersText = "Existing Users";

        public frmBulkPRocessor()
        {
            InitializeComponent();

            db = new BankEyeIzuEntities();
            users = new List<IZUUser>();
            var modules = new List<Module>();
            modules.Add(new Module { Name = "Select Module", Value = "" });
            modules.Add(new Module { Name = "Users", Value = "izuusers" });

            cmbModule.DataSource = modules;
            cmbModule.DisplayMember = "Name";
            cmbModule.ValueMember = "Value";
            cmbModule.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        DataTableCollection tableCollections;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            var fName = string.Empty;

            if (cmbModule.SelectedIndex <= -1)
            {
                MessageBox.Show("Select a Module");
                return;
            }
            using (OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Excel WorkBook |*.xlsx| Excel 97 -2003 WorkBook (*.xls)|*.xls",
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFileName.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollections = result.Tables;
                            cmbSheets.Items.Clear();
                            foreach (DataTable table in tableCollections)
                            {
                                cmbSheets.Items.Add(table.TableName);
                            }
                        }
                    }
                }

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (existingTellers.Count() > 0)
            {
                MessageBox.Show($"{existingTellers.Count()} of these users already exist in the database. Remove these users from  Excel file and try again.", "Users Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (users.Count() <= 0)
            {
                MessageBox.Show($"Users Grid  is empty. Load new users and continue", "No Users Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new BankEyeIzuEntities())
            {
                try
                {
                    db.IZUUsers.AddRange(users);
                    db.SaveChanges();

                    MessageBox.Show($"{users.Count} users imported successfully");

                    ResetDataSources();
                    ResetControlTexts();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblSheet_Click(object sender, EventArgs e)
        {

        }

        private void cmbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollections[cmbSheets.SelectedItem.ToString()];
            usersDataGridView.DataSource = dt;
            var role = db.IZURoles.SingleOrDefault(x => x.RoleID.ToLower() == tellerRole);

            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var user = new IZUUser();

                    user.UserID = dt.Rows[i]["UserID"].ToString();
                    user.BranchCode = dt.Rows[i]["BranchCode"].ToString();
                    user.UserNames = dt.Rows[i]["UserNames"].ToString();
                    user.Password = Hasher.HashPassword(dt.Rows[i]["Password"].ToString());
                    user.ResetPassword = Convert.ToBoolean(false);
                    user.CanRegister = Convert.ToBoolean(role.CanRegister);
                    user.CaptureImage = Convert.ToBoolean(role.CaptureImage);
                    user.BrowseTransaction = Convert.ToBoolean(role.BrowseTransaction);
                    user.Upload = Convert.ToBoolean(role.Upload);
                    user.SetupUser = Convert.ToBoolean(role.SetupUser);
                    user.SetupBranch = Convert.ToBoolean(role.SetupBranch);
                    user.SetUpSystemParameters = Convert.ToBoolean(role.SetUpSystemParameters);
                    user.SetUpTranscopeParameters = Convert.ToBoolean(role.SetUpTranscopeParameters);
                    user.AddUser = Convert.ToBoolean(role.AddUser);
                    user.EditUser = Convert.ToBoolean(role.EditUser);
                    user.BrowseUser = Convert.ToBoolean(role.BrowseUser);
                    user.DeleteUser = Convert.ToBoolean(role.DeleteUser);
                    user.AddCountry = Convert.ToBoolean(role.AddCountry);
                    user.EditCountry = Convert.ToBoolean(role.EditCountry);
                    user.BrowseCountry = Convert.ToBoolean(role.BrowseCountry);
                    user.DeleteCountry = Convert.ToBoolean(role.DeleteCountry);
                    user.AddState = Convert.ToBoolean(role.AddState);
                    user.EditState = Convert.ToBoolean(role.EditState);
                    user.BrowseState = Convert.ToBoolean(role.BrowseState);
                    user.DeleteState = Convert.ToBoolean(role.DeleteState);
                    user.AddTransactionCategory = Convert.ToBoolean(role.AddTransactionCategory);
                    user.EditTransactionCategory = Convert.ToBoolean(role.EditTransactionCategory);
                    user.BrowseTransactionCategory = Convert.ToBoolean(role.BrowseTransactionCategory);
                    user.DeleteTransactionCategory = Convert.ToBoolean(role.DeleteTransactionCategory);
                    user.ViewReports = Convert.ToBoolean(role.DeleteTransactionCategory);
                    user.ExportTransaction = Convert.ToBoolean(role.ExportTransaction);
                    user.PrintTransaction = Convert.ToBoolean(role.PrintTransaction);
                    user.SuperUser = Convert.ToBoolean(role.SuperUser);
                    user.Suspended = Convert.ToBoolean(role.Suspended);
                    user.CreatedBy = "bulkprocessor|administrator";
                    user.LastUpdatedBy = "bulkprocessor|administrator";
                    user.LastUpdatedOn = DateTime.Now;
                    user.LastLogOn = DateTime.Now;
                    user.CanConfigurePollData = Convert.ToBoolean(role.CanConfigurePollData);
                    user.CanConfigureDataMover = Convert.ToBoolean(role.CanConfigureDataMover);

                    users.Add(user);
                }

                existingTellers = GetExistingUsers(users);
                if (existingTellers.Count() > 0)
                {
                    tabTellers.TabPages.Remove(tabExistingUsers);
                    tabTellers.TabPages.Add(tabExistingUsers);
                    existingDataGridView.DataSource = existingTellers;
                    tabExistingUsers.Text = tabExistingUsersText + $" ({existingTellers.Count()})";

                }

                var tellers = JArray.FromObject(users).ToObject<IEnumerable<UserModel>>();
                userModelBindingSource.DataSource = tellers;
                tabNewUsers.Text = tabNewUserText + $" ({tellers.Count()})";

            }
        }

        private void usersDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //MessageBox.Show("grid changed");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetDataSources();
            ResetControlTexts();
        }

        private void ResetControlTexts()
        {
            txtFileName.Text = string.Empty;
            cmbSheets.Text = string.Empty;
            tabNewUsers.Text = tabNewUserText;
            tabExistingUsers.Text = tabExistingUsersText;
            tabTellers.TabPages.Remove(tabExistingUsers);
        }

        private void ResetDataSources()
        {
            usersDataGridView.DataSource = null;
            userModelBindingSource.DataSource = null;

            usersDataGridView.ResetBindings();
            existingDataGridView.ResetBindings();

            tabNewUsers.Text = tabNewUserText;
            tabExistingUsers.Text = tabExistingUsersText;

            users.Clear();
            cmbSheets.Items.Clear();
        }

        private void frmBulkPRocessor_Load(object sender, EventArgs e)
        {
            tabTellers.TabPages.Remove(tabExistingUsers);
        }

        private void usersDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AddDataGridSerialNumber(e, usersDataGridView);
        }

        private void AddDataGridSerialNumber(DataGridViewRowPostPaintEventArgs e, DataGridView dataGridView)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            while (strRowNumber.Length < dataGridView.RowCount.ToString().Length)
            {
                strRowNumber = "0" + strRowNumber;
            }
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);

            if (dataGridView.RowHeadersWidth < (int)(size.Width + 20))
            {
                dataGridView.RowHeadersWidth = (int)(size.Width + 20);
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private IEnumerable<IZUUser> GetExistingUsers(List<IZUUser> users)
        {
            var result = new List<IZUUser>();
            var existingUserIds = users.Select(x => x.UserID).ToList();
            using (var db = new BankEyeIzuEntities())
            {
                result = db.IZUUsers.Where(x => existingUserIds.Contains(x.UserID)).ToList();
            }

            return result;
        }

        private void existingDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            AddDataGridSerialNumber(e, existingDataGridView);
        }

        private string[] GetExistingBranchCodes()
        {
            string[] existingBranchCodes = null;
            //write your codes below here



            //write your codes above here
            return existingBranchCodes;
        }
    }
}
