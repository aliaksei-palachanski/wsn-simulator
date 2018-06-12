using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WsnSimulator.Models;

namespace WsnSimulator.Forms
{
    public partial class MainForm : Form
    {
        private int Rounds = 1000;

        public MainForm()
        {
            InitializeComponent();
        }

        public Network Network { get; set; }

        private void setupNetworkButton_Click(object sender, EventArgs e)
        {
            this.SetupNetwork();
            this.runOneStepButton.Enabled = true;
            this.runButton.Enabled = true;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            this.SetupRun();
        }

        private void runOneStepButton_Click(object sender, EventArgs e)
        {
            this.RunOneStep();
        }

        private void SetupNetwork()
        {
            int xMin = 0;
            int xMax = (int)this.xSizeNumericUpDown.Value;
            int yMin = 0;
            int yMax = (int)this.ySizeNumericUpDown.Value;
            int nodesCount = (int)this.nodesCountNumericUpDown.Value;
            this.Network = new Network(nodesCount, xMin, xMax, yMin, yMax);
            this.DrawNetwork();
        }

        private void DrawNetwork()
        {
            if (this.Network == null)
            {
                return;
            }

            var g = this.simulationPanel.CreateGraphics();
            g.Clear(Color.White);
            var nodesBrush = new SolidBrush(Color.Black);
            this.Network.Nodes.ForEach(node =>
            {
                g.FillRectangle(nodesBrush, node.XCoord, node.YCoord, 2,2);
            });

            nodesBrush.Dispose();
            g.Dispose();
        }

        private bool stop = false;

        private void RunOneStep()
        {
            this.Network.Move();
            this.DrawNetwork();
        }

        private void SetupRun()
        {
            this.stop = false;
            this.Run();
        }

        private void Run()
        {
            for (var i = 0; i < this.Rounds; i++)
            {
                this.RunOneStep();
            }
        }
    }
}
