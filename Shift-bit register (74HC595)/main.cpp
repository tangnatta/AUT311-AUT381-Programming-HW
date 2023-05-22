// https://www.tinkercad.com/things/h797oHUUZKx-grand-kasi/editel

// #include <Arduino.h>

// Arduino PINS / CI PINS
#define LATCH_PIN 5 // CI 12
#define CLOCK_PIN 6 // CI 11
#define DATA_PIN 4  // CI 14

#define DELAY_TIME 50

// 0bABCDEFGP
// 0b00000010

// For 7-segment display
byte num2Byte[] = {
    0b11111100, // 0
    0b01100000, // 1
    0b11011010, // 2
    0b11110010, // 3
    0b01100110, // 4
    0b10110110, // 5
    0b10111110, // 6
    0b11100000, // 7
    0b11111110, // 8
    0b11110110, // 9
    0b11101110, // A
    0b00111110, // b
    0b10011100, // C
    0b01111010, // d
    0b10011110, // E
    0b10001110, // F
    0b00000010  // -
};

void setup()
{
    Serial.begin(115200);

    pinMode(LATCH_PIN, OUTPUT);
    pinMode(CLOCK_PIN, OUTPUT);
    pinMode(DATA_PIN, OUTPUT);

    // //  Just a test...

    // digitalWrite(LATCH_PIN, LOW);
    // //
    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 1);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D8

    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 0);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D7

    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 1);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D6

    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 0);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D5

    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 1);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D4

    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 0);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D3

    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 1);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D2

    // digitalWrite(CLOCK_PIN, LOW);
    // digitalWrite(DATA_PIN, 0);
    // digitalWrite(CLOCK_PIN, HIGH);
    // // D1

    // digitalWrite(LATCH_PIN, HIGH);
    // delay(80);
}

void loop()
{
    for (int i = 0; i < 16; i++)
    {
        mission_F_1_1_F(i);
        delay(500);
    }
    for (int i = 15; i >= 0; i--)
    {
        mission_F_1_1_F(i);
        delay(500);
    }

    // for (float i = -15; i < 100; i += 0.1)
    // {
    //     Serial.println(round(i), HEX);

    //     twoDigitHex(i);
    //     delay(DELAY_TIME);
    // }
    // for (float i = 255; i >= -9; i -= 0.1)
    // {
    //     Serial.println(round(i), HEX);

    //     twoDigitHex(i);
    //     delay(DELAY_TIME);
    // }
}

void mission_F_1_1_F(int number){
    // Prepare CI to recive data
    digitalWrite(LATCH_PIN, LOW);

    // LSBFIRST: Normal order
    // MSBFIRST: Inverse order
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number]);
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[15-number]);

    // Inform CI to applay data
    digitalWrite(LATCH_PIN, HIGH);
}

//! Decimal
void singleDigit(int number)
{
    number = constrain(number, 0, 9);

    // Prepare CI to recive data
    digitalWrite(LATCH_PIN, LOW);

    // LSBFIRST: Normal order
    // MSBFIRST: Inverse order
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number]);
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[0]);

    // Inform CI to applay data
    digitalWrite(LATCH_PIN, HIGH);
}

void twoDigit(int number)
{
    if (number >= 0)
    {
        unsigned int num = number;
        twoDigit(num);
    }
    else
    {
        number = constrain(number, -9, 0);
        number *= -1;

        // Prepare CI to recive data
        digitalWrite(LATCH_PIN, LOW);

        // LSBFIRST: Normal order
        // MSBFIRST: Inverse order
        shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number]);
        shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[16]);

        // Inform CI to applay data
        digitalWrite(LATCH_PIN, HIGH);
    }
}

void twoDigit(unsigned int number)
{
    number = constrain(number, 0, 99);

    // Prepare CI to recive data
    digitalWrite(LATCH_PIN, LOW);

    // LSBFIRST: Normal order
    // MSBFIRST: Inverse order
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number % 10]);
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number / 10]);

    // Inform CI to applay data
    digitalWrite(LATCH_PIN, HIGH);
}

void twoDigit(float number)
{
    if (number >= 10.0)
    {
        unsigned int num = round(number);
        twoDigit(num);
        return;
    }
    else if (number < 0.0)
    {
        int num = round(number);
        twoDigit(num);
        return;
    }

    number = constrain(number, 0.0, 9.9);
    number *= 10;
    int num = round(number);

    // Prepare CI to recive data
    digitalWrite(LATCH_PIN, LOW);

    // LSBFIRST: Normal order
    // MSBFIRST: Inverse order
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[num % 10]);
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[num / 10] | bit(0));

    // Inform CI to applay data
    digitalWrite(LATCH_PIN, HIGH);
}

//! Hexadecimal
void singleDigitHex(int number)
{
    number = constrain(number, 0, 15);

    // Prepare CI to recive data
    digitalWrite(LATCH_PIN, LOW);

    // LSBFIRST: Normal order
    // MSBFIRST: Inverse order
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number]);
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[0]);

    // Inform CI to applay data
    digitalWrite(LATCH_PIN, HIGH);
}

void twoDigitHex(int number)
{
    if (number >= 0)
    {
        unsigned int num = number;
        twoDigitHex(num);
    }
    else
    {
        number = constrain(number, -15, 0);
        number *= -1;

        // Prepare CI to recive data
        digitalWrite(LATCH_PIN, LOW);

        // LSBFIRST: Normal order
        // MSBFIRST: Inverse order
        shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number]);
        shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[16]);

        // Inform CI to applay data
        digitalWrite(LATCH_PIN, HIGH);
    }
}

void twoDigitHex(unsigned int number)
{
    number = constrain(number, 0, 255);

    // Prepare CI to recive data
    digitalWrite(LATCH_PIN, LOW);

    // LSBFIRST: Normal order
    // MSBFIRST: Inverse order
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number % 16]);
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[number / 16]);

    // Inform CI to applay data
    digitalWrite(LATCH_PIN, HIGH);
}

void twoDigitHex(float number)
{
    if (number >= 16.0)
    {
        unsigned int num = round(number);
        twoDigitHex(num);
        return;
    }
    else if (number < 0.0)
    {
        int num = round(number);
        twoDigitHex(num);
        return;
    }

    number = constrain(number, 0.0, 15.9);
    number *= 10;
    int num = round(number);

    // Prepare CI to recive data
    digitalWrite(LATCH_PIN, LOW);

    // LSBFIRST: Normal order
    // MSBFIRST: Inverse order
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[num % 16]);
    shiftOut(DATA_PIN, CLOCK_PIN, LSBFIRST, num2Byte[num / 16] | bit(0));

    // Inform CI to applay data
    digitalWrite(LATCH_PIN, HIGH);
}
