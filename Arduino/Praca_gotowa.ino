s#include <SPI.h>
#include <WiFi.h>
#include <SoftwareSerial.h>

char ssid[] = "Pjotreknet"; //  SSID sieci z ktora laczy sie arduino
char pass[] = "bardzotrudnehaslo";    // haslo sieci
int status = WL_IDLE_STATUS;
WiFiServer server(23);//numer portu na ktorym zostanie postawiony server
boolean alreadyConnected = false; // zmienna bool ktora sprawdza, czy klient jest juz polaczony
SoftwareSerial RFID = SoftwareSerial(2,3); //uruchamia serial port odbioru na pinie 2 i zapisu na 3 dla czytnika RFID

void setup() {
  //uruchomienie serial portow
  Serial.begin(9600);
  RFID.begin(9600);
  Serial.println("Seriale gotowe");
  //ustawianie pinow mikrokontrolera
  pinMode(6,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(8,OUTPUT);
  digitalWrite(8,HIGH);
  Serial.println("Ustalono piny wyjsciowe");
  // proba polaczenia sie z siecia:
  while ( status != WL_CONNECTED) {
    Serial.print("Laczenie z siecia: ");
    Serial.println(ssid);
    // Laczenie sie z siecia o podanych parametrach:
    status = WiFi.begin(ssid, pass);
    // oczekiwanie 10 sekund na polaczenie
    delay(10000);
  }
  // uruchomienie serwera w przypadku polaczenia:
  server.begin();
  // Wyswietlenie statusu:
  printWifiStatus();
  Serial.println("Serwer gotowy do dzialania, oczekiwanie na klienta");
}
//definiowanie zmiennych uzywanych w programie:
char c;      //zmienna przechowujaca symbol odczytany z czytnika
String msg;  //zmienna w ktorej zapisany jest kompletny kod z czytnika
int a;       //zmienna liczbowa przechowujaca odczytany kod z komputera
char odbior; //zmienna przechowujaca odczytany kod z komputera(przed konwersja) 
void loop() {
  //uruchomienie serwera, oczekiwanie na klienta
  WiFiClient client = server.available();
  digitalWrite(6,LOW);
  if (client) {
    if (!alreadyConnected) {  
      // polaczenie z klientem:czyszczenie bufora, wyswietlenie komunikatu oraz zapalenie zielonej diody
      client.flush();
      Serial.println("Nowe polaczenie");
      tone(5,196,100);
      tone(5,296,100);
      alreadyConnected = true;
    }
    digitalWrite(6,HIGH);
    odbior = client.read();  //odczytanie kodu wyslanego przez komputer
    a=odbior-'0';            //konwersja odebranych danych na inta
    if(a == 1)               //sprawdzenie czy klient wyslal jedynke
    {                        //jezeli tak to kod zostanie skrocony i wyslany do komputera
      if(msg.length() > 13){
        msg = msg.substring(1,13);
        client.println(msg);
        Serial.println("Wyslano kod:");
        Serial.println(msg);
        tone(5,196,250);
        delay(1000);
        msg = "";
      }
      else{
        client.println("0");
      }
    }
    else if(a == 2)//uruchomienie przekaznika na 2 sekundy
    {
      digitalWrite(8,LOW);
      delay(2000);
      digitalWrite(8,HIGH);
    }
    else{        //odczyt danych z czytnika RFID
     while(RFID.available()>0){
        c=RFID.read(); 
        msg += c;
      }
    }
  }
  else{
    alreadyConnected = false;
  }

}
//Funkcja wyswietlajaca status serwera wifi

void printWifiStatus() {
  // Wyswietlenie identyfikatora sieci:
  Serial.print("SSID: ");
  Serial.println(WiFi.SSID());

  // Wyswietlenie IP:
  IPAddress ip = WiFi.localIP();
  Serial.print("IP Address: ");
  Serial.println(ip);

  // Wyswietlenie sily sygnalu:
  long rssi = WiFi.RSSI();
  Serial.print("signal strength (RSSI):");
  Serial.print(rssi);
  Serial.println(" dBm");
}










