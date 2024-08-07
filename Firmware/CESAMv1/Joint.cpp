#include "Arduino.h"
#include "Joint.h"
#include "AccelStepper.h"

//constructors

//false is counter clockwise (+), true is clockwise (-)
Joint::Joint(int axisId, int stepPin, int dirPin, int stepsPerRev, bool homingDirection){
  _axisId = axisId;
  _stepPin = stepPin;
  _dirPin = dirPin;
  _stepPin2 = -1;
  _dirPin2 = -1;
  _limitSwitchPin = -1;
  _stepsPerRev = stepsPerRev;
  _currentPosition = 0;
  _currentAngle = 0;

  _homeAngle = 0;
  _homingDirection = homingDirection;
  _accelStepper = new AccelStepper(AccelStepper::DRIVER, _stepPin, _dirPin);
  _accelStepper->setCurrentPosition(_currentPosition);
  pinMode(_stepPin, OUTPUT);
  pinMode(_dirPin, OUTPUT);
}

Joint::Joint(int axisId, int stepPin, int dirPin, int stepsPerRev, bool homingDirection, double homeAnglePosition){
  
}

Joint::Joint(int axisId, int stepPin, int dirPin, int stepsPerRev, int limitSwitchPin, bool homingDirection,double homeAnglePosition){
  
}

Joint::Joint(int axisId, int stepPin, int dirPin, int stepPin2, int dirPin2, int stepsPerRev, int limitSwitchPin, bool homingDirection){

}

Joint::Joint(int axisId, int stepPin, int dirPin, int stepPin2, int dirPin2, int stepsPerRev, int limitSwitchPin, bool homingDirection,double homeAnglePosition){

}

void Joint::SetCurrentPositionByAngle(double angle){
  _currentPosition = (angle * _stepsPerRev) / 360.0;
  //_currentAngle = angle;
  _accelStepper->setCurrentPosition(_currentPosition);
}

void Joint::SetCurrentPosition(long stepPosition){
  _currentPosition = stepPosition;
  _accelStepper->setCurrentPosition(_currentPosition);
}


void Joint::HomeAxis(){
  if(_limitSwitchPin != -1){
    
  }
}

void Joint::JogCW(float speed){
  Serial.println("Jogging CW...");
  _accelStepper->setMaxSpeed(-2000);
  _accelStepper->setSpeed(-speed);
  _accelStepper->runSpeed();
  while(true){
    if(Serial.read() == 'S'){
      break;
    }
    _accelStepper->runSpeed();
    //Step(false, 250);
  }
  Serial.println("Done jogging");
  _accelStepper->stop();
  
}

void Joint::JogCCW(float speed){
  Serial.println("Jogging CCW...");
  _accelStepper->setMaxSpeed(2000);
  _accelStepper->setSpeed(speed);
  _accelStepper->runSpeed();
  while(true){
    if(Serial.read() == 'S'){
      break;
    }
   _accelStepper->runSpeed();
    //Step(true, 250);
  }
  Serial.println("Done jogging");
  _accelStepper->stop();
  
}

void Joint::Step(bool direction, int microsecondDelay){
  digitalWrite(_stepPin, HIGH);
  digitalWrite(_dirPin, direction);
  delayMicroseconds(microsecondDelay);
  digitalWrite(_stepPin, LOW);
  digitalWrite(_dirPin, direction);
  delayMicroseconds(microsecondDelay);
  if(direction == true){
    _currentPosition++;
  }else{
    _currentPosition--;
  }
  _accelStepper->setCurrentPosition(_currentPosition);
}

void Joint::SetAbsolutePosition(double angle, float speed, float acceleration){
  Serial.println("Starting absolute move..");
  _accelStepper->setMaxSpeed(speed);
  _accelStepper->setAcceleration(acceleration);
  long position = (angle / 360) *_stepsPerRev;
  _accelStepper->moveTo(position);
  while(_accelStepper->distanceToGo() != 0){
    _accelStepper->run();
  }
  Serial.println("Reached position");
}

double Joint::getAngleFromPos(int position){
  return ((double)position * 360)/_stepsPerRev;
}