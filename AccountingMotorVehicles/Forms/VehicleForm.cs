using AccountingMotorVehicles.Engines;
using AccountingMotorVehicles.Engines.TypesInternalCombinationEngine;
using AccountingMotorVehicles.Interfaces;
using AccountingMotorVehicles.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingMotorVehicles.Forms
{
    public partial class VehicleForm : Form
    {
        private IVehicle vehicle;
        public VehicleForm(IVehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            vehicle = new Car
            {
                Brand = brandTextBox.Text,
                Model = modelTextBox.Text,
                Engine = new Benzine
                {
                    EngineBrand = brandTextBox.Text,
                    EngineModel = modelEngineTextBox.Text,
                    Power = (int)powerNumericUpDown.Value,
                    Torque = (int)torqueNumericUpDown.Value,
                    EngineVolume = double.Parse(engineVolumeTextBox.Text),
                    CylinderArrangement = cylinderArrangementTextBox.Text,
                    CylinderCount = (int)cylinderCountNumericUpDown.Value,
                    CylinderDiameter = double.Parse(diameterCylindraTextBox.Text),
                    FuelConsumption = (int)valveCountNumberUpDown.Value,
                    IsCompresor = compresorCheckBox.Checked,
                    OcataneValue = (int)numericUpDown1.Value,
                    PistonStroke = double.Parse(pistonStrokeTextBox.Text),
                    SparkLug = sparkPlugTextBox.Text,
                    ValvesCount = (int)valveCountNumberUpDown.Value,
                    Weight = (int)weightEngineNumericUpDown.Value,
                },
                Transmission = transmissionTextBox.Text,
                DriveType = driveTypeTextBox.Text,
                CarBodyType = bodyTypeTextBox.Text,
                FuelTankVolume = int.Parse(fuelTankVolumeTextBox.Text),
                Seats = int.Parse(seatsTextBox.Text),
                VehicleDimensions = new Dimensions(
                    height: int.Parse(heightTextBox.Text),
                    width: int.Parse(weightVehicleTextBox.Text),
                    length: int.Parse(lengthTextBox.Text)),
                Weight = int.Parse(weightVehicleTextBox.Text)
            };

            DialogResult = DialogResult.OK;
        }

        private void NewVehicleForm_Load(object sender, EventArgs e)
        {
            if (this.vehicle != null)
            {
                button1.Visible = false;
                addVehicleBtn.Visible = false;

                vehicleTypeComboBox.Text = new VehicleTypesConverter().ConvertTo(vehicle.GetType().Name);
                Car car = vehicle as Car;
                brandTextBox.Text = car.Brand;
                modelTextBox.Text = car.Model;
                transmissionTextBox.Text = car.Transmission;
                driveTypeTextBox.Text = car.DriveType;
                bodyTypeTextBox.Text = car.CarBodyType;
                fuelTankVolumeTextBox.Text = car.FuelTankVolume.ToString();
                seatsTextBox.Text = car.Seats.ToString();
                heightTextBox.Text = car.VehicleDimensions.Height.ToString();
                widthTextBox.Text = car.VehicleDimensions.Width.ToString();
                heightTextBox.Text = car.VehicleDimensions.Height.ToString();
                lengthTextBox.Text = car.VehicleDimensions.Length.ToString();
                weightVehicleTextBox.Text = car.Weight.ToString();

                engineTypesComboBox.Text = new EngineTypesConverter().ConvertTo(vehicle.Engine.GetType().Name);
                Benzine benz = vehicle.Engine as Benzine;
                engineBrandTextBox.Text = benz.EngineBrand;
                modelEngineTextBox.Text = benz.EngineModel;
                powerNumericUpDown.Value = benz.Power;
                torqueNumericUpDown.Value = benz.Torque;
                engineVolumeTextBox.Text = benz.EngineVolume.ToString();
                cylinderArrangementTextBox.Text = benz.CylinderArrangement;
                cylinderCountNumericUpDown.Value = benz.CylinderCount;
                diameterCylindraTextBox.Text = benz.CylinderDiameter.ToString();
                numericUpDown2.Value = (decimal)benz.FuelConsumption;
                compresorCheckBox.Checked = benz.IsCompresor;
                numericUpDown1.Value = (decimal)benz.OcataneValue;
                pistonStrokeTextBox.Text = benz.PistonStroke.ToString();
                sparkPlugTextBox.Text = benz.SparkLug;
                valveCountNumberUpDown.Value = benz.ValvesCount;
                weightEngineNumericUpDown.Value = benz.Weight;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
