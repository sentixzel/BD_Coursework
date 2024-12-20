using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;
using System.Globalization;
using System.Threading;

namespace BD_Coursework
{
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();
        public Form1()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US"); // English - US
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");// English - US
            InitializeComponent();
            toolTip1.SetToolTip(textBox_TipDvigatelya, "1 - приводные электродвигатели постоянного тока, переменного тока однофазные, переменного тока асинхронные с короткозамкнутым ротором.\n2 - приводные электродвигатели постоянного тока, переменного тока синхронные, асинхронные с контактными кольцами");
            toolTip2.SetToolTip(textBox_SposobNatyazheniya, "1 - неавтоматическое натяжение\n2 - автоматическое натяжение");
            toolTip3.SetToolTip(textBox_Nagruzka, "Спокойная нагрузка. Пусковая нагрузка до 120% номинальной.\n" +
                                                  "Умеренные колебания нагрузки. Пусковая нагрузка до 150% номинальной.\n" +
                                                  "Значительные колебания нагрузки. Пусковая нагрузка до 200% номинальной.\n" +
                                                  "Весьма неравномерная и ударная нагрузка. Пусковая нагрузка до 300% номинальной.");
            toolTip4.SetToolTip(textBox_ProfilRemnya, "Допускаемые обозначения профилей ремней: О, А, Б, В");
        }

        private void textBox_Nagruzka_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBox_Moschnost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBox_TipDvigatelya_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBox_NachNaprezhenie_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != ',')
                e.Handled = true;
        }

        private void textBox_MinDiamShkiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBox_UgolObhvata_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBox_SposobNatyazheniya_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void textBox_Skorost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox_Nagruzka.Text.Length == 0 ||
                textBox_Moschnost.Text.Length == 0 ||
                textBox_TipDvigatelya.Text.Length == 0 ||
                textBox_NachNaprezhenie.Text.Length == 0 ||
                textBox_MinDiamShkiv.Text.Length == 0 ||
                textBox_UgolObhvata.Text.Length == 0 ||
                textBox_SposobNatyazheniya.Text.Length == 0 ||
                textBox_Skorost.Text.Length == 0 ||
                textBox_ProfilRemnya.Text.Length == 0 )
            {
                MessageBox.Show(
                    "Введите в поля данные.",
                    "Неполный набор данных",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
                return;
            }

            int SposobNat = Convert.ToInt32(textBox_SposobNatyazheniya.Text);
            if (!SposobNat.Equals(1) && !SposobNat.Equals(2))
            {
                MessageBox.Show(
                    "Введите правильное обозначение способа натяжения.",
                    "Неправильный ввод",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
                textBox_SposobNatyazheniya.Focus();
                return;
            }

            var Profil = textBox_ProfilRemnya.Text;
            if (!Profil.Equals("О") && !Profil.Equals("А") && !Profil.Equals("Б") && !Profil.Equals("В"))
            {
                MessageBox.Show(
                    "Введите правильное обозначение профиля ремня.",
                    "Неправильный ввод",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
                textBox_ProfilRemnya.Focus();
                return;
            }

            int HarNagruzki = Convert.ToInt32(textBox_Nagruzka.Text);
            double Moshnost = Convert.ToDouble(textBox_Moschnost.Text);
            int TipDvig = Convert.ToInt32(textBox_TipDvigatelya.Text);
            double NachNapr = Convert.ToDouble(textBox_NachNaprezhenie.Text);

            double MinDShkiv = Convert.ToDouble(textBox_MinDiamShkiv.Text);
            double Ugol = Convert.ToDouble(textBox_UgolObhvata.Text);

            double Skorost = Convert.ToDouble(textBox_Skorost.Text);

            double C3 = 0;
            double F;



            //calc

            F = Math.Pow(10, 3) * Moshnost * Skorost;

            double S1;
            double dF0;
            if (Profil.Equals("О"))
            {
                S1 = 47;

                if (MinDShkiv >= 90)
                {
                    if (NachNapr >= 1.6) dF0 = 2.0;
                    else if (NachNapr >= 1.4) dF0 = 1.89;
                    else dF0 = 1.69;
                }
                else if (MinDShkiv >= 80)
                {
                    if (NachNapr >= 1.6) dF0 = 1.90;
                    else if (NachNapr >= 1.4) dF0 = 1.78;
                    else dF0 = 1.60;
                }
                else if (MinDShkiv >= 71)
                {
                    if (NachNapr >= 1.6) dF0 = 1.80;
                    else if (NachNapr >= 1.4) dF0 = 1.67;
                    else dF0 = 1.51;
                }
                else
                {
                    if (NachNapr >= 1.6) dF0 = 1.67;
                    else if (NachNapr >= 1.4) dF0 = 1.5;
                    else dF0 = 1.35;
                }
            }
            else if (Profil.Equals("А"))
            {
                S1 = 81;

                if (MinDShkiv >= 125)
                {
                    if (NachNapr >= 1.6) dF0 = 2.13;
                    else if (NachNapr >= 1.4) dF0 = 1.96;
                    else dF0 = 1.78;
                }
                else if (MinDShkiv >= 112)
                {
                    if (NachNapr >= 1.6) dF0 = 1.90;
                    else if (NachNapr >= 1.4) dF0 = 1.78;
                    else dF0 = 1.60;
                }
                else if (MinDShkiv >= 100)
                {
                    if (NachNapr >= 1.6) dF0 = 1.80;
                    else if (NachNapr >= 1.4) dF0 = 1.67;
                    else dF0 = 1.51;
                }
                else
                {
                    if (NachNapr >= 1.6) dF0 = 1.67;
                    else if (NachNapr >= 1.4) dF0 = 1.5;
                    else dF0 = 1.35;
                }
            }
            else if (Profil.Equals("Б"))
            {
                S1 = 138;

                if (MinDShkiv >= 180)
                {
                    if (NachNapr >= 1.6) dF0 = 2.24;
                    else if (NachNapr >= 1.4) dF0 = 2.04;
                    else dF0 = 1.82;
                }
                else if (MinDShkiv >= 160)
                {
                    if (NachNapr >= 1.6) dF0 = 2.0;
                    else if (NachNapr >= 1.4) dF0 = 1.89;
                    else dF0 = 1.69;
                }
                else if (MinDShkiv >= 140)
                {
                    if (NachNapr >= 1.6) dF0 = 1.80;
                    else if (NachNapr >= 1.4) dF0 = 1.67;
                    else dF0 = 1.51;
                }
                else
                {
                    if (NachNapr >= 1.6) dF0 = 1.67;
                    else if (NachNapr >= 1.4) dF0 = 1.5;
                    else dF0 = 1.35;
                }
            }
            else
            {
                S1 = 230;

                if (MinDShkiv <= 200)
                {
                    if (NachNapr >= 1.6) dF0 = 1.80;
                    else if (NachNapr >= 1.4) dF0 = 1.67;
                    else dF0 = 1.51;
                }
                else if (MinDShkiv <= 224)
                {
                    if (NachNapr >= 1.6) dF0 = 2.0;
                    else if (NachNapr >= 1.4) dF0 = 1.89;
                    else dF0 = 1.69;
                }
                else if (MinDShkiv <= 250)
                {
                    if (NachNapr >= 1.6) dF0 = 2.24;
                    else if (NachNapr >= 1.4) dF0 = 2.04;
                    else dF0 = 1.82;
                }
                else
                {
                    if (NachNapr >= 1.6) dF0 = 2.35;
                    else if (NachNapr >= 1.4) dF0 = 2.20;
                    else dF0 = 1.92;
                }
            }

            dF0 *= Math.Pow(10, 6);

            double C1;
            if (Ugol <= 70) C1 = 0.56;
            else if (Ugol <= 80) C1 = 0.62;
            else if (Ugol <= 90) C1 = 0.68;
            else if (Ugol <= 100) C1 = 0.74;
            else if (Ugol <= 110) C1 = 0.79;
            else if (Ugol <= 120) C1 = 0.83;
            else if (Ugol <= 130) C1 = 0.87;
            else if (Ugol <= 140) C1 = 0.9;
            else if (Ugol <= 150) C1 = 0.93;
            else if (Ugol <= 160) C1 = 0.96;
            else if (Ugol <= 170) C1 = 0.98;
            else C1 = 1.0;


            double C2 = 0;
            if (Skorost <= 5) C2 = 1.04;
            else if (Skorost <= 10) C2 = 1.0;
            else if (Skorost <= 15) C2 = 0.94;
            else if (Skorost <= 20) C2 = 0.85;
            else if (Skorost <= 25) C2 = 0.74;
            else if (Skorost <= 30) C2 = 0.6;


            if (HarNagruzki <= 120)
                C3 = 1;
            else if (HarNagruzki <= 150)
                C3 = 0.9;
            else if (HarNagruzki <= 200)
                C3 = 0.8;
            else if (HarNagruzki <= 300)
                C3 = 0.7;

            if (C3 == 0)
            {
                MessageBox.Show(
                    "Введите правильное значение пусковой нагрузки.",
                    "Неправильный ввод",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly
                );
                textBox_ProfilRemnya.Focus();
                return;
            }

            if (TipDvig == 2)
                C3 -= 0.1;

            double dF = 0;
            dF = dF0 * C1 * C2 * C3;

            double tempZ = 0;

            tempZ = F / (S1 * dF);

            int Z = Convert.ToInt32(Math.Ceiling(tempZ));

            label10.Text = "Количество ремней для текущей передачи равно:" + Z;



            //working with BD

            database.OpenConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring1 = $"insert into Dvigateli (NaimUzel, HarNagruzki, TipDvig) values ('Двигатель', '{HarNagruzki}', '{TipDvig}');";
            SqlCommand sqlCommand = new SqlCommand(querystring1, database.GetConnection());

            sqlCommand.ExecuteNonQuery();

            querystring1 = "select * from Dvigateli order by id desc;"; 
            sqlCommand = new SqlCommand(querystring1, database.GetConnection());
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            object idx = reader.GetValue(0);
            int id = Convert.ToInt32(idx);
            reader.Close();
            database.CloseConnection();

            database.OpenConnection();
            string querystring2 = $"insert into Peredachy (id_dvigatel, NSE, C3, TSE, VSE, SposNat, Z, NumSe, C1, C2, F, dF0, d0, dF, N) values ('{id}', 'Перед', '{C3}', 'Ремен', 'Клин', '{SposobNat}', '{Z}', '{id}', '{C1}', '{C2}', '{F}', '{dF0}', '{NachNapr}', '{dF}', '{Moshnost}');";
            SqlCommand sqlCommand2 = new SqlCommand(querystring2, database.GetConnection());
            sqlCommand2.ExecuteNonQuery();


            querystring1 = "select * from Peredachy order by id desc;";
            sqlCommand = new SqlCommand(querystring1, database.GetConnection());
            reader = sqlCommand.ExecuteReader();
            reader.Read();
            idx = reader.GetValue(0);
            id = Convert.ToInt32(idx);
            reader.Close();
            database.CloseConnection();

            database.OpenConnection();
            querystring2 = $"insert into Remni (id_peredacha, ND, ProfRemnya, VD, TD, a1, S1, v) values ('{id}', 'Ремень', '{Profil}', 'Нормальный', 'Клиновый', '{Ugol}', '{S1}', '{Skorost}');";
            sqlCommand2 = new SqlCommand(querystring2, database.GetConnection());
            sqlCommand2.ExecuteNonQuery();
            database.CloseConnection();

            database.OpenConnection();
            querystring2 = $"insert into Shkiv (id_peredacha, razmer) values ('{id}', '{MinDShkiv}');";
            sqlCommand = new SqlCommand(querystring2, database.GetConnection());
            sqlCommand.ExecuteNonQuery();

            database.CloseConnection();
        }
    }
}
