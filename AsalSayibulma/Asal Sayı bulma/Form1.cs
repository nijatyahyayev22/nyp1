namespace Asal_Sayı_bulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            double sayac = 0;
            listBox1.Items.Clear();
            double x = Convert.ToDouble(textBox1.Text);
            if (x < 2)
            {
                MessageBox.Show("Asal Sayı Bulunamadı.");
            }
            else
            {
                for (double i = 2; i <= x; i++)
                {
                    double kontrol = 0;
                    for (double j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            kontrol++;
                            break;
                        }
                    }
                    if (kontrol == 0)
                    {
                        listBox1.Items.Add(i);
                        sayac++;
                    }
                }
            }

            label2.Text = "1-" + x + " arası " + sayac + " adet Asal Sayı Bulundu.";

        }


    }


}


