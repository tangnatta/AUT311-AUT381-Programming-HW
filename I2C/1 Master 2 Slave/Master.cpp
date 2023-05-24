// https://www.tinkercad.com/things/iE9qq5I7oOF-exquisite-fyyran/editel
// Master
#include <Arduino.h>
#include <Wire.h>

#define pushButton A0
#define POTEN A1

int buttonState = 0;
int potenVal = 0;

void setup()
{
  pinMode(pushButton, INPUT);
  pinMode(POTEN, INPUT);
  pinMode(LED_BUILTIN, OUTPUT);
  Wire.begin();
}

void loop()
{
  Wire.beginTransmission(0x08);
  buttonState = digitalRead(pushButton);
  Wire.write(buttonState);
  Wire.endTransmission();
  
  Wire.beginTransmission(0x98);
  potenVal = analogRead(POTEN);
  potenVal = map(potenVal,0,1023,0,255);
  Wire.write(potenVal);
  Wire.endTransmission();
  
  delay(250);
}
