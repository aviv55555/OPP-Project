using finalProjOOP.Backend;
using finalProjOOP.Backend.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace finalProjOOP
{
    public partial class FormMain : Form
    {
        // private bool dragging = false;
        //private Point startPoint=new Point(0,0);
        public FormMain()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(VehiclesManager.SaveVehicles);
            //this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        /////////////////////////////////HOME/////////////////////////////
        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelOnbuttonHome.Height = buttonHome.Height;
            panelOnbuttonHome.Top = buttonHome.Top;
            HomePanel.Visible = true;
            pnlLandVehicles.Visible = false;
            MarinePanel.Visible = false;
            Allpanel.Visible = false;
            AboutPanel.Visible = false;
            CarFormPanel.Visible = false;
            MotorbikeFormPanel.Visible = false;
            buttonHome.BackColor = Color.White;
            Landbutton.BackColor = Color.Transparent;
            Marinebutton.BackColor = Color.Transparent;
            Allbutton.BackColor = Color.Transparent;
            buttonAbout.BackColor = Color.Transparent;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            HomePanel.Visible = true;
            pnlLandVehicles.Visible = false;
            MarinePanel.Visible = false;
            Allpanel.Visible = false;
            AboutPanel.Visible = false;
            CarFormPanel.Visible = false;
            MotorbikeFormPanel.Visible = false;
            buttonHome.BackColor = Color.White;
            Landbutton.BackColor = Color.Transparent;
            Marinebutton.BackColor = Color.Transparent;
            Allbutton.BackColor = Color.Transparent;
            buttonAbout.BackColor = Color.Transparent;
            WindowState = FormWindowState.Normal;
        }
        /////////////////////////////////LANDVEHICLES/////////////////////////////
        private void Landbutton_Click(object sender, EventArgs e)
        {
            panelOnButtonLand.Height = Landbutton.Height;
            panelOnButtonLand.Top = Landbutton.Top;
            pnlLandVehicles.Visible = true;
            HomePanel.Visible = false;
            MarinePanel.Visible = false;
            Allpanel.Visible = false;
            AboutPanel.Visible = false;
            CarFormPanel.Visible = false;
            MotorbikeFormPanel.Visible = false;
            buttonHome.BackColor = Color.Transparent;
            Landbutton.BackColor = Color.White;
            Marinebutton.BackColor = Color.Transparent;
            Allbutton.BackColor = Color.Transparent;
            buttonAbout.BackColor = Color.Transparent;
        }


        ////////////////////////////////ALL/////////////////////////////////
        private void Allbutton_Click(object sender, EventArgs e)
        {
            panelOnButtonAll.Height = Allbutton.Height;
            panelOnButtonAll.Top = Allbutton.Top;
            Allpanel.Visible = true;
            MarinePanel.Visible = false;
            pnlLandVehicles.Visible = false;
            HomePanel.Visible = false;
            AboutPanel.Visible = false;
            CarFormPanel.Visible = false;
            MotorbikeFormPanel.Visible = false;
            buttonHome.BackColor = Color.Transparent;
            Landbutton.BackColor = Color.Transparent;
            Marinebutton.BackColor = Color.Transparent;
            Allbutton.BackColor = Color.White;
            buttonAbout.BackColor = Color.Transparent;
            AllDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Narkisim", 13);
            AllDataGridView.DefaultCellStyle.Font = new Font("Narkisim", 13);
            AllDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Vehicle>();
            
        }
        private void AllChoosecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllChoosecomboBox.SelectedItem.ToString() == "All")
            {
                AllDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Vehicle>();
                SearchButton.Visible = true;
                SearchtextBox.Visible = true;
                randomButton.Visible = false;
                pictureBoxRandom.Visible = false;
            }
            else
            {
                randomButton.Visible = true;
                pictureBoxRandom.Visible = true;
                SearchButton.Visible = false;
                SearchtextBox.Visible = false;
            }
            if (AllChoosecomboBox.SelectedItem.ToString() == "Marine Vehicle")
                AllDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<MarineVehicle>();
            if (AllChoosecomboBox.SelectedItem.ToString() == "Land Vehicle")
                AllDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<LandVehicle>();
            if (AllChoosecomboBox.SelectedItem.ToString() == "Cars")
                AllDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Car>();
            if (AllChoosecomboBox.SelectedItem.ToString() == "MotorCycles")
                AllDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Motorcycle>();

        }
        /////////////////////////////////ABOUT/////////////////////////////
        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panelOnButtonAbout.Height = Aboutbutton.Height;
            panelOnButtonAbout.Top = Aboutbutton.Top;
            AboutPanel.Visible = true;
            Allpanel.Visible = false;
            MarinePanel.Visible = false;
            pnlLandVehicles.Visible = false;
            HomePanel.Visible = false;
            CarFormPanel.Visible = false;
            MotorbikeFormPanel.Visible = false;
            buttonHome.BackColor = Color.Transparent;
            Landbutton.BackColor = Color.Transparent;
            Marinebutton.BackColor = Color.Transparent;
            Allbutton.BackColor = Color.Transparent;
            buttonAbout.BackColor = Color.White;
        }

        /////////////////////////////Close/Minimize/MaximizeeButtons/////////////////////////////


        private void pictureBoxRed_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want exit?", "Alert!!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("GOOD-BYE!");
                Close();
            }
            if (res == DialogResult.No || res == DialogResult.Cancel)
                return;
        }

        private void pictureBoxYellow_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBoxGreen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        /////////////////////////////////MARINE/////////////////////////////
        private void Marinebutton_Click(object sender, EventArgs e)
        {
            panelOnButtonMarine.Height = Marinebutton.Height;
            panelOnButtonMarine.Top = Marinebutton.Top;
            MarinePanel.Visible = true;
            pnlLandVehicles.Visible = false;
            HomePanel.Visible = false;
            Allpanel.Visible = false;
            AboutPanel.Visible = false;
            CarFormPanel.Visible = false;
            MotorbikeFormPanel.Visible = false;
            buttonHome.BackColor = Color.Transparent;
            Landbutton.BackColor = Color.Transparent;
            Marinebutton.BackColor = Color.White;
            Allbutton.BackColor = Color.Transparent;
            Aboutbutton.BackColor = Color.Transparent;
            MarineDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Narkisim", 13);
            MarineDataGridView.DefaultCellStyle.Font = new Font("Narkisim", 13);
            MarineDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<MarineVehicle>();
        }
    
        private void MarineClearForm()
        {
            MarineLicenseNumberTextBox.Clear();
            MarineCompanyComboBox.Text = "Choose..";
            MarineYearComboBox.Text = "Choose..";
            MarineColorTextBox.ResetText();
            MarineNumSeatsComboBox.Text = "Choose..";
            BoatPrivatecheckBox.Checked = false;
            BoatCommercialcheckBox.Checked = false;
        }
        private void MarineClearButton_Click(object sender, EventArgs e)
        {
            MarineClearForm();
        }
        private void MarineAddButton_Click(object sender, EventArgs e)
        {
            if (MarineIsValidForm())
            {
                int licenseNum = Int32.Parse(MarineLicenseNumberTextBox.Text);
                string company = MarineCompanyComboBox.SelectedItem.ToString();
                int year = Int32.Parse(MarineYearComboBox.SelectedItem.ToString());
                string color = MarineColorTextBox.Text;
                int numSeats = Int32.Parse(MarineNumSeatsComboBox.SelectedItem.ToString());
                bool privatrMarine = BoatPrivatecheckBox.Checked;
                bool commercialMarine = BoatCommercialcheckBox.Checked;
                MarineVehicle marineVehicle = new MarineVehicle(licenseNum, color, year, numSeats, company, privatrMarine, commercialMarine);
                VehiclesManager.AddVehicle(marineVehicle);
                MarineDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<MarineVehicle>();
                MarineClearForm();
            }
        }
        private bool MarineIsValidForm()
        {
            int licenseNum;
            bool flagMarine = true;
            if (!Int32.TryParse(MarineLicenseNumberTextBox.Text, out licenseNum))
            {
                MessageBox.Show("The license Number is inValid!");
                flagMarine = false;
            }
            if (MarineCompanyComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a company!");
                flagMarine = false;
            }
            if (MarineYearComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a year!");
                flagMarine = false;
            }
            if (!MarineColorTextBox.Text.All(Char.IsLetterOrDigit))
            {
                MessageBox.Show("The field accepts only letters!\nPlease Try Again");
                flagMarine = false;
            }
            if (string.IsNullOrEmpty(MarineColorTextBox.Text))
            {
                MessageBox.Show("You must enter color!");
                flagMarine = false;
            }
            if (MarineNumSeatsComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose number of seats!");
                flagMarine = false;
            }
            if (BoatCommercialcheckBox.Checked == false && BoatPrivatecheckBox.Checked == false)
            {
                MessageBox.Show("Choose kind!");
                flagMarine = false;
            }
            if (BoatCommercialcheckBox.Checked == true && BoatPrivatecheckBox.Checked == true)
            {
                MessageBox.Show("Choose only one kind!");
                flagMarine = false;
            }
            return flagMarine;
        }

        /////////////////////////////////CAR/////////////////////////////
        private void buttonCars_Click(object sender, EventArgs e)
        {
            CarFormPanel.Visible = true;
            AboutPanel.Visible = false;
            Allpanel.Visible = false;
            MarinePanel.Visible = false;
            pnlLandVehicles.Visible = false;
            HomePanel.Visible = false;
            MotorbikeFormPanel.Visible = false;
            CardataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Narkisim", 13);
            CardataGridView.DefaultCellStyle.Font = new Font("Narkisim", 13);
            CardataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Car>();
        }
        private void CarClearForm()
        {
            CarLicenseNumberTextBox.Clear();
            CarCompanyComboBox.Text = "Choose..";
            CarYearComboBox.Text = "Choose..";
            CarColorTextBox.ResetText();
            CarEngineCapacityTextBox.Text = "Choose..";
            CarFuelTypeComboBox.Text = "Choose..";
            CarGearTypeComboBox.Text = "Choose..";
            CarNumSeatsComboBox.Text = "Choose..";
            CarNumDoorsComboBox.Text = "Choose..";
        }

        private void CarClearButton_Click(object sender, EventArgs e)
        {
            CarClearForm();
        }

        private void CarAddButton_Click(object sender, EventArgs e)
        {
            if (CarIsValidForm())
            {
                int licenseNum = Int32.Parse(CarLicenseNumberTextBox.Text);
                string company = CarCompanyComboBox.SelectedItem.ToString();
                int year = Int32.Parse(CarYearComboBox.SelectedItem.ToString());
                string color = CarColorTextBox.Text;
                int engineCapacity = Int32.Parse(CarEngineCapacityTextBox.Text);
                string typeFuel = CarFuelTypeComboBox.SelectedItem.ToString();
                string gearType = CarGearTypeComboBox.SelectedItem.ToString();
                int numSeats = Int32.Parse(CarNumSeatsComboBox.SelectedItem.ToString());
                int doorsNum = Int32.Parse(CarNumDoorsComboBox.SelectedItem.ToString());
                Car car = new Car(licenseNum, color, year, numSeats, typeFuel, engineCapacity, doorsNum, company, gearType);
                VehiclesManager.AddVehicle(car);
                CardataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Car>();
                CarClearForm();
            }
        }
        private bool CarIsValidForm()
        {
            int licenseNum, engcap;
            bool Carflag = true;
            if (!Int32.TryParse(CarLicenseNumberTextBox.Text, out licenseNum))
            {
                MessageBox.Show("The license Number is inValid!");
                Carflag = false;
            }
            if (CarCompanyComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a company!");
                Carflag = false;
            }
            if (CarYearComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a year!");
                Carflag = false;
            }
            if (!CarColorTextBox.Text.All(Char.IsLetterOrDigit))
            {
                MessageBox.Show("The field accepts only letters!\nPlease Try Again");
                Carflag = false;
            }
            if (string.IsNullOrEmpty(CarColorTextBox.Text))
            {
                MessageBox.Show("You must enter color!");
                Carflag = false;
            }
            if (!Int32.TryParse(CarEngineCapacityTextBox.Text, out engcap))
            {
                MessageBox.Show("The engine capacity is inValid!");
                Carflag = false;
            }
            if (CarFuelTypeComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a fuel type!");
                Carflag = false;
            }
            if (CarGearTypeComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a gear type!");
                Carflag = false;
            }
            if (CarNumSeatsComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose number of seats!");
                Carflag = false;
            }
            if (CarNumDoorsComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose number of doors!");
                Carflag = false;
            }
            
            return Carflag;
        }

        /////////////////////////////////MOTOR/////////////////////////////
        private void buttonMotorBike_Click(object sender, EventArgs e)
        {
            MotorbikeFormPanel.Visible = true;
            CarFormPanel.Visible = false;
            AboutPanel.Visible = false;
            Allpanel.Visible = false;
            MarinePanel.Visible = false;
            pnlLandVehicles.Visible = false;
            HomePanel.Visible = false;
            MotordataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Narkisim", 13);
            MotordataGridView.DefaultCellStyle.Font = new Font("Narkisim", 13);
            MotordataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Motorcycle>();
        }

        private void MotorClearForm()
        {
            MotorLicenseNumberTextBox.Clear();
            MotorCompanyComboBox.Text = "Choose..";
            MotorYearComboBox.Text = "Choose..";
            MotorColorTextBox.Text = "Choose..";
            MotorEngineCapacityTextBox.Clear();
            MotorFuelTypeComboBox.Text = "Choose..";
            MotorNumWheelsComboBox.Text = "Choose..";
            MotorNumSeatsComboBox.Text = "Choose..";

        }
        private void MotorClearbutton_Click(object sender, EventArgs e)
        {
            MotorClearForm();
        }

        private bool MotorIsValidForm()
        {
            bool MotorFlag = true;
            int licenseNum, color;

            if (!Int32.TryParse(MotorLicenseNumberTextBox.Text, out licenseNum))
            {
                MessageBox.Show("The license Number is inValid!");
                MotorFlag = false;
            }
            if (MotorCompanyComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a company!");
                MotorFlag = false;
            }
            if (MotorYearComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a year!");
                MotorFlag = false;
            }
            if (!MotorColorTextBox.Text.All(Char.IsLetterOrDigit))
            {
                MessageBox.Show("The field accepts only letters!\nPlease Try Again");
                MotorFlag = false;
            }
            if (string.IsNullOrEmpty(MotorColorTextBox.Text))
            {
                MessageBox.Show("You must enter color!");
                MotorFlag = false;
            }
            if (!Int32.TryParse(MotorEngineCapacityTextBox.Text, out color))
            {
                MessageBox.Show("The engine capacity is inValid!");
                MotorFlag = false;
            }
            if (MotorFuelTypeComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose a fuel type!");
                MotorFlag = false;
            }
            if (MotorNumWheelsComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose number of wheels!");
                MotorFlag = false;
            }
            if (MotorNumSeatsComboBox.Text == "Choose..")
            {
                MessageBox.Show("Choose number of seats!");
                MotorFlag = false;
            }
            return MotorFlag;

        }
        private void MotorAddbutton_Click(object sender, EventArgs e)
        {
            if (MotorIsValidForm())
            {
                int licenseNum = Int32.Parse(MotorLicenseNumberTextBox.Text);
                string company = MotorCompanyComboBox.SelectedItem.ToString();
                int year = Int32.Parse(MotorYearComboBox.SelectedItem.ToString());
                string color = MotorColorTextBox.Text;
                int engineCapacity = Int32.Parse(MotorEngineCapacityTextBox.Text);
                string typeFuel = MotorFuelTypeComboBox.SelectedItem.ToString();
                int numWheels = Int32.Parse(MotorNumWheelsComboBox.SelectedItem.ToString());
                int numSeats = Int32.Parse(MotorNumSeatsComboBox.SelectedItem.ToString());
                Motorcycle motorcycle = new Motorcycle(licenseNum, color, year, numWheels, typeFuel, engineCapacity, company, numWheels);
                VehiclesManager.AddVehicle(motorcycle);
                MotordataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Motorcycle>();
                MotorClearForm();
            }

            else
                Console.WriteLine("Unvalid input!");
        }
        private void CarGamepictureBox_Click(object sender, EventArgs e)
        {
            Frontend.Forms.CarGame gameCar = new Frontend.Forms.CarGame();
            gameCar.Show();
        }
        private void MarineGamepictureBox_Click(object sender, EventArgs e)
        {
            Frontend.Forms.MarineGame1 gameMarine = new Frontend.Forms.MarineGame1();
            gameMarine.Show();
        }
        private void MotorBikePicGame_Click(object sender, EventArgs e)
        {
            Frontend.Forms.MotorBikeGame gameMotorBike = new Frontend.Forms.MotorBikeGame();
            gameMotorBike.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int SearchLicenseNumber = Int32.Parse(SearchtextBox.Text);
            int res = VehiclesManager.removeVehiclesById(SearchLicenseNumber);

            if (res == 0)
                MessageBox.Show("The Vehicle does not exist in our agency!");

            else
                MessageBox.Show("Successful Remove");

            SearchtextBox.Clear();
            AllDataGridView.DataSource = VehiclesManager.GetSpecificVehicles<Vehicle>();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            pictureBoxRandom.SizeMode = PictureBoxSizeMode.Zoom;

            if (AllChoosecomboBox.SelectedItem.ToString() == "Marine Vehicle")
            {
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b1.jpg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000); 
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b2.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b3.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b4.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b5.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b6.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b7.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b8.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b9.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\boats\\b10.jpg");
            }
            if (AllChoosecomboBox.SelectedItem.ToString() == "Land Vehicle")
            {
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c1.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c2.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m1.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m2.jpg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m5.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m6.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c3.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c4.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
            }
            if (AllChoosecomboBox.SelectedItem.ToString() == "Cars")
            {
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c1.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c2.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c3.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c4.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c5.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c6.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c7.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c8.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c9.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1000);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\cars\\c10.jpg");
            }
            if (AllChoosecomboBox.SelectedItem.ToString() == "MotorCycles")
            {
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m1.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m2.jpg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m5.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m6.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m7.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m8.jpg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m9.jpeg");
                pictureBoxRandom.Refresh();
                System.Threading.Thread.Sleep(1500);
                pictureBoxRandom.Image = new Bitmap("C:\\Users\\Aviv0\\Desktop\\Projects\\FINALPROJECTOOP\\finalProjOOP\\land\\motorbikes\\m10.jpeg");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToShortTimeString();
        }






        //private void SearchButton_Click(object sender, EventArgs e)
        //{
        //    string SearchLicenseNumber = SearchtextBox.Text;

        //    // Search for the vehicle with the entered license number
        //    Vehicle foundVehicle = null;
        //    foreach (Vehicle vehicle in vehicles)
        //    {
        //        if (vehicle.LicenseNum.ToString() == SearchLicenseNumber)
        //        {
        //            foundVehicle = vehicle;
        //            break;
        //        }
        //    }

        //    if (foundVehicle != null)
        //    {
        //        // Display the vehicle's properties in the DataGridView
        //        AllDataGridView.Rows.Clear();
        //        AllDataGridView.Rows.Add("License Number:", foundVehicle.LicenseNum);
        //        AllDataGridView.Rows.Add("Color:", foundVehicle.Color);
        //        AllDataGridView.Rows.Add("Year:", foundVehicle.Year);
        //        AllDataGridView.Rows.Add("NumSeats:", foundVehicle.NumSeats.ToString());

        //        // Check if the found vehicle is a Car
        //        if (foundVehicle is Car car)
        //        {
        //            AllDataGridView.Rows.Add("Vehicle Type:", "Car");
        //            AllDataGridView.Rows.Add("Number of Doors:", car.DoorsNum.ToString());
        //            AllDataGridView.Rows.Add("Company:", car.Company);
        //            AllDataGridView.Rows.Add("GearType:", car.GearType);
        //        }
        //        // Check if the found vehicle is a Motorcycle
        //        else if (foundVehicle is Motorcycle motorcycle)
        //        {
        //            AllDataGridView.Rows.Add("Vehicle Type:", "Motorcycle");
        //            AllDataGridView.Rows.Add("Company:", motorcycle.Company.ToString());
        //            AllDataGridView.Rows.Add("Number of Wheels:", motorcycle.NumOfWheels);
        //        }
        //        // Check if the found vehicle is a Marine Vehicle
        //        else if (foundVehicle is MarineVehicle marineVehicle)
        //        {
        //            AllDataGridView.Rows.Add("Vehicle Type:", "Marine Vehicle");
        //            AllDataGridView.Rows.Add("Company:", marineVehicle.Company);
        //            AllDataGridView.Rows.Add("PrivateMarine:", marineVehicle.PrivateMarine);
        //            AllDataGridView.Rows.Add("CommercialMarine:", marineVehicle.CommercialMarine);
        //        }
        //    }
        //    else
        //    {
        //        // Show a message box indicating the vehicle was not found
        //        MessageBox.Show("Vehicle not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }





    //private void FormMain_MouseDown(object sender, MouseEventArgs e)
    //{
    //    dragging = true;
    //    startPoint=new Point(e.X, e.Y);
    //}

    //private void FormMain_MouseUp(object sender, MouseEventArgs e)
    //{
    //    dragging=false;
    //}

    //private void FormMain_MouseMove(object sender, MouseEventArgs e)
    //{
    //    if (dragging)
    //    {
    //        Point p = PointToScreen(e.Location);
    //        Location=new Point(p.X-this.startPoint.X, p.Y-this.startPoint.Y);
    //    }
    //}
}

