namespace Sortowanie
{
    public partial class Form1 : Form
    {

        int[] tabS1 = new int[10];
        int[] tabS2 = new int[10];
        int[] tabS3 = new int[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Generuj()
        {
            Random rnd = new Random();
            for (int i = 0; i < tabS1.Length; i++)
            {
                tabS1[i] = rnd.Next(1, 250);
                tabS2[i] = rnd.Next(1, 250);
                tabS3[i] = rnd.Next(1, 250);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Generuj();



            String tabS1String = "";
            String tabS2String = "";
            String tabS3String = "";

            for (int i = 0; i < tabS1.Length; i++)
            {
                tabS1String += tabS1[i].ToString();
                tabS1String += " ";
                tabS2String += tabS2[i].ToString();
                tabS2String += " ";
                tabS3String += tabS3[i].ToString();
                tabS3String += " ";
            }

            label1.Text = tabS1String;
            label2.Text = tabS2String;
            label3.Text = tabS3String;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertionSort a = new InsertionSort();

            a.Sort(tabS1);
            String tabS1String = "";
            String tabS2String = "";

            for (int i = 0; i < tabS1.Length; i++)
            {
                tabS1String += tabS1[i].ToString();
                tabS1String += " ";
                tabS2String += tabS2[i].ToString();
                tabS2String += " ";
            }

            label1.Text = tabS1String;
            label2.Text = tabS2String;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void s2_Click(object sender, EventArgs e)
        {
            SelectionSort s = new SelectionSort();

            s.Sort(tabS2);

            String tabS1String = "";
            String tabS2String = "";

            for (int i = 0; i < tabS1.Length; i++)
            {
                tabS1String += tabS1[i].ToString();
                tabS1String += " ";
                tabS2String += tabS2[i].ToString();
                tabS2String += " ";
            }

            label1.Text = tabS1String;
            label2.Text = tabS2String;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            QuickSort q = new QuickSort();

            q.Sort(tabS3, 0, tabS3.Length - 1);

            String tabS1String = "";
            String tabS2String = "";
            String tabS3String = "";


            for (int i = 0; i < tabS1.Length; i++)
            {
                tabS1String += tabS1[i].ToString();
                tabS1String += " ";
                tabS2String += tabS2[i].ToString();
                tabS2String += " ";
                tabS3String += tabS3[i].ToString();
                tabS3String += " ";

            }

            label1.Text = tabS1String;
            label2.Text = tabS2String;
            label3.Text = tabS3String;


        }
    }
}
