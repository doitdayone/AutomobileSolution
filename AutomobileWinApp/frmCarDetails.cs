using System.ComponentModel.DataAnnotations;
using AutomobileLibrary.BussinessObject;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp
{
    public partial class frmCarDetails : Form
    {
        public frmCarDetails()
        {
            InitializeComponent();
        }
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // False? Insert : Update
        public Car CarInfo { get; set; }


        private void Form1_Load(object sender, EventArgs e)
        {

            txtID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtID.Text = CarInfo.CarID.ToString();
                txtName.Text = CarInfo.CarName.ToString();
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.YearRelease.ToString();
                cboManufactor.Text = CarInfo.Manufactor.ToString().Trim();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car car = new Car()
                {
                    CarID = int.Parse(txtID.Text),
                    CarName = txtName.Text,
                    Manufactor = cboManufactor.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    YearRelease = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrUpdate == true)
                {
                    CarRepository.UpdateCar(car);
                }
                else
                {
                    CarRepository.InsertCar(car);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a car" : "Udapte a car"); }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}