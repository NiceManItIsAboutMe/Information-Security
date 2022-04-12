using RGZ_Test;
using System.Diagnostics;
using System.Numerics;

namespace RGZ_DiffieHellman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generatePrimeNumButton_Click(object sender, EventArgs e)
        {
            int rmb = 0;
            int cbb = 0;
            Stopwatch time = new Stopwatch();
            if (!Int32.TryParse(rabinMillerBox.Text, out rmb) || rmb < 1 || !Int32.TryParse(countBitsBox.Text, out cbb) || cbb < 1)
            {
                MessageBox.Show("Вы ввели некоректные данные, количество бит и проверок должно быть больше 0");
                return;
            }
            time.Start();
            primeNumber10Box.Text=LargePrimeGenertor.Next(cbb, rmb).ToString();
            time.Stop();
            TimeSpan ts = time.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds,
            ts.Milliseconds );
            timeIterationBox.Text = "Time " + elapsedTime+Environment.NewLine+"Iterations "+LargePrimeGenertor.countIteration;
            primeNumber2Box.Text=LargePrimeGenertor.GetBinary(BigInteger.Parse(primeNumber10Box.Text));
                
        }

        private void primeNumber10Box_TextChanged(object sender, EventArgs e)
        {
            BigInteger a = 0;
            if (BigInteger.TryParse(primeNumber10Box.Text, out a))
                primeNumber2Box.Text = LargePrimeGenertor.GetBinary(BigInteger.Parse(primeNumber10Box.Text));
        }

        private void generatePrimeNumsButton_Click(object sender, EventArgs e)
        {
            
            int rmnb = 0;
            int mbb = 0;
            int maxbb = 0;
            Stopwatch time = new Stopwatch();
            if (!Int32.TryParse(rabinMillerNumsBox.Text, out rmnb) || rmnb < 1 ||
                !Int32.TryParse(minBitBox.Text, out mbb) || mbb < 1 ||
                !Int32.TryParse(maxBitBox.Text, out maxbb) || maxbb < 1 || 
                maxbb <= mbb)
            {
                MessageBox.Show("Вы ввели некоректные данные, количество бит и проверок должно быть больше 0. Максимальное количество бит должно быть больше минимального");
                return;
            }
            primeNumbers10Box.Text = "";
            primeNumbers2Box.Text = "";

            time.Start();
            var list = LargePrimeGenertor.Next(mbb,maxbb,rmnb);
            time.Stop();
            foreach (var item in list)
            {
                primeNumbers10Box.Text += item.ToString() + Environment.NewLine;
                primeNumbers2Box.Text += LargePrimeGenertor.GetBinary(item) + Environment.NewLine;
            }
            TimeSpan ts = time.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds,
            ts.Milliseconds );
            timeIterationNumsBox.Text = "Time " + elapsedTime + Environment.NewLine + "Iterations " + LargePrimeGenertor.countIteration;
        }

        private void generatePrimeRootsButton_Click(object sender, EventArgs e)
        {
            int cprb = 0;
            BigInteger pn10b = 0;
            Stopwatch time = new Stopwatch();
            if (!Int32.TryParse(countPrimitiveRootBox.Text, out cprb) || cprb < 1 || !BigInteger.TryParse(primeNumber10Box.Text, out pn10b) || pn10b < 1)
            {
                MessageBox.Show("Вы ввели некоректные данные, количество корней должно быть больше 0, а так же в поле слева введено корректное простое число");
                return;
            }
            primeRootsBox.Text = "";
            

            time.Start();
            var list = PrimitiveRoot.GetRoots(pn10b,cprb);
            time.Stop();
            foreach (var item in list)
            {
                
                primeRootsBox.Text += item.ToString() + Environment.NewLine;
            }
            TimeSpan ts = time.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}",
            ts.Minutes, ts.Seconds,
            ts.Milliseconds );

            timeRootsBox.Text = "Time " + elapsedTime + Environment.NewLine + "Количество возможных корней(fi(fi(n-1))) = " +PrimitiveRoot.EulerF(PrimitiveRoot.EulerF(pn10b-1));
        }

        private void diffieHellmanButton_Click(object sender, EventArgs e)
        {
            BigInteger Xa = 0;
            BigInteger Xb = 0;
            BigInteger N = 0;
            BigInteger G = 0;

            if (!BigInteger.TryParse(XaBox.Text, out Xa) || Xa < 2 ||
                !BigInteger.TryParse(XbBox.Text, out Xb) || Xb < 2||
                !BigInteger.TryParse(NBox.Text, out N) || N < 2||
                !BigInteger.TryParse(gBox.Text, out G) || G < 2)
            {
                MessageBox.Show("Вы ввели некоректные данные, N,Xa,Xb,G должны быть больше 2");
                return;
            }
            DiffieHellmanScheme dhs = new DiffieHellmanScheme(N, Xa, Xb,G);
            
            YaBox.Text = dhs.Ya.ToString();
            YbBox.Text = dhs.Yb.ToString();
            KaBox.Text = dhs.Ka.ToString();
            KbBox.Text = dhs.Kb.ToString();
            
            
        }

        private void diffieHellmanRandomButton_Click(object sender, EventArgs e)
        {
            int random = new Random().Next(10, 40);
            BigInteger Xa = LargePrimeGenertor.Next(random);
            BigInteger Xb = LargePrimeGenertor.Next(random);
            BigInteger N = LargePrimeGenertor.Next(random);
            DiffieHellmanScheme dhs = new DiffieHellmanScheme(N, Xa, Xb);
            NBox.Text = N.ToString();
            XaBox.Text = Xa.ToString();
            XbBox.Text = Xb.ToString();
            gBox.Text = dhs.G.ToString();
            YaBox.Text = dhs.Ya.ToString();
            YbBox.Text = dhs.Yb.ToString();
            KaBox.Text = dhs.Ka.ToString();
            KbBox.Text = dhs.Kb.ToString();
        }
    }
}