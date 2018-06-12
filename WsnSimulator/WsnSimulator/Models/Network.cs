using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WsnSimulator.Models
{
    public class Network
    {
        public Network(int nodesCount, int xMin, int xMax, int yMin, int yMax)
        {
            this.nodesCount = nodesCount;
            this.xMin = xMin;
            this.xMax = xMax;
            this.yMin = yMin;
            this.yMax = yMax;
            Setup();
        }

        private int nodesCount;
        private int xMin;
        private int xMax;
        private int yMin;
        private int yMax;

        public List<Node> Nodes { get; set; }

        public void Setup()
        {
            this.Nodes = new List<Node>();
            var rnd = new Random();
            for (var i = 0; i < this.nodesCount; i++)
            {
                var xInit = 0;
                var yInit = 0;
                do
                {
                    xInit = rnd.Next(xMin, xMax);
                    yInit = rnd.Next(yMin, yMax);
                } while (!this.validateInitialCoordines(xInit, yInit));

                this.Nodes.Add(new Node(this.xMin, this.xMax, this.yMin, this.yMax, xInit,yInit,rnd));
            }
        }

        public void Move()
        {
            this.Nodes.ForEach(node => node.Move());
        }

        private bool validateInitialCoordines(int x, int y)
        {
            // coordinates not valid if there is already a node with such coordinates
            var xNodes = Nodes?.Where(node => node.XCoord == x);
            if (xNodes == null || !xNodes.Any())
            {
                return true;
            }
            var yNodes = xNodes.Where(node => node.YCoord == y);
            if (yNodes != null && yNodes.Any())
            {
                return false;
            }
            return true;
        }
    }
}