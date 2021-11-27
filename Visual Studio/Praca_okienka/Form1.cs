using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string Jedynka = "1";                       //definicja sygnałów wysyłanych do urządzenia
        string Dwojka = "2";
        Byte[] Odczyt = new Byte[32];               //tablica przechowujaca odczytany kod
        Stream Stream = null;                       //bufor połączenia tcp/ip
        private bool isStop = false;                //zmienna uruchamiająca wątek
        SqlConnection bazadanych;                   //obiekt połączenia z bazą danych
        string Nazwisko;                            //zmienne uzywane przy uzyskiwaniu/wpisywaniu danych do bazy
        string Imie;
        string Kod;
        string Kod2;        
        Mutex mutex = new Mutex();                  //definicja mutexu
        Stopwatch stoper = new Stopwatch();         //definicja stopera
        TimeSpan ts;                                //zmienna zapisująca okres czasu pomiędzy wyłączeniami stopera
        int czas;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            tabControl1.SelectedTab = tabPage2;     //ustawienie okienka ustawień jako domyślne podczas uruchomienia
        }

        private void timer1_Tick(object sender, EventArgs e)  //timer 
        {
            DateTime dataczas = DateTime.Now;                 //procedura uzyskujaca systemowa date oraz czas
            this.Dataczas.Text = dataczas.ToString();         //ktora wyswietla ja na interfejsie uzytkownika
        }
        void UpdateStatusLabel(string message)                //funkcja delegująca, zmieniajaca napis status
        {
            Action action = () => Status.Text = message;
            this.Invoke(action);                              //uruchomienie delegaty
        }
        void UpdateData1(DataTable table)                     //funkcja delegująca, wpisujaca dane do tablicy
        {
            Action action = () => dataGridView1.DataSource = table;
            this.Invoke(action);                              //uruchomienie delegaty
        }
        void ScrollDown()                                     //funkcja przesuwająca datagridview na dół
        {
            Action action = () => dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
            this.Invoke(action);                              //uruchomienie delegaty 
        }
        void Proces()                                         //funkcja ktora jest uruchamiana w watku 
        {
            while (isStop)//dziala w petli
            {
                try
                {
                    ASCIIEncoding asci = new ASCIIEncoding();                   //konwersja symbolu "1" na format bajtowy
                    byte[] bajt_jedynka = asci.GetBytes(Jedynka);
                    Stream.Write(bajt_jedynka, 0, bajt_jedynka.Length);         //wysłanie jedynki do urządzenia zdalnego
                    UpdateStatusLabel("Oczekiwanie");                           //zmiana statusu programu
                    int bytes = Stream.Read(Odczyt, 0, Odczyt.Length);          //oczekiwanie na dane od urządzenia zdalnego
                    if (isStop == true)                                         //sprawdzenie czy watek jest nadal uruchomiony
                    {
                        if (bytes >= 4)                                         //sprawdzenie czy została odczytana jakaś liczba
                        {
                            if (stoper.IsRunning == true)                       //zatrzymanie stopera jeżeli działa oraz pobranie 
                            {                                                   //ilości sekund, które upłynęły od czasu ostatniego 
                                stoper.Stop();                                  //logowania pracownika
                                ts = stoper.Elapsed;
                                stoper.Reset();
                            }
                             try
                            {
                                Kod = Encoding.ASCII.GetString(Odczyt);         //konwersja odczytanych bajtow na znaki ASCII
                                Kod = Kod.Substring(0, 12);                     //skracanie otrzymanego ciagu znakow do samego kodu                                                                                //przepisanie kodu do innej zmiennej
                                czas = Convert.ToInt32(stoperBox.Text);         //sprawdzenie wartości textboxa
                                if (Kod == Kod2 && ts.Seconds <= czas)          //jeżeli zostanie odczytany ten sam kod 
                                {                                               //poniżej wymaganego czasu to program nie zapisuje danych do bazy
                                    UpdateStatusLabel("Logowanie zdublowane!"); //zmiana statusu programu
                                    Thread.Sleep(1000);
                                    stoper.Start();
                                }
                                else                                            //jezeli wpis jest mozliwy, program wykonuje wpis do bazy danych
                                {
                                    UpdateStatusLabel("Wpis do bazy danych");   //zmiana statusu programu
                                    Kod2 = Kod;                                 //przepisanie kodu do drugiej zmiennej
                                    SqlDataReader czytnik;                          //definiowanie czytnika danych sql
                                    string zapytanie = ("SELECT Nazwisko,Imie FROM BazaPracownikow Where KOD ='" + Kod + "';");
                                    SqlCommand komzapytanie = new SqlCommand(zapytanie, bazadanych);
                                    mutex.WaitOne();                                //uruchomienie mutexu
                                    bazadanych.Open();                              //otwarcie polaczenia z baza danych
                                    czytnik = komzapytanie.ExecuteReader();         //odpytanie bazy danych od nazwisko i imie
                                    if (czytnik.HasRows == true)                    //jeżeli czytnik otrzymał dane, zaczyna się odczyt
                                    {
                                        while (czytnik.Read())                          //odczyt danych
                                        {                                               //następuje odczyt nazwiska i imienia z bazy danych
                                            Nazwisko = czytnik["Nazwisko"].ToString();
                                            Imie = czytnik["Imie"].ToString();
                                        }
                                        czytnik.Close();                            //zamknięcie czytnika danych
                                        ASCIIEncoding asci2 = new ASCIIEncoding();                   //konwersja symbolu "2" na format bajtowy
                                        byte[] bajt_dwojka = asci.GetBytes(Dwojka);
                                        Stream.Write(bajt_dwojka, 0, bajt_dwojka.Length);         //wysłanie dwojki do urządzenia zdalnego zeby uruchomic przekaznik
                                        stoper.Start();
                                        zapytanie = "insert into Obecnosc(Data,Nazwisko,Imie,Kod) values(" + "'" + DateTime.Now.ToString() +
                                        "','" + Nazwisko + "','" + Imie + "','" + Kod + "'" + ");";
                                        komzapytanie = new SqlCommand(zapytanie, bazadanych);
                                        komzapytanie.ExecuteNonQuery();             //wpisanie logowania danego użytkownika do bazy obecności
                                        zapytanie = ("SELECT * FROM Obecnosc WHERE Data BETWEEN '" + DateTime.Today.ToString() +
                                            "'AND'" + DateTime.Now.ToString() + "';");
                                        komzapytanie = new SqlCommand(zapytanie, bazadanych);
                                        komzapytanie.ExecuteNonQuery();             //pobranie odświeżonej tabeli logowań
                                        SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych); //adapter danych, potrzebny do zapisu logowań do tablicy
                                        DataTable tablica = new DataTable();        //nowa tabela danych
                                        adapter.Fill(tablica);                      //uzupełnienie zaktualizowanej tablicy
                                        UpdateData1(tablica);                       //delegata, wpisująca dane do dataGridView1
                                        ScrollDown();                               //przesunięcie tablicy na dół
                                        Stream.Flush();                             //czyszczenie bufora odczytu
                                        bazadanych.Close();                         //zamknięciee połaczenia z bazą danych
                                        mutex.ReleaseMutex();                       //wyłączenie mutexu
                                    }
                                    else                                            //gdy baza nie zawiera pracownika w bazie
                                    {
                                        czytnik.Close();                                //zamkniecie czytnika danych
                                        bazadanych.Close();                             //zamknięcie połączenia z bazą danych
                                        mutex.ReleaseMutex();                           //wyłączenie mutexu
                                        MessageBox.Show("Nie ma takiego pracownika!", "UWAGA");//wyświetlenie komunikatu o braku takiego pracownika
                                    }

                                }
                                Thread.Sleep(1000);
                            }
                            catch                                               //obsługa błędu podczas działania programu
                            {
                                MessageBox.Show("Błąd podczas wpisu do bazy danych, bądź uszkodzone dane");
                            }
                        }
                    }
                    else                                                        //w przypadku gdy zostanie przerwane działanie wątku  
                    {                                                           //program czyści bufor odczytu i kończy pracę 
                        Stream.Flush();
                        return;
                    }

                }
                catch (Exception ex)                                            //obsługa błędu podczas uruchamiania wątku
                {
                    MessageBox.Show("Błąd podczas uruchamiania wątku:" + ex.ToString());
                }
            }
        }

        private void Polacz_Click(object sender, EventArgs e) //funkcja uruchamiająca się po naciśnięciu przycisku Połącz
        {
            try
            {
                TcpClient Client = new TcpClient();         //definiowanie klienta TCP/IP
                int port = Convert.ToInt32(port_Text.Text); //konwersja numeru portu do int
                Client.Connect(adres_IP.Text, port);        //laczenie sie z urzadzeniem podanym pod danym IP i portem
                Stream = Client.GetStream();                //pobranie bufora we/wy
                string baza = "Data Source=" + SerwerbazyBox.Text + ";Initial Catalog=" + NazwabazyBox.Text + ";Integrated Security=True";
                bazadanych = new SqlConnection(baza);       //utworzenie obiektu bazy danych z ustawieniami pobranymi z texboxów
                Polacz.Text = "Połączono";                  //zmiana napisu na przycisku Połącz
                string zapytanie = ("SELECT * FROM Obecnosc WHERE Data BETWEEN '" + DateTime.Today.ToString() +
                                "'AND'" + DateTime.Now.ToString() + "';");
                bazadanych.Open();                          //otwarcie połączenia z bazą danych
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych); //definicja adaptera danych SQL
                DataTable tablica = new DataTable();        //definiowanie tabeli danych
                adapter.Fill(tablica);                      //wypełnienie tabeli danych z wynikami z dnia dzisiejszego
                dataGridView1.DataSource = tablica;         //wpis danych do elementu dataGridView
                bazadanych.Close();                         //zamknięcie połączenia z bazą danych
                Polacz.Enabled = false;                     //dezaktywacja przycisku połączenia
                adres_IP.Enabled = false;                   //dezaktywacja textboxu odpowiedzialnego za wprowadzanie adresu IP
                port_Text.Enabled = false;                  //dezaktywacja textboxu odpowiedzialnego za wprowadzenie portu
                NazwabazyBox.Enabled = false;               //dezaktywacja textboxu z nazwą bazy danych
                SerwerbazyBox.Enabled = false;              //dezaktywacja textboxu z nazwą serwera bazy danych
                tabControl1.SelectedTab = tabPage1;         //przełączenie się na pierwszą zakładkę
                Status.Text = "Program gotowy";             //zmiana statusu programu

            }
            catch (SocketException ex)                      //w przypadku bledu, wyswietlony zostanie komunikat    
            {
                MessageBox.Show("Błąd podczas połączenia: " + ex.Message);
                Status.Text = "Rozłączono";
                Polacz.Text = "Połącz";
            }
        }

        private void Uruchom_Click(object sender, EventArgs e)//obsługa przycisku uruchamiającego wątek główny programu
        {
            if (Polacz.Text == "Połącz")                      //sprawdzenie czy program jest polaczony z urzadzeniem
            {
                MessageBox.Show("Najpierw połącz się z urządzeniem!", "Błąd", MessageBoxButtons.OK);
            }
            else if (isStop == false)                         //gdy wątek nie jest uruchomiony
            {
                isStop = true;                                //ustawienie zmiennej podtrzymującej wątek
                Thread Watek = new Thread(Proces);            //definiowanie wątku
                Watek.Start();                                //uruchomienie wątku
                Uruchom.Text = "Zatrzymaj";                   //zmiana opisu przycisku
            }
            else                                              //gdy wątek jest już uruchomiony
            {

                isStop = false;                               //ustawienie zmiennej podrzymującej wątek
                Uruchom.Text = "Uruchom";                     //zmiana opisu przycisku i statusu
                Status.Text = "Połączono";
            }
        }

        private void Zamknij_Click(object sender, EventArgs e)//obsługa przycisku zamykającego program
        {
            if (Stream != null) Stream.Close();               //zamykanie bufora
            this.Close();                                     //zamykanie programu
        }

        private void button2_Click(object sender, EventArgs e)//przycisk OK w zakładce Ustawienia
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//obsługa checkboxów w zakładce filtrowania bazy danych
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                dataOdBox.Enabled = false;
                dataDoBox.Enabled = false;
                KodKartyBox.Enabled = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                dataOdBox.Enabled = true;
                dataDoBox.Enabled = true;
                KodKartyBox.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)// --||--
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                NazwiskoBox.Enabled = false;
                KodKartyBox.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                NazwiskoBox.Enabled = true;
                KodKartyBox.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)// --||--
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                NazwiskoBox.Enabled = false;
                dataOdBox.Enabled = false;
                dataDoBox.Enabled = false;
            }
            else
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                NazwiskoBox.Enabled = true;
                dataOdBox.Enabled = true;
                dataDoBox.Enabled = true;
            }
        }

        private void przyciskFiltruj_Click(object sender, EventArgs e)//obsługa filtrowania nazwisk
        {
            if (checkBox1.Checked == true)
            {
                string zapytanie = ("SELECT * FROM Obecnosc Where Nazwisko LIKE '%" + NazwiskoBox.Text + "%';");
                bazadanych.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
                DataTable tablica = new DataTable();
                adapter.Fill(tablica);
                dataGridView2.DataSource = tablica;
                bazadanych.Close();
            }
            else if (checkBox2.Checked == true)              //filtrowanie po dacie
            {
                string zapytanie = ("SELECT * FROM Obecnosc WHERE Data BETWEEN '" + dataOdBox.Text +
                                "'AND'" + dataDoBox.Text + "';");
                bazadanych.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
                DataTable tablica = new DataTable();
                adapter.Fill(tablica);
                dataGridView2.DataSource = tablica;
                bazadanych.Close();

            }
            else if (checkBox3.Checked == true)             //filtrowanie po kodzie karty
            {
                string zapytanie = ("SELECT * FROM Obecnosc Where Kod = '" + KodKartyBox.Text + "';");
                bazadanych.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
                DataTable tablica = new DataTable();
                adapter.Fill(tablica);
                dataGridView2.DataSource = tablica;
                bazadanych.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//przycisk odświeżający tabelę danych
        {
            string zapytanie = ("SELECT * FROM BazaPracownikow;");
            bazadanych.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
            DataTable tablica = new DataTable();
            adapter.Fill(tablica);
            dataGridView3.DataSource = tablica;
            bazadanych.Close();
        }

        private void przyciskDodajPracownika_Click(object sender, EventArgs e)//wpisywanie nowego pracownika
        {
            if (textBox1.Text == "")                          //obsługa błędów(brak wpisania danych przez użytkownika)
            {
                MessageBox.Show("Wprowadź nazwisko pracownika!", "Błąd", MessageBoxButtons.OK);
                return;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Wprowadź imię pracownika!", "Błąd", MessageBoxButtons.OK);
                return;
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Wprowadź kod karty pracownika!", "Błąd", MessageBoxButtons.OK);
                return;
            }
            string zapytanie = "insert into BazaPracownikow(Nazwisko,Imie,Kod) values (" + "'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'" + " );";
            SqlCommand komenda = new SqlCommand(zapytanie, bazadanych);//obiekt command
            DialogResult decyzja = MessageBox.Show("Czy chcesz wprowadzic do bazy nastepujacego pracownika?" + ":" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text, "Ostrzezenie", MessageBoxButtons.YesNo);
            if (decyzja == DialogResult.Yes)//akceptacja wpisu do bazy danych
            {
                bazadanych.Open(); //otwarcie polaczenia do bazy danych
                komenda.ExecuteNonQuery(); //uruchomienie polecenia
                bazadanych.Close();//zamykanie połączeń
            }
            else if (decyzja == DialogResult.No)//anulowanie wpisu do bazy danych
            {
                return;
            }
        }

        private void przyciskOdswiez_Click(object sender, EventArgs e)//przycisk aktualizujący tablicę z bazą pracowników
        {
            string zapytanie = ("SELECT * FROM BazaPracownikow;");
            bazadanych.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
            DataTable tablica = new DataTable();
            adapter.Fill(tablica);
            dataGridView4.DataSource = tablica;
            bazadanych.Close();
        }

        private void przyciskUsun_Click(object sender, EventArgs e) //przycisk usuwający pracownika z bazy
        {
            if (nazwiskoUsunBox.Text == ""|| nazwiskoUsunBox.Text.Length <= 11) //obsługa błędu(brak wprowadzonych danych lub kod za krótki)
            {
                MessageBox.Show("Brak kodu, lub kod za krótki!", "Błąd", MessageBoxButtons.OK);
                return;
            }
            string zapytanie = "delete from BazaPracownikow where Kod = (" + "'" + nazwiskoUsunBox.Text + "' );";
            SqlCommand komenda = new SqlCommand(zapytanie, bazadanych);//obiekt command
            DialogResult decyzja = MessageBox.Show("Czy chcesz usunac z bazy nastepujacego pracownika?" + ": " + nazwiskoUsunBox.Text, "Ostrzezenie", MessageBoxButtons.YesNo);
            if (decyzja == DialogResult.Yes)//akceptacja usunięcia pracownika z bazy danych
            {
                bazadanych.Open(); //otwarcie polaczenia do bazy danych
                komenda.ExecuteNonQuery(); //uruchomienie polecenia
                bazadanych.Close();//zamykanie polaczen
            }
            else if (decyzja == DialogResult.No)//anulowanie usuwania pracownika z bazy danych
            {
                return;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)//funkcja odświeżająca tablice danych w zależności od uruchomionej zakładki
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])//tabelka z okna Podgląd
            {
                string zapytanie = ("SELECT * FROM Obecnosc WHERE Data BETWEEN '" + DateTime.Today.ToString() +
                       "'AND'" + DateTime.Now.ToString() + "';");
                bazadanych.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
                DataTable tablica = new DataTable();
                adapter.Fill(tablica);
                dataGridView1.DataSource = tablica;
                bazadanych.Close();
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])//tabelka z okna przeglądania logowań
            {
                string zapytanie = ("SELECT * FROM Obecnosc;");
                bazadanych.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
                DataTable tablica = new DataTable();
                adapter.Fill(tablica);
                dataGridView2.DataSource = tablica;
                bazadanych.Close();
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])//tabelka z okna dodawania pracowników
            {
                string zapytanie = ("SELECT * FROM BazaPracownikow;");
                bazadanych.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
                DataTable tablica = new DataTable();
                adapter.Fill(tablica);
                dataGridView3.DataSource = tablica;
                bazadanych.Close();
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage5"])//tabelka z okna usuwania pracowników
            {
                string zapytanie = ("SELECT * FROM BazaPracownikow;");
                bazadanych.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(zapytanie, bazadanych);
                DataTable tablica = new DataTable();
                adapter.Fill(tablica);
                dataGridView4.DataSource = tablica;
                bazadanych.Close();
            }

        }

        private void przyciskSprawdzKarte_Click(object sender, EventArgs e)//przycisk służący sprawdzeniu kodu karty
        {
            if (Polacz.Text == "Połącz")
            {
                MessageBox.Show("Najpierw połącz się z urządzeniem!", "Błąd", MessageBoxButtons.OK);
            }

            else if (Uruchom.Text == "Zatrzymaj")
            {
                MessageBox.Show("Pamietaj, aby zatrzymac dzialanie programu przed sprawdzeniem kodu karty!", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                ASCIIEncoding asci = new ASCIIEncoding();
                byte[] bajt_jedynka = asci.GetBytes(Jedynka);
                Stream.Write(bajt_jedynka, 0, bajt_jedynka.Length);
                int bytes = Stream.Read(Odczyt, 0, Odczyt.Length);
                string sprawdz_kod = Encoding.ASCII.GetString(Odczyt);
                sprawdz_kod = sprawdz_kod.Substring(0, 12);
                kodKarty.Text = sprawdz_kod;
            }

        }
    }
}

