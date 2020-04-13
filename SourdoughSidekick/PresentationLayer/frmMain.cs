using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using LogicLayer;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        public Bake _currentBake { get; private set; }

        public frmMain()
        {
            InitializeComponent();

            // A default setting for a sourdough loaf
            txtFlour.Text = "500";
            txtSalt.Text = "15";
            txtYeast.Text ="50";
            txtWater.Text = "350";

            // Save this bake information from which to calculate ratios
            _currentBake = new Bake(int.Parse(txtFlour.Text), int.Parse(txtSalt.Text), int.Parse(txtYeast.Text), int.Parse(txtWater.Text));

            
        }
              

        private void btnRecalculate_Click(object sender, EventArgs e)
        {
            // Create a new bake from the text entered
            Bake _newBake = new Bake(double.Parse(txtFlour.Text), double.Parse(txtSalt.Text), double.Parse(txtYeast.Text), double.Parse(txtWater.Text));

            // Construct a new bake using the old one as a reference for ratios
            if (_newBake.Flour != _currentBake.Flour)
            {
                _newBake = BakeLogic.Recalculate(_currentBake, _newBake, 1);
            }
            else if(_newBake.Salt != _currentBake.Salt)
            {
                _newBake = BakeLogic.Recalculate(_currentBake, _newBake, 2);
            }
            else if (_newBake.Yeast != _currentBake.Yeast)
            {
                _newBake = BakeLogic.Recalculate(_currentBake, _newBake, 3);
            }
            else if (_newBake.Water != _currentBake.Water)
            {
                _newBake = BakeLogic.Recalculate(_currentBake, _newBake, 4);
            }

            
            
            
            // Output the new amounts of ingredients
            txtFlour.Text = _newBake.Flour.ToString("N0");
            txtSalt.Text = _newBake.Salt.ToString("N0");
            txtYeast.Text = _newBake.Yeast.ToString("N0");
            txtWater.Text = _newBake.Water.ToString("N0");

            _currentBake = new Bake(double.Parse(txtFlour.Text), double.Parse(txtSalt.Text), double.Parse(txtYeast.Text), double.Parse(txtWater.Text));
        }

    }
}
