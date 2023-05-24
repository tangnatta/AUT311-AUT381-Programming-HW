// https://www.tinkercad.com/things/iE9qq5I7oOF-exquisite-fyyran/editel
// Slave 0x98 | LED dim

#include <Arduino.h>
#include <Wire.h>

#define LED 9

void setup()
{
  Wire.begin(0x98);
  Wire.onReceive(receiveEvent);
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
}

void loop()
{
}
    
void receiveEvent(int howManyByte)
{
  int x = Wire.read();
  Serial.println(y);
  Serial.println(x);
  if (x==1)
  analogWrite(LED,x);
  else
  analogWrite(LED,x);
}
