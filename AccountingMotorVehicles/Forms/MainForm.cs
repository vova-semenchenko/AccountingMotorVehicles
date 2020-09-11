using AccountingMotorVehicles.Engines;
using AccountingMotorVehicles.Engines.TypesInternalCombinationEngine;
using AccountingMotorVehicles.Forms;
using AccountingMotorVehicles.Interfaces;
using AccountingMotorVehicles.Vehicles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AccountingMotorVehicles
{
    public partial class MainForm : Form
    {
        List<IVehicle> vehicles = new List<IVehicle>();
        private int currentListBoxIndex;
        public MainForm()
        {
            InitializeComponent();
            #region
            //vehicles.Add(new Bus
            //{
            //    Brand = "ЗАЗ",
            //    Model = "A07А I-VAN А07А12",
            //    Engine = new Diesel
            //    {
            //        EngineBrand = "Munich Plant",
            //        EngineModel = " S54B32",
            //        Power = 130,
            //        Torque = 420,
            //        EngineVolume = 3.8,
            //        CylinderArrangement = "V-образне",
            //        CylinderCount = 8,
            //        CylinderDiameter = 87,
            //        FuelConsumption = 15,
            //        IsCompresor = true,
            //        PistonStroke = 91,
            //        ValvesCount = 24,
            //        CetaneNumber = 49,
            //        CompressionRation = 17.5,
            //        GlowPlug = "Beru PSG006",
            //        Weight = 624
            //    },
            //    Transmission = "Механіка",
            //    DriveType = "Повний",
            //    FuelTankVolume = 66,
            //    IsLuggageCompartments = false,
            //    PassengarsSeats = 26,
            //    Seats = 1,
            //    DoorCount = 3,
            //    VehicleDimensions = new Dimensions(height: 2930, width: 2240, length: 7400),
            //    Weight = 4700
            //});

            //vehicles.Add(new Car
            //{
            //    Brand = "BMW",
            //    Model = "M4",
            //    Engine = new Benzine
            //    {
            //        EngineBrand = "Munich Plant",
            //        EngineModel = " S54B32",
            //        Power = 360,
            //        Torque = 680,
            //        EngineVolume = 3.2,
            //        CylinderArrangement = "V-образне",
            //        CylinderCount = 6,
            //        CylinderDiameter = 87,
            //        FuelConsumption = 15.4,
            //        IsCompresor = true,
            //        PistonStroke = 91,
            //        ValvesCount = 24,
            //        OcataneValue = 104.3,
            //        SparkLug = "Denso IRT01-31",
            //        Weight = 149
            //    },
            //    Transmission = "Автомат",
            //    DriveType = "Задній",
            //    CarBodyType = "Седан",
            //    FuelTankVolume = 66,
            //    Seats = 4,
            //    VehicleDimensions = new Dimensions(height: 1479, width: 2993, length: 4936),
            //    Weight = 149
            //});

            //vehicles.Add(new Car
            //{
            //    Brand = "BMW",
            //    Model = "X1 18d",
            //    Engine = new Diesel
            //    {
            //        EngineBrand = "BMW",
            //        EngineModel = "B57D30C",
            //        Power = 400,
            //        Torque = 760,
            //        EngineVolume = 3.0,
            //        CylinderArrangement = "V-образне",
            //        CylinderCount = 6,
            //        CylinderDiameter = 16.2,
            //        FuelConsumption = 5.5,
            //        IsCompresor = false,
            //        PistonStroke = 145,
            //        Weight = 190,
            //        CetaneNumber = 45,
            //        CompressionRation = 16.0,
            //        GlowPlug = "Bosch Glow",
            //        ValvesCount = 24
            //    },
            //    Transmission = "Автомат",
            //    DriveType = "Повний",
            //    CarBodyType = "Седан",
            //    FuelTankVolume = 66,
            //    Seats = 5,
            //    VehicleDimensions = new Dimensions(height: 1479, width: 2993, length: 4936),
            //    Weight = 1750
            //});

            //vehicles.Add(new Car
            //{
            //    Brand = "Tesla",
            //    Model = "Model S",
            //    Engine = new Electro
            //    {
            //        Torque = 600,
            //        ElectroEngineType = "Крутой",
            //        EngineBrand = "Tesla",
            //        EngineModel = "Трифазний асинхронний двигун",
            //        Power = 416,
            //        PowerReserve = 400,
            //        Weight = 2300
            //    },
            //    Transmission = "Автомат",
            //    DriveType = "Повний",
            //    CarBodyType = "Седан",
            //    FuelTankVolume = 90,
            //    Seats = 4,
            //    VehicleDimensions = new Dimensions(height: 1435, width: 1963, length: 4976),
            //    Weight = 2175
            //});
            #endregion
        }

        private void add_vehicle_Click(object sender, EventArgs e)
        {
            IVehicle vehicle = null;
            VehicleForm newVehicleForm = new VehicleForm(vehicle);
            if (newVehicleForm.ShowDialog() == DialogResult.OK)
            {
                vehicles.Add(vehicle);
                vehiclesListBox.Items.Add(vehicle);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("vehicles.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, vehicles);
                MessageBox.Show("Файл збережено!!!\n" + Path.GetFullPath("vehicles.dat"), caption: "File saved", MessageBoxButtons.OK);
            }
        }

        private bool IsSelectedOneStudent()
        {
            if (currentListBoxIndex < 0 || currentListBoxIndex >= vehicles.Count)
            {
                MessageBox.Show("Виберіть рівно один транспортний засіб!");
                return false;
            }
            return true;
        }

        private void vehiclesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentListBoxIndex = vehiclesListBox.SelectedIndex;
            if (!IsSelectedOneStudent()) return;

            IVehicle vehicle = vehicles[currentListBoxIndex];

            vehcileTypeTextBox.Text = new VehicleTypesConverter().ConvertTo(vehicle.GetType().Name);
            brandTextBox.Text = vehicle.Brand;
            modelTextBox.Text = vehicle.Model;
            driveTypeTextBox.Text = vehicle.DriveType;
            transmissionTextBox.Text = vehicle.Transmission;
            seatsTextBox.Text = vehicle.Seats.ToString();
            weightVehicleTextBox.Text = vehicle.Weight.ToString();

            if (vehicle.Engine.GetType().Equals("Car"))
            {
                fuelTankVolumeTextBox.Text = vehicle.FuelTankVolume.ToString();
            }
            else
            {
                fuelTankVolumeLabel.Text = "Ємність батареї (кВт/год)";
                fuelTankVolumeTextBox.Text = vehicle.FuelTankVolume.ToString();
            }

            heightTextBox.Text = vehicle.VehicleDimensions.Height.ToString();
            widthTextBox.Text = vehicle.VehicleDimensions.Width.ToString();
            lengthTextBox.Text = vehicle.VehicleDimensions.Length.ToString();

            engineTypeTextBox.Text = new EngineTypesConverter().ConvertTo(vehicle.Engine.GetType().Name);
            engineBrandTextBox.Text = vehicle.Engine.EngineBrand;
            modelEngineTextBox.Text = vehicle.Engine.EngineModel;
            torqueTextBox.Text = vehicle.Engine.Torque.ToString();
            powerTextBox.Text = vehicle.Engine.Power.ToString();
            engineWeightTextBox.Text = vehicle.Engine.Weight.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream("vehicles.dat", FileMode.OpenOrCreate))
                {
                    if (fs.Length > 0)
                    {
                        vehicles = (List<IVehicle>)formatter.Deserialize(fs);
                    }
                }
                foreach (IVehicle vehicle in vehicles)
                {
                    vehiclesListBox.Items.Add(vehicle);
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show("Не вдалося знайти файл із раніше збереженими даними,\n" +
                    "починаємо З ЧИСТОГО ЛИСТА.\nДеталі помилки: " + ex.Message, caption: "File not found", MessageBoxButtons.OK);
            }
        }

        private void moreAboutEngineBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedOneStudent()) return;
            VehicleForm newVehicleForm = new VehicleForm(vehicles[currentListBoxIndex]);
            if (newVehicleForm.ShowDialog() == DialogResult.OK)
            {
                vehiclesListBox.Items[currentListBoxIndex] = vehicles[currentListBoxIndex];
            }
        }
    }
}
