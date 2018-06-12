using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsnSimulator.Models
{
    public class Node
    {
        public Node(int xMin, int xMax, int yMin, int yMax, int xInit, int yInit, Random rnd)
        {
            this.xMin = xMin;
            this.xMax = xMax;
            this.yMin = yMin;
            this.yMax = yMax;
            this.rnd = rnd;

            this.XCoord = xInit;
            this.YCoord = yInit;

            Init();
        }

        private int xMin;
        private int xMax;
        private int yMin;
        private int yMax;

        private int energyMax = 100;
        private int maxSpeed = 3;
        private Random rnd;

        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int Energy { get; set; }


        private void Init()
        {
            this.SetInitialEnergy();
        }

        private void SetInitialEnergy()
        {
            this.Energy = this.energyMax;
        }

        public void Move()
        {
            int xDelta = 0;
            int yDelta = 0;
            do
            {
                xDelta = this.rnd.Next(-this.maxSpeed, this.maxSpeed + 1);
                yDelta = this.rnd.Next(-this.maxSpeed, this.maxSpeed + 1);
                if (xDelta >= 3 || yDelta >= 3)
                {
                    var a = 1;
                }
            } while (!this.ValidateNewCoordinates(xDelta, yDelta));
            this.XCoord += xDelta;
            this.YCoord += yDelta;
        }

        private bool ValidateNewCoordinates(int xDelta, int yDelta)
        {
            var xCoordNew = this.XCoord + xDelta;
            if (xCoordNew <= this.xMin || xCoordNew >= this.xMax)
            {
                return false;
            }
            var yCoordNew = this.YCoord + yDelta;
            if (yCoordNew <= this.yMin || yCoordNew >= this.yMax)
            {
                return false;
            }
            return true;
        }
    }
}