/*
 * PC to Arduino
 * PC -> USB to RS485 -> MAX485 Module -> Arduino Nano (1)
 *                    -> MAX485 Module -> Arduino Nano (2)
 * Created by Muchammad Sobrun Ibnu Atfal
 * Kesambi - Indonesia.
 * atfalsobrun@gmail.com
 * 
 * In this experiment send character by User Interface '1,2,3,4'
 * 1 = NANO 1 LED ON
 * 2 = NANO 1 LED OFF
 * 3 = NANO 2 LED ON
 * 4 = NANO 2 LED OFF
 * 
 * https://github.com/MuchammadSobrun/PC-to-Arduino-by-MAX485-Module
 */

#include <SoftwareSerial.h>   // Using software serial library

#define SSerialRX        10   // Serial Receive pin  (RO)
#define SSerialTX        11   // Serial Transmit pin (DI)

#define SSerialTxControl 3    // RS485 Direction control
                              //(DE & RE) pin to digital pin 3

#define RS485Transmit    HIGH // to open direction of MAX485 module
#define RS485Receive     LOW  // to close direction of MAX485 module

#define Pin13LED         13   // Built in LED to indicate command has recieved

SoftwareSerial RS485Serial(SSerialRX, SSerialTX); // initialize RX and TX

char x;                         // Containing data recieved

void setup() {
  pinMode(Pin13LED, OUTPUT);                    // Pin13LED as OUTPUT
  pinMode(SSerialTxControl, OUTPUT);            // SSerialTxControl as OUTPUT
  digitalWrite(SSerialTxControl, RS485Receive); // initial set SSerialTxControl are closed
  RS485Serial.begin(9600);                      // RS485Serial baudrate 9600
}

void loop() {
  
if (RS485Serial.available())        // Checking Serial available 
  {
    x = RS485Serial.read();         // Serial read by saving in x variable
    
    if (x=='1'){//'3'){             // Checking condition, if 1 and 2 for NANO 1, 3 and 4 for NANO 2
       digitalWrite(Pin13LED,HIGH);
    }
    else if (x=='2'){//'4'){
       digitalWrite(Pin13LED,LOW);
    }
  }
}

// End of program
// Thank you
