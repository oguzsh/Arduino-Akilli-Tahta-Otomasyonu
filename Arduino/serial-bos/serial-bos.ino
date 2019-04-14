
#include <Wire.h>

const int buton = A3;     
int butondurumu = 0;

void setup()
{
  
    Serial.begin(9600);

  pinMode(buton, INPUT);

  
}

void loop()
{
  
  butondurumu = digitalRead(buton);
  


   if(butondurumu == HIGH)
   {
      Serial.print('A');
     delay(1000);

  
  
  }
  
     if(butondurumu == LOW)
   {
      Serial.print('Z');
     delay(1000);

  
  
  }
  
  
  
  
}

