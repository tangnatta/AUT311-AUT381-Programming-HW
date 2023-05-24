// https://www.tinkercad.com/things/8agsrBVBjaJ-neat-wolt-turing/editel
// Master

#include <Arduino.h>
#include <Wire.h>

#define pushButton A0

int buttonState = 0;

void setup()
{
  pinMode(pushButton, INPUT);
  pinMode(LED_BUILTIN, OUTPUT);
  Wire.begin();
}

void loop()
{
  Wire.beginTransmission(0x16);
  buttonState = digitalRead(pushButton);
  Wire.write(buttonState);
  Wire.endTransmission();
  delay(100);
}
