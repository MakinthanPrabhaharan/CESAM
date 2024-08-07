
#include "Joint.h"
#include "StringSplitter.h"
#include <AccelStepper.h>
#include <EEPROM.h>
Joint* J1;
Joint* J2;
Joint* J3;
Joint* J4;

Joint* Joints[5];


void setup() {
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(5, OUTPUT);
  digitalWrite(5, LOW);
  digitalWrite(6, LOW);
  digitalWrite(7, LOW);
  digitalWrite(8, LOW);

  
 

  Joint J1_local(1, 50, 51, 400*36, true);
  J1 = &J1_local;
  pinMode(50, OUTPUT);
  pinMode(51, OUTPUT);
  
  Joint J2_local(2,52,53,400*36, true);
  J2 = &J2_local;
  pinMode(52, OUTPUT);
  pinMode(53, OUTPUT);
  
  Joint J3_local(3,48, 49, 400*36, true);
  J3 = &J3_local;
  pinMode(48, OUTPUT);
  pinMode(49, OUTPUT);

  Joint J4_local(4, 44, 45, 400*16, true);
  J4 = &J4_local;
  pinMode(44, OUTPUT);
  pinMode(45, OUTPUT);

  

  Joints[0] = J1;
  Joints[1] = J2;
  Joints[2] = J3;
  Joints[3] = J4;
  
  Serial.begin(9600);
  Serial.setTimeout(10);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(Serial.available() > 0){
    String command = Serial.readString();
    //Serial.println(command);

    StringSplitter *cmdSplitter = new StringSplitter(command, '-', 3);

    

    if(cmdSplitter->getItemAtIndex(0).equals("JCW")){
      String strAxisIndex = cmdSplitter -> getItemAtIndex(1);
      int axisIndex = strAxisIndex.toInt() - 1;
      Joint* Joint = Joints[axisIndex];
      //JogAxisCW(Joint);
      Joint->JogCW(1500);
    }else if (cmdSplitter->getItemAtIndex(0).equals("JCC")){
      String strAxisIndex = cmdSplitter -> getItemAtIndex(1);
      int axisIndex = strAxisIndex.toInt() - 1;
      Joint* Joint = Joints[axisIndex];
      //JogAxisCCW(Joint);

      Joint->JogCCW(1500);
      
    }else if(cmdSplitter->getItemAtIndex(0).equals("AB")){
       String strAxisIndex = cmdSplitter -> getItemAtIndex(1);
      int axisIndex = strAxisIndex.toInt() - 1;
      Joint* Joint = Joints[axisIndex];
      String strAxisAngle = cmdSplitter->getItemAtIndex(2);
      double angle = strAxisAngle.toDouble();
      float maxspeed = 1700;
      float accel = 1200;
      Joint->SetAbsolutePosition(angle, maxspeed, accel); 
    }
  }

}
