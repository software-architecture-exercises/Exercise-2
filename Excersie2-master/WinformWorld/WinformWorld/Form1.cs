﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformWorld.localhost;

namespace WinformWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetAllCountries_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.WebService2 service = new localhost.WebService2(); // Khởi tạo Web Service
                var countries = service.GetAllCountries(); // Gọi phương thức GetAllCountries
                dataGridView1.DataSource = countries; // Hiển thị dữ liệu trên DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetCountryByCode_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = txtCountryCode.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a country code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService2 service = new localhost.WebService2(); // Khởi tạo Web Service
                var country = service.GetCountryByCode(countryCode); // Gọi phương thức GetCountryByCode

                if (country != null)
                {
                    dataGridView1.DataSource = new List<Country> { country }; // Hiển thị quốc gia trong DataGridView
                }
                else
                {
                    MessageBox.Show("Country not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetCityByName_Click(object sender, EventArgs e)
        {
            try
            {
                string cityName = txtCityName.Text.Trim();

                if (string.IsNullOrEmpty(cityName))
                {
                    MessageBox.Show("Please enter a city name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService2 service = new localhost.WebService2(); // Khởi tạo Web Service
                var city = service.GetCityByName(cityName); // Gọi phương thức GetCityByName

                if (city != null)
                {
                    dataGridView1.DataSource = new List<City> { city }; // Hiển thị thành phố trong DataGridView
                }
                else
                {
                    MessageBox.Show("City not found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetCitiesByCountry_Click(object sender, EventArgs e)
        {
            try
            {
                string countryCode = txtCountryCodeForCities.Text.Trim();

                if (string.IsNullOrEmpty(countryCode))
                {
                    MessageBox.Show("Please enter a country code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                localhost.WebService2 service = new localhost.WebService2(); // Khởi tạo Web Service
                var cities = service.GetCitiesByCountry(countryCode); // Gọi phương thức GetCitiesByCountry

                if (cities != null && cities.Count() > 0)
                {
                    dataGridView1.DataSource = cities; // Hiển thị danh sách thành phố trong DataGridView
                }
                else
                {
                    MessageBox.Show("No cities found for this country.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
