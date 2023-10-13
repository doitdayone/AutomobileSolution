using AutomobileLibrary.Repository;
using AutomobileLibrary.BussinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp
{
    public partial class frmCarManagement : Form
    {
        public frmCarManagement()
        {
            InitializeComponent();
        }
        ICarRepository carRepository = new CarRepository();
        BindingSource source;

        public ICarRepository CarRepository { get; private set; }

        private void frmCarManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dgvCarList.DoubleClick += DgvCarList_DoubleClick;
        }

        private void DgvCarList_DoubleClick(object? sender, EventArgs e)
        {
            frmCarDetails frmCarDetails = new frmCarDetails()
            {
                Text = "Update Car",
                InsertOrUpdate = true,
                CarInfo = GetCarObject(),
                CarRepository = carRepository
            };

            if (frmCarDetails.ShowDialog() == DialogResult.OK)
            {
                LoadCarList();
                source.Position = source.Count - 1;
            }
        }
        private Car GetCarObject()
        {
            Car car = null;
            try
            {
                car = new Car()
                {
                    CarID = int.Parse(txtID.Text),
                    CarName = txtName.Text,
                    Manufactor = txtManufactor.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    YearRelease = int.Parse(txtReleaseYear.Text)
                };

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Get Car"); }
            return car;
        }
        private void LoadCarList()
        {
            var cars = carRepository.GetCars();
            try
            {
                source = new BindingSource();
                source.DataSource = cars;

                txtID.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtManufactor.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseYear.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "CarID");
                txtName.DataBindings.Add("Text", source, "CarName");
                txtManufactor.DataBindings.Add("Text", source, "Manufactor");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseYear.DataBindings.Add("Text", source, "YearRelease");

                dgvCarList.DataSource = null;
                dgvCarList.DataSource = source;
                if (cars.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    ClearText();
                }
                else btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car list");
            }
        }

        private void ClearText()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtManufactor.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCarList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            {
                frmCarDetails frmCarDetails = new frmCarDetails()
                {
                    Text = "Insert Car",
                    InsertOrUpdate = false,
                    CarRepository = carRepository
                };

                if (frmCarDetails.ShowDialog() == DialogResult.OK)
                {
                    LoadCarList();
                    source.Position = source.Count - 1;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadCarList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Delete a car"); }
        }
    }
}
