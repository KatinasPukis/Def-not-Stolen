using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Linq.Expressions;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private int closestNeighbours;

        internal Point iPointToDrag;
        bool bDragFlag;

        private int searchRadius;
        private Pen radiusPen;

        int formWidth, formHeight;

        internal int radius; internal int GetRadius() { return radius; }

        List<Point> arGreenPoints;
        internal bool isGreensSelected;

        List<Point> arYellowPoints;
        internal bool isYellowsSelected;

        List<Point> arRedPoints;
        internal bool isRedsSelected;

        List<Point> arBluePoints;
        internal bool isBluesSelected;

        private Point candidate;
        internal bool isCandidateSelected;
        internal bool isCandidateSet;
        List<Neighbour> tempList = new List<Neighbour>();
        bool nxBlt = false;
        int MAXs;


        public Form1()
        {
            closestNeighbours = 5; // default paieskos skaicius


            InitializeComponent();
            DoubleBuffered = true;
            radius = 5;

            searchRadius = 0;
            radiusPen = new Pen(Color.White, 1);

            isRedsSelected = true;
            bDragFlag = false;
            formWidth = this.Width;
            formHeight = this.Height;

            arRedPoints = new List<Point>();
            isRedsSelected = true;

            arBluePoints = new List<Point>();
            arGreenPoints = new List<Point>();
            arYellowPoints = new List<Point>();

            isCandidateSet = false;

            Paint += new PaintEventHandler(Form1_Paint);
            MouseDown += button1_MouseDown;


            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            MouseUp += MouseUpper;

            MouseMove += new MouseEventHandler(MouseMoving);

        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            try
            {

                foreach (var x in arRedPoints)
                {
                    int xCentered = x.X - radius;
                    int yCentered = x.Y - radius;

                    g.FillEllipse(Brushes.Red, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));

                }

                foreach (var x in arBluePoints)
                {
                    int xCentered = x.X - radius;
                    int yCentered = x.Y - radius;

                    g.FillEllipse(Brushes.Blue, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));

                }
                foreach (var x in arYellowPoints)
                {
                    int xCentered = x.X - radius;
                    int yCentered = x.Y - radius;

                    g.FillEllipse(Brushes.Yellow, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));

                }
                foreach (var x in arGreenPoints)
                {
                    int xCentered = x.X - radius;
                    int yCentered = x.Y - radius;

                    g.FillEllipse(Brushes.Green, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));

                }

                if (isCandidateSet)
                {
                    int xCentered = candidate.X - radius;
                    int yCentered = candidate.Y - radius;
                    g.FillEllipse(Brushes.White, new Rectangle(xCentered, yCentered, radius * 2, radius * 2));
                    g.DrawEllipse(radiusPen
                        , candidate.X - searchRadius, candidate.Y - searchRadius
                        , searchRadius * 2, searchRadius * 2);


                }


            }
            catch (Exception) { g.Clear(System.Drawing.SystemColors.ActiveCaption); }
        }



        void ClearScreen()
        {
            arRedPoints = new List<Point>();
            arBluePoints = new List<Point>();
            arYellowPoints = new List<Point>();
            arGreenPoints = new List<Point>();
            isCandidateSet = false;
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }
        void button1_MouseDown(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < arRedPoints.Count; i++)
            {
                if (((arRedPoints[i].X - radius < e.Location.X) && (arRedPoints[i].X + 2 * radius > e.Location.X)) &&
                    ((arRedPoints[i].Y - radius < e.Location.Y) && (arRedPoints[i].Y + 2 * radius > e.Location.Y)))
                {
                    setReds();
                    bDragFlag = true;
                    Cursor = Cursors.Hand;
                    iPointToDrag = arRedPoints[i];
                    arRedPoints.Remove(iPointToDrag);
                    Refresh();
                    return;
                }
            }
            for (int i = 0; i < arBluePoints.Count; i++)
            {
                if (((arBluePoints[i].X - radius < e.Location.X) && (arBluePoints[i].X + 2 * radius > e.Location.X)) &&
                    ((arBluePoints[i].Y - radius < e.Location.Y) && (arBluePoints[i].Y + 2 * radius > e.Location.Y)))
                {
                    setBlues();
                    bDragFlag = true;
                    Cursor = Cursors.Hand;
                    iPointToDrag = arBluePoints[i];
                    arBluePoints.Remove(iPointToDrag);
                    Refresh();
                    return;
                }
            }
            for (int i = 0; i < arYellowPoints.Count; i++)
            {
                if (((arYellowPoints[i].X - radius < e.Location.X) && (arYellowPoints[i].X + 2 * radius > e.Location.X)) &&
                    ((arYellowPoints[i].Y - radius < e.Location.Y) && (arYellowPoints[i].Y + 2 * radius > e.Location.Y)))
                {
                    setYellows();
                    bDragFlag = true;
                    Cursor = Cursors.Hand;
                    iPointToDrag = arYellowPoints[i];
                    arYellowPoints.Remove(iPointToDrag);
                    Refresh();
                    return;
                }
            }
            for (int i = 0; i < arGreenPoints.Count; i++)
            {
                if (((arGreenPoints[i].X - radius < e.Location.X) && (arGreenPoints[i].X + 2 * radius > e.Location.X)) &&
                    ((arGreenPoints[i].Y - radius < e.Location.Y) && (arGreenPoints[i].Y + 2 * radius > e.Location.Y)))
                {
                    setGreens();
                    bDragFlag = true;
                    Cursor = Cursors.Hand;
                    iPointToDrag = arGreenPoints[i];
                    arGreenPoints.Remove(iPointToDrag);
                    Refresh();
                    return;
                }
            }

            if (isRedsSelected)
            { arRedPoints.Add(new Point(e.Location.X, e.Location.Y)); Refresh(); return; }

            if (isBluesSelected)
            { arBluePoints.Add(new Point(e.Location.X, e.Location.Y)); Refresh(); return; }

            if (isYellowsSelected)
            { arYellowPoints.Add(new Point(e.Location.X, e.Location.Y)); Refresh(); return; }

            if (isGreensSelected)
            { arGreenPoints.Add(new Point(e.Location.X, e.Location.Y)); Refresh(); return; }

            if (isCandidateSelected)
            {
                candidate = new Point(e.Location.X, e.Location.Y);
                isCandidateSet = true;
            }
            Refresh();
        }

        void MouseMoving(object sender, MouseEventArgs e)
        {
            if (bDragFlag)
            {
                iPointToDrag.X = e.Location.X;
                iPointToDrag.Y = e.Location.Y;

            }
        }

        void MouseUpper(object sender, MouseEventArgs e)
        {
            if (bDragFlag)
            {
                Cursor = Cursors.Cross;
                if (isRedsSelected) arRedPoints.Add(iPointToDrag);
                if (isBluesSelected) arBluePoints.Add(iPointToDrag);
                if (isYellowsSelected) arYellowPoints.Add(iPointToDrag);
                if (isGreensSelected) arGreenPoints.Add(iPointToDrag);
                bDragFlag = false;
                Refresh();
            }
        }

        // check key up
        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case (Keys.Escape):
                    ClearScreen(); break;
                case (Keys.Oemplus):


                default: break;
            }

            e.Handled = true;

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            Refresh();


        }

        // geltona
        private void button2_Click(object sender, EventArgs e)
        {
            setYellows();
        }
        // zalia
        private void button3_Click(object sender, EventArgs e)
        {
            setGreens();
        }
        private void bluesButton_Click(object sender, EventArgs e)
        {
            setBlues();
        }

        private void redsButton_Click(object sender, EventArgs e)
        {
            setReds();
        }

        void setYellows()
        {
            isCandidateSelected = false;
            isBluesSelected = false;
            isRedsSelected = false;
            isYellowsSelected = true;
            isGreensSelected = false;

        }
        void setGreens()
        {
            isCandidateSelected = false;
            isBluesSelected = false;
            isRedsSelected = false;
            isYellowsSelected = false;
            isGreensSelected = true;
        }


        void setReds()
        {
            isCandidateSelected = false;
            isBluesSelected = false;
            isRedsSelected = true;
            isYellowsSelected = false;
            isGreensSelected = false;
        }

        void setBlues()
        {
            isCandidateSelected = false;
            isBluesSelected = true;
            isRedsSelected = false;
            isYellowsSelected = false;
            isGreensSelected = false;
        }
        private void candidateButton_Click(object sender, EventArgs e)
        {
            setCandidate();
        }

        void setCandidate()

        {
            isCandidateSelected = true;
            isBluesSelected = false;
            isRedsSelected = false;
            isGreensSelected = false;
            isYellowsSelected = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            MAXs = 0;
            getResult();
        }

        // grisk dar ce
        private void getResult()
        {
            String resultMessage = "";
            if (isCandidateSet)
            {

                List<Neighbour> neighbours = new List<Neighbour>();
                int id = 0;
                foreach (var x in arYellowPoints)
                    neighbours.Add(new Neighbour(++id, matchDistance(candidate, x), "yellow"));
                foreach (var x in arGreenPoints)
                    neighbours.Add(new Neighbour(++id, matchDistance(candidate, x), "green"));
                foreach (var x in arRedPoints)
                    neighbours.Add(new Neighbour(++id, matchDistance(candidate, x), "red"));
                foreach (var x in arBluePoints)
                    neighbours.Add(new Neighbour(++id, matchDistance(candidate, x), "blue"));

                neighbours = neighbours.OrderBy(x => x.distanceToCandidate)
                    .Take(closestNeighbours).ToList();


                int longestDistance = (int)neighbours.Last().distanceToCandidate + radius;
                for (searchRadius = 0; searchRadius < longestDistance; searchRadius++) Refresh();
                searchRadius = 0;

                int reds = neighbours.Where(x => x.label == "red").Count();
                int blues = neighbours.Where(x => x.label == "blue").Count();
                int yellows = neighbours.Where(x => x.label == "yellow").Count();
                int greens = neighbours.Where(x => x.label == "green").Count();
                tempList = neighbours;
                int[] array = { reds, blues, yellows, greens };
                int max = array.Max();
                foreach (var item in array)
                {
                    if (max == item)
                        MAXs++;
                }
                closestNiggers.Clear();
                UpdateLabels(array);
                if (MAXs == 1)
                {
                    if (blues == max)
                        MessageBox.Show("Kandidatas atitinka mėlynos spalvos požymius");
                    if (reds == max)
                        MessageBox.Show("Kandidatas atitinka raudonos spalvos požymius");
                    if (yellows == max)
                        MessageBox.Show("Kandidatas atitinka geltonos spalvos požymius");
                    if (greens == max)
                        MessageBox.Show("Kandidatas atitinka žalios spalvos požymius");
                }
                if (MAXs == 2)
                {
                    if (blues == reds && blues == max && reds == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "red" || item.label == "blue")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                    if (blues == greens && blues == max && greens == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "blue" || item.label == "green")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                    if (blues == yellows && blues == max && yellows == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "blue" || item.label == "yellow")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                    if (reds == greens && reds == max && greens == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "red" || item.label == "green")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    };
                    if (reds == yellows && yellows == max && reds == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "red" || item.label == "yellow")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                    if (yellows == greens && yellows == max && greens == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "yellow" || item.label == "green")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                }
                if (MAXs == 3)
                {
                    if (greens == yellows && yellows == reds && greens == max && yellows == max && reds == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "green" || item.label == "yellow" || item.label == "red")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                    if (greens == yellows && yellows == blues && greens == max && yellows == max && blues == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "yellow" || item.label == "blue" || item.label == "green")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                    if (yellows == reds && reds == blues && yellows == max && reds == max && blues == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "yellow" || item.label == "red" || item.label == "blue")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                    if (greens == reds && reds == blues && greens == max && reds == max && blues == max)
                    {
                        foreach (Neighbour item in neighbours)
                        {
                            if (item.label == "green" || item.label == "red" || item.label == "blue")
                            {
                                MessageBox.Show("Kandidatas atitinka " + item.label + " spalvos požymius");
                                break;
                            }
                        }
                    }
                }

                if (MAXs == 4)
                {
                    if (neighbours.First().label == "red") MessageBox.Show("Kandidatas atitinka raudonos spalvos požymius");
                    if (neighbours.First().label == "blue") MessageBox.Show("Kandidatas atitinka mėlynos spalvos požymius");
                    if (neighbours.First().label == "yellow") MessageBox.Show("Kandidatas atitinka geltonos spalvos požymius");
                    if (neighbours.First().label == "green") MessageBox.Show("Kandidatas atitinka žalios spalvos požymius");
                }

                //if (blues == reds && blues == max && reds == max)
                //{
                //    nxBlt = true;
                //}
                //if (blues == greens && blues == max && greens == max) {
                //    nxBlt = true;
                //}
                //if (blues == yellows && blues == max && yellows == max)
                //{
                //    nxBlt = true;
                //}
                //if (reds == greens && reds == max && greens == max) {
                //    nxBlt = true;
                //};
                //if (reds == yellows && yellows == max && reds == max)
                //{
                //    nxBlt = true;
                //}
                //if (yellows == greens && yellows == max && greens == max)
                //{ 
                //    nxBlt = true;
                //}
            //    foreach (var item in array)
            //    {
                    
            //            UpdateLabels(array);
            //            if (nxBlt == true)
            //            {
            //                if (neighbours.First().label == "red") MessageBox.Show("Kandidatas atitinka raudonos spalvos požymius");
            //                if (neighbours.First().label == "blue") MessageBox.Show("Kandidatas atitinka mėlynos spalvos požymius");
            //                if (neighbours.First().label == "yellow") MessageBox.Show("Kandidatas atitinka geltonos spalvos požymius");
            //                if (neighbours.First().label == "green") MessageBox.Show("Kandidatas atitinka žalios spalvos požymius");
            //                break;
            //            }
            //            else if (reds == max) { MessageBox.Show("Kandidatas atitinka raudonos spalvos požymius"); break; }
            //            else if (blues == max) { MessageBox.Show("Kandidatas atitinka mėlynos spalvos požymius"); break; }
            //            else if (greens == max) { MessageBox.Show("Kandidatas atitinka žalios spalvos požymius"); break; }
            //            else if (yellows == max) { MessageBox.Show("Kandidatas atitinka geltonos spalvos požymius"); break; }
            //    }

            //}
            //else
            //{
            //    resultMessage = "Pamiršote įdėti kandidatą";
            }

        }
        public string CheckColorName(int[] array, int max)
        {
            UpdateLabels(array);
            if (array[0] == max)
            {

                return "Red";
            }
            if (array[1] == max)
            {

                return "Blue";
            }
            if (array[2] == max)
            {

                return "Yellow";
            }
            if (array[3] == max)
            {

                return "Green";
            }
            return null;
        }

        private void UpdateLabels(int[] array)
        {
            label6.Text = array[0].ToString();
            label8.Text = array[1].ToString();
            label4.Text = array[2].ToString();
            label3.Text = array[3].ToString();
            foreach (var item in tempList)
            {
                closestNiggers.Text += item.id + ".  " + "spalva: " + item.label + "; atstumas: " + item.distanceToCandidate + ";\n\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.TryParse(neighborsComboBox.Text, out closestNeighbours)) ;

            else neighborsComboBox.Text = "Put here int";
        }



        internal double matchDistance(Point a, Point b)
        {
            double xdif = a.X - b.X;
            double ydif = a.Y - b.Y;
            return Math.Sqrt(xdif * xdif + ydif * ydif);
        }

    }

    class myPointDelta
    {
        public int x, y;
        public myPointDelta(int X, int Y) { x = X; y = Y; }
    }
    class Neighbour
    {
        public int id;
        public double distanceToCandidate;
        public String label;

        public Neighbour(int id, double dist, String label)
        {
            this.id = id;
            this.distanceToCandidate = dist;
            this.label = label;
        }
    }

}
