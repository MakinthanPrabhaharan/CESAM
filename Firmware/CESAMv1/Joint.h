#ifndef Joint_h
#define Joint_h
#include "Arduino.h" 
#include "AccelStepper.h"

class Joint{

  //public methods 
  public:
    //constructors for axes J1 - J4
    Joint(int axisId, int stepPin, int dirPin, int stepsPerRev, bool homingDirection);
    Joint(int axisId, int stepPin, int dirPin, int stepsPerRev, bool homingDirection, double homeAnglePosition);
    Joint(int axisId, int stepPin, int dirPin, int stepsPerRev, int limitSwitchPin, bool homingDirection,double homeAnglePosition);

    //J5 J6 constructor
    Joint(int axisId, int stepPin, int dirPin, int stepPin2, int dirPin2, int stepsPerRev, int limitSwitchPin, bool homingDirection);
    Joint(int axisId, int stepPin, int dirPin, int stepPin2, int dirPin2, int stepsPerRev, int limitSwitchPin, bool homingDirection,double homeAnglePosition);
    

    //step, home, and set absolute position methods
    
    void HomeAxis();
    void SetAbsolutePosition(double angle, float speed, float acceleration);
    void JogCW(float speed);
    void JogCCW(float speed);
    void Step(bool direction, int microsecondDelay);
    void SetCurrentPositionByAngle(double angle);
    void SetCurrentPosition(long position);

    

  //private variables
  private:
    int _axisId;
    int _stepPin;
    int _dirPin;
    int _stepPin2;
    int _dirPin2;
    int _limitSwitchPin;

    //position related
    int _stepsPerRev;
    int _currentPosition;
    double _currentAngle;
    double _homeAngle;
    bool _homingDirection;

    //accelstepper reference
    AccelStepper* _accelStepper;

    double getAngleFromPos(int position);
    

};



#endif