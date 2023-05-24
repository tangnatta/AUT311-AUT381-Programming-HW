// https://www.tinkercad.com/things/iE9qq5I7oOF-exquisite-fyyran/editel
// Slave 0x08 | LED

#include <Arduino.h>
#include <Wire.h>

void setup()
{
  Wire.begin(0x08);
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
  Serial.println(x);
  if (x==1)
  digitalWrite(LED_BUILTIN,HIGH);
  else
  digitalWrite(LED_BUILTIN,LOW);
}
